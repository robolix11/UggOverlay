﻿using System.Windows.Forms;

namespace UGG_Overlay.Forms
{
	partial class OverlayForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Timer WindowAdaptTimer;
			this.overlayMainItemControl1 = new UGG_Overlay.Controls.OverlayMainItemControl();
			WindowAdaptTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// WindowAdaptTimer
			// 
			WindowAdaptTimer.Enabled = true;
			WindowAdaptTimer.Tick += new System.EventHandler(this.WindowAdaptTimer_Tick);
			// 
			// overlayMainItemControl1
			// 
			this.overlayMainItemControl1.BackColor = System.Drawing.Color.Transparent;
			this.overlayMainItemControl1.Location = new System.Drawing.Point(394, 12);
			this.overlayMainItemControl1.Name = "overlayMainItemControl1";
			this.overlayMainItemControl1.Size = new System.Drawing.Size(1000, 216);
			this.overlayMainItemControl1.TabIndex = 0;
			// 
			// OverlayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1419, 581);
			this.Controls.Add(this.overlayMainItemControl1);
			this.Name = "OverlayForm";
			this.Text = "OverlayForm";
			this.Load += new System.EventHandler(this.OverlayForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private UGG_Overlay.Controls.OverlayMainItemControl overlayMainItemControl1;
	}
}