using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UGG_Overlay.Forms;

namespace UGG_Overlay
{
	public class ApplicationManager : ApplicationContext
	{
		OverlayForm overlayForm;
		SystemTrayForm systemTrayForm;

		public ApplicationManager()
		{
			overlayForm = new OverlayForm();
			systemTrayForm = new SystemTrayForm(this);

			overlayForm.Show();
		}

		public void Stop()
		{
			ExitThread();
		}
	}
}
