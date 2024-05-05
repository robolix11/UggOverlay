using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGG_Overlay.Controls
{
	public partial class OverlayItemDisplay : UserControl
	{
		private Bitmap _Image = null;
		
		public Bitmap Image { set { _Image = value; } }

		public OverlayItemDisplay()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Graphics g = e.Graphics;
			if (_Image != null)
			{
				g.DrawImage(_Image, 0, 0);
			}
			else
			{
				g.DrawRectangle(new Pen(Color.Black), 0, 0, 48, 48);
			}
		}
	}
}
