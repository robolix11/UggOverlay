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
	public partial class OverlayMainControl : UserControl
	{
		private ItemsDisplayModel _Model;
		public ItemsDisplayModel Model { set { _Model = value; SetChildModels(); } }

		private void SetChildModels()
		{
			this.overlayCoreItemsDisplay1.Model = _Model?.CoreItemsDisplayModel;
			this.overlayStartItemsDisplay1.Model = _Model?.StartItemsDisplayModel;
			this.overlayFourthItemsDisplay1.Model = _Model?.FourthItemDisplayModel;
			this.overlayFithItemsDisplay1.Model = _Model?.FithItemDisplayModel;
			this.overlaySixthItemsDisplay1.Model = _Model?.SixthItemDisplayModel;
		}

		public OverlayMainControl()
		{
			InitializeComponent();
		}
	}
}
