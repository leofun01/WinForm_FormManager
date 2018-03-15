using System;
using System.Windows.Forms;

namespace WinForm_FormManager {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			BaseForm form = new DerivedForm1();
			form.Show();
			Application.Run(FormManager.Instance);
			//Application.Run();
			//Application.Run(form);
		}
	}
}
