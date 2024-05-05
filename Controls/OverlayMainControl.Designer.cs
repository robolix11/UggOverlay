
namespace UGG_Overlay.Controls
{
	partial class OverlayMainControl
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
			this.SuspendLayout();
			// 
			// overlayStartItemsDisplay1
			// 
			this.overlayStartItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayStartItemsDisplay1.Location = new System.Drawing.Point(3, 0);
			this.overlayStartItemsDisplay1.Name = "overlayStartItemsDisplay1";
			this.overlayStartItemsDisplay1.Size = new System.Drawing.Size(166, 82);
			this.overlayStartItemsDisplay1.TabIndex = 0;
			// 
			// overlayCoreItemsDisplay1
			// 
			this.overlayCoreItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayCoreItemsDisplay1.Location = new System.Drawing.Point(175, 0);
			this.overlayCoreItemsDisplay1.Name = "overlayCoreItemsDisplay1";
			this.overlayCoreItemsDisplay1.Size = new System.Drawing.Size(275, 84);
			this.overlayCoreItemsDisplay1.TabIndex = 1;
			// 
			// overlayFourthItemsDisplay1
			// 
			this.overlayFourthItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayFourthItemsDisplay1.Location = new System.Drawing.Point(456, 0);
			this.overlayFourthItemsDisplay1.Name = "overlayFourthItemsDisplay1";
			this.overlayFourthItemsDisplay1.Size = new System.Drawing.Size(108, 81);
			this.overlayFourthItemsDisplay1.TabIndex = 2;
			// 
			// overlayFithItemsDisplay1
			// 
			this.overlayFithItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlayFithItemsDisplay1.Location = new System.Drawing.Point(570, 0);
			this.overlayFithItemsDisplay1.Name = "overlayFithItemsDisplay1";
			this.overlayFithItemsDisplay1.Size = new System.Drawing.Size(163, 84);
			this.overlayFithItemsDisplay1.TabIndex = 3;
			// 
			// overlaySixthItemsDisplay1
			// 
			this.overlaySixthItemsDisplay1.BackColor = System.Drawing.Color.Transparent;
			this.overlaySixthItemsDisplay1.Location = new System.Drawing.Point(739, 0);
			this.overlaySixthItemsDisplay1.Name = "overlaySixthItemsDisplay1";
			this.overlaySixthItemsDisplay1.Size = new System.Drawing.Size(164, 80);
			this.overlaySixthItemsDisplay1.TabIndex = 4;
			// 
			// OverlayMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.overlaySixthItemsDisplay1);
			this.Controls.Add(this.overlayFithItemsDisplay1);
			this.Controls.Add(this.overlayFourthItemsDisplay1);
			this.Controls.Add(this.overlayCoreItemsDisplay1);
			this.Controls.Add(this.overlayStartItemsDisplay1);
			this.Name = "OverlayMainControl";
			this.Size = new System.Drawing.Size(922, 92);
			this.ResumeLayout(false);

		}

		#endregion

		private OverlayStartItemsDisplay overlayStartItemsDisplay1;
		private OverlayCoreItemsDisplay overlayCoreItemsDisplay1;
		private OverlayFourthItemsDisplay overlayFourthItemsDisplay1;
		private OverlayFithItemsDisplay overlayFithItemsDisplay1;
		private OverlaySixthItemsDisplay overlaySixthItemsDisplay1;
	}
}
