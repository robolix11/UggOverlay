using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UGG_Overlay.Forms;
using AutoUpdaterDotNET;

namespace UGG_Overlay
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AutoUpdater.Start("https://github.com/robolix11/UggOverlay/releases/latest/download/update.xml");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ApplicationManager());
		}
	}
}
