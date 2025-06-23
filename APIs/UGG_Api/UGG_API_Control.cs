using Fizzler.Systems.HtmlAgilityPack;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UGG_Overlay.APIs.UGG_Api
{
	class UGG_API_Control
	{
		const string BASE_URL = "https://u.gg/lol/champions/";

		public static Models.ItemsDisplayModel GetUGGDisplayModel(string gamemode, string championName)
		{
			Models.ItemsDisplayModel returnModel = new Models.ItemsDisplayModel();

			Task<string> responseTask = GetApiResponse(gamemode, championName);
			try { responseTask.Wait(); } catch (Exception e) { return null; }
			string htmlString = responseTask.Result;

			HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
			html.LoadHtml(htmlString);

			var startingItemNodes = html.DocumentNode.QuerySelectorAll(".starting-items .item-img > div > div");
			returnModel.StartItemsDisplayModel = new Models.StartItemsDisplayModel()
			{
				Image1 = ParseItemDisplayNode(startingItemNodes.Count() >= 1 ? startingItemNodes.ElementAt(0) : null),
				Image2 = ParseItemDisplayNode(startingItemNodes.Count() >= 2 ? startingItemNodes.ElementAt(1) : null),
				Image3 = ParseItemDisplayNode(startingItemNodes.Count() >= 3 ? startingItemNodes.ElementAt(2) : null),
			};

			var coreItemNodes = html.DocumentNode.QuerySelectorAll(".core-items .image-wrapper > div > div > div");
			returnModel.CoreItemsDisplayModel = new Models.CoreItemsDisplayModel()
			{
				Image1 = ParseItemDisplayNode(coreItemNodes.ElementAt(0)),
				Image2 = ParseItemDisplayNode(coreItemNodes.ElementAt(1)),
				Image3 = ParseItemDisplayNode(coreItemNodes.ElementAt(2)),
			};

			var fourthItemNodes = html.DocumentNode.QuerySelectorAll(".item-options-1 .item-option > div > div > div");
			returnModel.FourthItemDisplayModel = new Models.FourthItemDisplayModel()
			{
				Image1 = ParseItemDisplayNode(fourthItemNodes.ElementAt(0)),
				Image2 = ParseItemDisplayNode(fourthItemNodes.ElementAt(1)),
			};

			var fithItemNodes = html.DocumentNode.QuerySelectorAll(".item-options-2 .item-option > div > div > div");
			returnModel.FithItemDisplayModel = new Models.FithItemDisplayModel()
			{
				Image1 = ParseItemDisplayNode(fithItemNodes.ElementAt(0)),
				Image2 = ParseItemDisplayNode(fithItemNodes.ElementAt(1)),
				Image3 = ParseItemDisplayNode(fithItemNodes.ElementAt(2)),
			};

			var sixthItemNodes = html.DocumentNode.QuerySelectorAll(".item-options-3 .item-option > div > div > div");
			returnModel.SixthItemDisplayModel = new Models.SixthItemDisplayModel()
			{
				Image1 = ParseItemDisplayNode(sixthItemNodes.ElementAt(0)),
				Image2 = ParseItemDisplayNode(sixthItemNodes.ElementAt(1)),
				Image3 = ParseItemDisplayNode(sixthItemNodes.ElementAt(2)),
			};

			return returnModel;
		}

		private static async Task<string> GetApiResponse(string gamemode, string championName)
		{
			string url = BASE_URL + (gamemode == null ? "" : gamemode + "/") + championName + (gamemode == null ? "/build" : $"-{gamemode}");

			bool success = false;
			int tryCount = 1;
			string response = null;
			do
			{
				Console.WriteLine($"getting Champion Builld ... try Nr {tryCount}");
				try
				{
					using (HttpResponseMessage responseMessage = API_Helper.ApiClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, url) { Version = HttpVersion.Version10 }).GetAwaiter().GetResult())
					{
						if (responseMessage.StatusCode == HttpStatusCode.OK)
						{
							return await responseMessage.Content.ReadAsStringAsync();
						}
					}
				}
				catch (HttpRequestException e)
				{
					Console.WriteLine($"Error on HttpRequest [{url}]\r\n{e.Message}");
				}
				tryCount++;
			} while (success == false);

			return response;
		}

		private static Bitmap ParseItemDisplayNode(HtmlAgilityPack.HtmlNode node)
		{
			if (node == null) { return null; }

			string style = node.Attributes["style"].Value;
			Match urlMatch = Regex.Match(style, "url\\(.*?\\)");
			string itemSheetURL = urlMatch.Value.Substring(4, urlMatch.Value.Length - 5);
			Match posMatch = Regex.Match(style, "background-position:.*?;");
			string startCoords = posMatch.Value.Substring(21, posMatch.Value.Length - 22).Replace("px", "").Replace("-", "").Trim();



			Task<Bitmap> task = GetSheetImageFromURL(itemSheetURL);
			task.Wait();
			Bitmap itemSheet = task.Result;
			int[] startCoordsInts = startCoords.Split(new char[] { ' ' }).Select(s => int.Parse(s)).ToArray();
			Bitmap itemImage = itemSheet.Clone(Rectangle.FromLTRB(startCoordsInts[0], startCoordsInts[1], startCoordsInts[0] + 48, startCoordsInts[1] + 48), itemSheet.PixelFormat);

			return itemImage;
		}

		private static async Task<Bitmap> GetSheetImageFromURL(string itmSheetURL)
		{
			bool success = false;
			int tryCount = 1;
			byte[] response = null;
			do
			{
				Console.WriteLine($"getting ItemSheet ... try Nr {tryCount}");
				try
				{
					using (HttpResponseMessage responseMessage = await API_Helper.ApiClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, itmSheetURL) { Version = HttpVersion.Version10 }).ConfigureAwait(false))
					{
						if (responseMessage.StatusCode == HttpStatusCode.OK)
						{
							response = await responseMessage.Content.ReadAsByteArrayAsync();
							success = true;
						}
					}
				}
				catch (HttpRequestException e)
				{
					Console.WriteLine($"Error on HttpRequest [{itmSheetURL}]\r\n{e.Message}");
				}
				tryCount++;
			} while (success == false);
			return Dynamicweb.WebP.Decoder.Decode(response);
		}
	}
}
