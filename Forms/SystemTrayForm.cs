using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGG_Overlay.Forms
{
	public partial class SystemTrayForm : Form
	{
		private ApplicationManager applicationManager;
		public SystemTrayForm(ApplicationManager applicationManager)
		{
			InitializeComponent();
			this.applicationManager = applicationManager;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			applicationManager.Stop();
		}
	}
}
