
namespace UGG_Overlay.Controls
{
	partial class OverlayFithItemsDisplay
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
			this.overlayItemDisplay1 = new UGG_Overlay.Controls.OverlayItemDisplay();
			this.overlayItemDisplay2 = new UGG_Overlay.Controls.OverlayItemDisplay();
			this.overlayItemDisplay3 = new UGG_Overlay.Controls.OverlayItemDisplay();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// overlayItemDisplay1
			// 
			this.overlayItemDisplay1.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay1.Location = new System.Drawing.Point(3, 3);
			this.overlayItemDisplay1.Name = "overlayItemDisplay1";
			this.overlayItemDisplay1.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay1.TabIndex = 0;
			// 
			// overlayItemDisplay2
			// 
			this.overlayItemDisplay2.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay2.Location = new System.Drawing.Point(57, 3);
			this.overlayItemDisplay2.Name = "overlayItemDisplay2";
			this.overlayItemDisplay2.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay2.TabIndex = 1;
			// 
			// overlayItemDisplay3
			// 
			this.overlayItemDisplay3.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay3.Location = new System.Drawing.Point(111, 3);
			this.overlayItemDisplay3.Name = "overlayItemDisplay3";
			this.overlayItemDisplay3.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "5th";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OverlayFithItemsDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.overlayItemDisplay3);
			this.Controls.Add(this.overlayItemDisplay2);
			this.Controls.Add(this.overlayItemDisplay1);
			this.Name = "OverlayFithItemsDisplay";
			this.Size = new System.Drawing.Size(163, 84);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private OverlayItemDisplay overlayItemDisplay1;
		private OverlayItemDisplay overlayItemDisplay2;
		private OverlayItemDisplay overlayItemDisplay3;
		private System.Windows.Forms.Label label1;
	}
}
