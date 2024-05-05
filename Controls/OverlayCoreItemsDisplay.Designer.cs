
using System.Drawing;

namespace UGG_Overlay.Controls
{
	partial class OverlayCoreItemsDisplay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlayCoreItemsDisplay));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxRightArrow1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxRightArrow2 = new System.Windows.Forms.PictureBox();
			this.overlayItemDisplay3 = new UGG_Overlay.Controls.OverlayItemDisplay();
			this.overlayItemDisplay2 = new UGG_Overlay.Controls.OverlayItemDisplay();
			this.overlayItemDisplay1 = new UGG_Overlay.Controls.OverlayItemDisplay();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Core Items";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxRightArrow1
			// 
			this.pictureBoxRightArrow1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightArrow1.Image")));
			this.pictureBoxRightArrow1.Location = new System.Drawing.Point(57, 3);
			this.pictureBoxRightArrow1.Name = "pictureBoxRightArrow1";
			this.pictureBoxRightArrow1.Size = new System.Drawing.Size(48, 48);
			this.pictureBoxRightArrow1.TabIndex = 6;
			this.pictureBoxRightArrow1.TabStop = false;
			// 
			// pictureBoxRightArrow2
			// 
			this.pictureBoxRightArrow2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightArrow2.Image")));
			this.pictureBoxRightArrow2.Location = new System.Drawing.Point(165, 3);
			this.pictureBoxRightArrow2.Name = "pictureBoxRightArrow2";
			this.pictureBoxRightArrow2.Size = new System.Drawing.Size(48, 48);
			this.pictureBoxRightArrow2.TabIndex = 7;
			this.pictureBoxRightArrow2.TabStop = false;
			// 
			// overlayItemDisplay3
			// 
			this.overlayItemDisplay3.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay3.Location = new System.Drawing.Point(219, 3);
			this.overlayItemDisplay3.Name = "overlayItemDisplay3";
			this.overlayItemDisplay3.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay3.TabIndex = 4;
			// 
			// overlayItemDisplay2
			// 
			this.overlayItemDisplay2.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay2.Location = new System.Drawing.Point(111, 3);
			this.overlayItemDisplay2.Name = "overlayItemDisplay2";
			this.overlayItemDisplay2.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay2.TabIndex = 2;
			// 
			// overlayItemDisplay1
			// 
			this.overlayItemDisplay1.BackColor = System.Drawing.Color.Black;
			this.overlayItemDisplay1.Location = new System.Drawing.Point(3, 3);
			this.overlayItemDisplay1.Name = "overlayItemDisplay1";
			this.overlayItemDisplay1.Size = new System.Drawing.Size(48, 48);
			this.overlayItemDisplay1.TabIndex = 0;
			// 
			// OverlayCoreItemsDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pictureBoxRightArrow2);
			this.Controls.Add(this.pictureBoxRightArrow1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.overlayItemDisplay3);
			this.Controls.Add(this.overlayItemDisplay2);
			this.Controls.Add(this.overlayItemDisplay1);
			this.Name = "OverlayCoreItemsDisplay";
			this.Size = new System.Drawing.Size(275, 84);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private OverlayItemDisplay overlayItemDisplay1;
		private OverlayItemDisplay overlayItemDisplay2;
		private OverlayItemDisplay overlayItemDisplay3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxRightArrow1;
		private System.Windows.Forms.PictureBox pictureBoxRightArrow2;
	}
}
