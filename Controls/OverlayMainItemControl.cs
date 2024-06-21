using System;
using System.Windows.Forms;
using UGG_Overlay.APIs.UGG_Api.Models;
using UGG_Overlay.Assets;

namespace UGG_Overlay.Controls
{
	public partial class OverlayMainItemControl : UserControl
	{
		private bool showItemDisplay = true;
		public bool ShowItemDisplay { set { showItemDisplay = value; ShowItemDisplayChanged(this, null); } }

		public static event EventHandler ShowItemDisplayChanged;

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

		public OverlayMainItemControl()
		{
			InitializeComponent();
			ShowItemDisplayChanged += SetDisplayModelsVisibility;
		}

		private void ToggleMainItemOverlayVisibilityButon_Click(object sender, EventArgs e)
		{
			ShowItemDisplay = !showItemDisplay;

			if (showItemDisplay)
			{
				this.ToggleMainItemOverlayVisibilityButon.BackgroundImage = ToggleMainItemDisplayVisibilityResources.hide_view_icon_24x24;
			}
			else
			{
				this.ToggleMainItemOverlayVisibilityButon.BackgroundImage = ToggleMainItemDisplayVisibilityResources.show_view_icon_24x24;
			}
		}

		private void SetDisplayModelsVisibility(object sender, EventArgs e)
		{
			bool visibleValue = showItemDisplay;
			this.overlayCoreItemsDisplay1.Visible = visibleValue;
			this.overlayStartItemsDisplay1.Visible = visibleValue;
			this.overlayFourthItemsDisplay1.Visible = visibleValue;
			this.overlayFithItemsDisplay1.Visible = visibleValue;
			this.overlaySixthItemsDisplay1.Visible = visibleValue;
		}
	}
}
