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
			overlayForm = OverlayForm._Instance;
			systemTrayForm = new SystemTrayForm(this);

			var cli = ClientWindowManager._Instance;
			var udm = UggDataManager._Instance;

			overlayForm.Show();
		}

		public void Stop()
		{
			ExitThread();
		}
	}
}
