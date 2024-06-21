using System;
using System.Timers;
using UGG_Overlay.Forms;

namespace UGG_Overlay
{
	public class UggDataManager
	{
		public static UggDataManager _Instance { get; private set; } = new UggDataManager();

		//#####

		private Timer timer;

		private UggDataManager()
		{
			timer = new Timer(1000);
			timer.Elapsed += Timer_Elapsed;
			timer.AutoReset = true;

			ClientWindowManager.GameFoundChanged += ClientWindowManager_GameFoundChanged;
		}

		private void ClientWindowManager_GameFoundChanged(object sender, EventArgs e)
		{
			if (ClientWindowManager._Instance.GameFound)
			{
				timer.Start();
			}
			else
			{
				timer.Stop();
				OverlayForm._Instance.SetUggDisplayModel(null);
			}
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine("UggDataManger: timer tick");
			timer.Stop();

			var uggInfo = GetModelFromUggApi();
			if (uggInfo == null)
			{
				timer.Start();
				return;
			}

			OverlayForm._Instance.SetUggDisplayModel(uggInfo);
		}

		private APIs.UGG_Api.Models.ItemsDisplayModel GetModelFromUggApi()
		{
			string gameMode = ClientWindowManager._Instance.GameModeName;
			string championName = ClientWindowManager._Instance.ChampionName;

			string apiGameMode = null;
			switch (gameMode)
			{
				case "ARAM": apiGameMode = "aram"; break;
				case "CLASSIC": apiGameMode = null; break;
				default: Console.WriteLine($"OverlayForm: Unkown gameMode: {gameMode}"); return null;
			}

			string apiChampionName = null;
			switch (championName)
			{
				case "Nunu & Willump": apiChampionName = "Nunu"; break;
				default: apiChampionName = championName; break;
			}

			var uggModel = APIs.UGG_Api.UGG_API_Control.GetUGGDisplayModel(apiGameMode, apiChampionName);
			if (uggModel == null) { Console.WriteLine($"OverlayForm: UggApi null return"); return null; }

			return uggModel;
		}
	}
}
