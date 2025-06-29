using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UGG_Overlay.Forms
{
	public partial class OverlayForm : Form
	{
		public static OverlayForm _Instance { get; private set; } = new OverlayForm();

		public struct RECT
		{
			public int Left, Top, Right, Bottom;
		}

		public IntPtr gameWindowHandle { get; set; }

		public const string WINDOW_NAME = "League of Legends (TM) Client";

		private OverlayForm()
		{
			InitializeComponent();
		}

		private void OverlayForm_Load(object sender, EventArgs e)
		{
			this.BackColor = Constants.Colors.TRANSPARENCY;
			this.TransparencyKey = Constants.Colors.TRANSPARENCY;
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.ShowInTaskbar = false;

			//MakeFormClickTrough();
			this.Opacity = 0.75;

			AllignToCurrentParent();
		}

		//############################################################################

		public void SetUggDisplayModel(UGG_Overlay.APIs.UGG_Api.Models.ItemsDisplayModel model)
		{
			this.overlayMainItemControl1.Model = model;
			this.Invoke((MethodInvoker)delegate
			{
				this.Refresh();
			});
		}

		//############################################################################

		private void WindowAdaptTimer_Tick(object sender, EventArgs e)
		{
			AllignToCurrentParent();
		}

		public void AllignToCurrentParent()
		{
			RECT _Rect;

			IntPtr handle = FindWindow(null, WINDOW_NAME);

			gameWindowHandle = handle;
			GetWindowRect(handle, out _Rect);
			//Console.WriteLine($"Current Handle Rect [Left:{_Rect.Left},Top:{_Rect.Top},Right:{_Rect.Right},Bottom:{_Rect.Bottom}]");

			Rectangle screenBounds = Screen.FromHandle(handle).Bounds;
			bool isFullscreen = ((_Rect.Bottom - _Rect.Top) == screenBounds.Height && (_Rect.Right - _Rect.Left) == screenBounds.Width);

			IntPtr foregroundWindow = GetForegroundWindow();
			bool isForegreoundWindow = handle == foregroundWindow || this.Handle == foregroundWindow;
			//Console.WriteLine($"Foreground Window: {isForegreoundWindow}, Current FG Window: {GetWindowTitle(foregroundWindow)}");

			if (handle == IntPtr.Zero || IsIconic(handle) /*Minimized*/ || !isForegreoundWindow)
			{
				//Console.WriteLine($"should hide, currently Visible: {this.Visible}");
				if (this.Visible)
				{
					this.Hide();
				}
			}
			else
			{
				//Console.WriteLine($"should show, currently Visible: {this.Visible}");
				if (!this.Visible)
				{
					this.Show();
				}
			}

			if (isFullscreen)
			{
				this.SetBounds(0, 0, screenBounds.Width, screenBounds.Height);
				this.Size = new Size(screenBounds.Width, screenBounds.Height);
				this.Top = 0;
				this.Left = 0;
			}
			else
			{
				this.SetBounds(_Rect.Left, _Rect.Top, _Rect.Right - _Rect.Left, _Rect.Bottom - _Rect.Top);
				this.Size = new Size(_Rect.Right - _Rect.Left, _Rect.Bottom - _Rect.Top);
				this.Top = _Rect.Top;
				this.Left = _Rect.Left;
			}

			//Console.WriteLine($"FormBounds: [Left:{this.Left},Top:{this.Top},Right:{this.Right},Bottom:{this.Bottom}]");
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			foreach (Control c in this.Controls)
			{
				c.Refresh();
			}
		}

		public void MakeFormClickTrough()
		{
			int _InitialStyle = GetWindowLong(this.Handle, -20);
			SetWindowLong(this.Handle, -20, _InitialStyle | 0x80000 | 0x20);
		}

		public void MakeFormNormal()
		{
			int _InitialStyle = GetWindowLong(this.Handle, -20);
			SetWindowLong(this.Handle, -20, _InitialStyle | 0x80000);
		}

		//############################################################################

		[DllImport("user32.dll")]
		static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool IsIconic(IntPtr hWnd);

		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();
	}
}
