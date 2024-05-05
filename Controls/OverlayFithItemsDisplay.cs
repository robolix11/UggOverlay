using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UGG_Overlay.APIs.UGG_Api.Models;

namespace UGG_Overlay.Controls
{
	public partial class OverlayFithItemsDisplay : UserControl
	{
		FithItemDisplayModel _Model;
		public FithItemDisplayModel Model { set { _Model = value; RefreshDisplays(); } }

		public OverlayFithItemsDisplay()
		{
			InitializeComponent();
		}

		private void RefreshDisplays()
		{
			this.overlayItemDisplay1.Image = _Model.Image1;
			this.overlayItemDisplay2.Image = _Model.Image2;
			this.overlayItemDisplay3.Image = _Model.Image3;
		}
	}
}
