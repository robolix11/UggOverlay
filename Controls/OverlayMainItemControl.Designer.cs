
namespace UGG_Overlay.Controls
{
	partial class OverlayMainItemControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.overlayStartItemsDisplay1 = new UGG_Overlay.Controls.OverlayStartItemsDisplay();
			this.overlayCoreItemsDisplay1 = new UGG_Overlay.Controls.OverlayCoreItemsDisplay();
			this.overlayFourthItemsDisplay1 = new UGG_Overlay.Controls.OverlayFourthItemsDisplay();
			this.overlayFithItemsDisplay1 = new UGG_Overlay.Controls.OverlayFithItemsDisplay();
			this.overlaySixthItemsDisplay1 = new UGG_Overlay.Controls.OverlaySixthItemsDisplay();
			this.ToggleMainItemOverlayVisibilityButon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// overlayStartItemsDisplay1
			// 
			this.overlayStartItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayStartItemsDisplay1.Location = new System.Drawing.Point(0, -1);
			this.overlayStartItemsDisplay1.Name = "overlayStartItemsDisplay1";
			this.overlayStartItemsDisplay1.Size = new System.Drawing.Size(156, 80);
			this.overlayStartItemsDisplay1.TabIndex = 0;
			// 
			// overlayCoreItemsDisplay1
			// 
			this.overlayCoreItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayCoreItemsDisplay1.Location = new System.Drawing.Point(162, -1);
			this.overlayCoreItemsDisplay1.Name = "overlayCoreItemsDisplay1";
			this.overlayCoreItemsDisplay1.Size = new System.Drawing.Size(200, 80);
			this.overlayCoreItemsDisplay1.TabIndex = 1;
			// 
			// overlayFourthItemsDisplay1
			// 
			this.overlayFourthItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayFourthItemsDisplay1.Location = new System.Drawing.Point(368, -1);
			this.overlayFourthItemsDisplay1.Name = "overlayFourthItemsDisplay1";
			this.overlayFourthItemsDisplay1.Size = new System.Drawing.Size(102, 80);
			this.overlayFourthItemsDisplay1.TabIndex = 2;
			// 
			// overlayFithItemsDisplay1
			// 
			this.overlayFithItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayFithItemsDisplay1.Location = new System.Drawing.Point(476, -1);
			this.overlayFithItemsDisplay1.Name = "overlayFithItemsDisplay1";
			this.overlayFithItemsDisplay1.Size = new System.Drawing.Size(156, 80);
			this.overlayFithItemsDisplay1.TabIndex = 3;
			// 
			// overlaySixthItemsDisplay1
			// 
			this.overlaySixthItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlaySixthItemsDisplay1.Location = new System.Drawing.Point(638, -1);
			this.overlaySixthItemsDisplay1.Name = "overlaySixthItemsDisplay1";
			this.overlaySixthItemsDisplay1.Size = new System.Drawing.Size(156, 80);
			this.overlaySixthItemsDisplay1.TabIndex = 4;
			// 
			// ToggleMainItemOverlayVisibilityButon
			// 
			this.ToggleMainItemOverlayVisibilityButon.BackColor = System.Drawing.Color.Transparent;
			this.ToggleMainItemOverlayVisibilityButon.BackgroundImage = global::UGG_Overlay.Properties.Resources.show_view_icon_24x24;
			this.ToggleMainItemOverlayVisibilityButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ToggleMainItemOverlayVisibilityButon.FlatAppearance.BorderSize = 0;
			this.ToggleMainItemOverlayVisibilityButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ToggleMainItemOverlayVisibilityButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ToggleMainItemOverlayVisibilityButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToggleMainItemOverlayVisibilityButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToggleMainItemOverlayVisibilityButon.Location = new System.Drawing.Point(797, -1);
			this.ToggleMainItemOverlayVisibilityButon.Margin = new System.Windows.Forms.Padding(0);
			this.ToggleMainItemOverlayVisibilityButon.Name = "ToggleMainItemOverlayVisibilityButon";
			this.ToggleMainItemOverlayVisibilityButon.Padding = new System.Windows.Forms.Padding(3);
			this.ToggleMainItemOverlayVisibilityButon.Size = new System.Drawing.Size(24, 24);
			this.ToggleMainItemOverlayVisibilityButon.TabIndex = 5;
			this.ToggleMainItemOverlayVisibilityButon.UseVisualStyleBackColor = false;
			this.ToggleMainItemOverlayVisibilityButon.Click += new System.EventHandler(this.ToggleMainItemOverlayVisibilityButon_Click);
			// 
			// OverlayMainItemControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.ToggleMainItemOverlayVisibilityButon);
			this.Controls.Add(this.overlaySixthItemsDisplay1);
			this.Controls.Add(this.overlayFithItemsDisplay1);
			this.Controls.Add(this.overlayFourthItemsDisplay1);
			this.Controls.Add(this.overlayCoreItemsDisplay1);
			this.Controls.Add(this.overlayStartItemsDisplay1);
			this.Name = "OverlayMainItemControl";
			this.Size = new System.Drawing.Size(825, 80);
			this.ResumeLayout(false);

		}

		#endregion

		private OverlayStartItemsDisplay overlayStartItemsDisplay1;
		private OverlayCoreItemsDisplay overlayCoreItemsDisplay1;
		private OverlayFourthItemsDisplay overlayFourthItemsDisplay1;
		private OverlayFithItemsDisplay overlayFithItemsDisplay1;
		private OverlaySixthItemsDisplay overlaySixthItemsDisplay1;
		private System.Windows.Forms.Button ToggleMainItemOverlayVisibilityButon;
	}
}
