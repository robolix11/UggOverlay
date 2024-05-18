using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using UGG_Overlay.APIs.RiotClientApi.Models;
using System.Net;
using System.Runtime.CompilerServices;
using System.Net.Sockets;

namespace UGG_Overlay.APIs.RiotClientApi
{
	public class RiotClientApiControl
	{
		const string BASE_URL = "https://127.0.0.1:2999/liveclientdata/";

		public static Tuple<string, string> GetCurrentGameInformation()
		{
			if (!ConnectionExists()) { Console.WriteLine("No Connection to game API."); return null; }

			string playerName;
			Task<string> getPlayerNameTask = GetPlayerName();
			getPlayerNameTask.Wait();
			playerName = getPlayerNameTask.Result;

			string gameMode;
			Task<string> getGameModeTask = GetCurrentGameMode();
			getGameModeTask.Wait();
			gameMode = getGameModeTask.Result;

			string championName;
			Task<string> getChampionNameTask = GetCurrentChampionName(playerName);
			getChampionNameTask.Wait();
			championName = getChampionNameTask.Result;

			return new Tuple<string, string>(gameMode, championName);
		}

		public static bool ConnectionExists()
		{
			string url = BASE_URL + "activeplayername";
			Task<HttpResponseMessage> tsk = GetClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Version = HttpVersion.Version10 });
			try { tsk.Wait(); }
			catch (Exception e) { return false; }
			using (HttpResponseMessage response = tsk.Result)
			{
				return response.StatusCode == HttpStatusCode.OK;
			}
		}

		private static async Task<string> GetPlayerName()
		{
			string url = BASE_URL + "activeplayername";
			using (HttpResponseMessage response = await GetClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Version = HttpVersion.Version10 }).ConfigureAwait(false))
			{
				return await response.Content.ReadAsStringAsync();
			}
		}

		private static async Task<string> GetCurrentGameMode()
		{
			string url = BASE_URL + "gamestats";

			using (HttpResponseMessage response = await GetClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Version = HttpVersion.Version10 }).ConfigureAwait(false))
			{
				if (response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					return (await response.Content.ReadAsAsync<GameStatsModel>()).gameMode;
				}
			}
			return null;
		}

		private static async Task<string> GetCurrentChampionName(string playerName)
		{
			string url = BASE_URL + "playerlist";
			using (HttpResponseMessage response = await GetClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Version = HttpVersion.Version10 }).ConfigureAwait(false))
			{
				if (response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					PlayerListModel[] data = await response.Content.ReadAsAsync<PlayerListModel[]>();
					PlayerListModel currPlayerEntry = data.Single(pl => pl.summonerName == playerName.Replace("\"", ""));//.Substring(0, playerName.IndexOf("#") - 1));
					return currPlayerEntry.championName;
				}
			}
			return null;
		}

		private static HttpClient GetClient()
		{
			var handler = new HttpClientHandler();
			handler.ClientCertificateOptions = ClientCertificateOption.Manual;
			handler.ServerCertificateCustomValidationCallback =
				(httpRequestMessage, cert, cetChain, policyErrors) =>
				{
					return true;
				};

			return new HttpClient(handler);
		}
	}
}
