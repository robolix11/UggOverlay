
namespace UGG_Overlay.Controls
{
	partial class OverlayFourthItemsDisplay
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
			this.label1 = new System.Windows.Forms.Label();
			this.horzLineControl1 = new UGG_Overlay.Controls.HorzLineControl();
			this.horzLineControl2 = new UGG_Overlay.Controls.HorzLineControl();
			this.vertLineControl1 = new UGG_Overlay.Controls.VertLineControl();
			this.vertLineControl2 = new UGG_Overlay.Controls.VertLineControl();
			this.SuspendLayout();
			// 
			// overlayItemDisplay1
			// 
			this.overlayItemDisplay1.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay1.Location = new System.Drawing.Point(0, 0);
			this.overlayItemDisplay1.Name = "overlayItemDisplay1";
			this.overlayItemDisplay1.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay1.TabIndex = 0;
			// 
			// overlayItemDisplay2
			// 
			this.overlayItemDisplay2.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay2.Location = new System.Drawing.Point(54, 0);
			this.overlayItemDisplay2.Name = "overlayItemDisplay2";
			this.overlayItemDisplay2.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(34, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "4th";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// horzLineControl1
			// 
			this.horzLineControl1.BackColor = System.Drawing.Color.DarkGray;
			this.horzLineControl1.Location = new System.Drawing.Point(24, 60);
			this.horzLineControl1.MaximumSize = new System.Drawing.Size(500, 2);
			this.horzLineControl1.MinimumSize = new System.Drawing.Size(0, 2);
			this.horzLineControl1.Name = "horzLineControl1";
			this.horzLineControl1.Size = new System.Drawing.Size(10, 2);
			this.horzLineControl1.TabIndex = 4;
			// 
			// horzLineControl2
			// 
			this.horzLineControl2.BackColor = System.Drawing.Color.DarkGray;
			this.horzLineControl2.Location = new System.Drawing.Point(70, 60);
			this.horzLineControl2.MaximumSize = new System.Drawing.Size(500, 2);
			this.horzLineControl2.MinimumSize = new System.Drawing.Size(0, 2);
			this.horzLineControl2.Name = "horzLineControl2";
			this.horzLineControl2.Size = new System.Drawing.Size(10, 2);
			this.horzLineControl2.TabIndex = 5;
			// 
			// vertLineControl1
			// 
			this.vertLineControl1.BackColor = System.Drawing.Color.DarkGray;
			this.vertLineControl1.Location = new System.Drawing.Point(80, 55);
			this.vertLineControl1.MaximumSize = new System.Drawing.Size(2, 500);
			this.vertLineControl1.MinimumSize = new System.Drawing.Size(2, 0);
			this.vertLineControl1.Name = "vertLineControl1";
			this.vertLineControl1.Size = new System.Drawing.Size(2, 10);
			this.vertLineControl1.TabIndex = 6;
			// 
			// vertLineControl2
			// 
			this.vertLineControl2.BackColor = System.Drawing.Color.DarkGray;
			this.vertLineControl2.Location = new System.Drawing.Point(24, 55);
			this.vertLineControl2.MaximumSize = new System.Drawing.Size(2, 500);
			this.vertLineControl2.MinimumSize = new System.Drawing.Size(2, 0);
			this.vertLineControl2.Name = "vertLineControl2";
			this.vertLineControl2.Size = new System.Drawing.Size(2, 10);
			this.vertLineControl2.TabIndex = 7;
			// 
			// OverlayFourthItemsDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.vertLineControl2);
			this.Controls.Add(this.vertLineControl1);
			this.Controls.Add(this.horzLineControl2);
			this.Controls.Add(this.horzLineControl1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.overlayItemDisplay2);
			this.Controls.Add(this.overlayItemDisplay1);
			this.Name = "OverlayFourthItemsDisplay";
			this.Size = new System.Drawing.Size(102, 80);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private OverlayItemDisplay overlayItemDisplay1;
		private OverlayItemDisplay overlayItemDisplay2;
		private System.Windows.Forms.Label label1;
		private HorzLineControl horzLineControl1;
		private HorzLineControl horzLineControl2;
		private VertLineControl vertLineControl1;
		private VertLineControl vertLineControl2;
	}
}
