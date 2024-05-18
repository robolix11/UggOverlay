using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UGG_Overlay
{
	public class ClientWindowManager
	{
		public static ClientWindowManager _Instance { get; private set; } = new ClientWindowManager();

		private bool gameFound;
		public bool GameFound
		{
			get { return gameFound; }
			private set
			{
				bool changed = gameFound != value;
				gameFound = value;

				if (changed)
				{
					Console.WriteLine($"ClientWindowManager: GameFound value changed, new Value: {value}");
					GameFoundChanged(this, null);
				}
			}
		}
		public static event EventHandler GameFoundChanged;

		public string ChampionName { get; private set; }
		public string GameModeName { get; private set; }

		//#####

		private Timer timer;
		public ClientWindowManager()
		{
			timer = new Timer(1000);
			timer.Elapsed += Timer_Elapsed;
			timer.AutoReset = true;
			timer.Start();
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine("ClientWindowManger: timer tick");

			var gameInfo = APIs.RiotClientApi.RiotClientApiControl.GetCurrentGameInformation();

			GameFound = gameInfo != null;
			GameModeName = gameInfo?.Item1;
			ChampionName = gameInfo?.Item2;
		}
	}
}
