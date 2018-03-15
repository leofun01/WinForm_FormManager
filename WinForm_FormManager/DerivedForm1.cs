using System;
using System.Windows.Forms;

namespace WinForm_FormManager {
	public partial class DerivedForm1 : BaseForm {
		public DerivedForm1() {
			InitializeComponent();
		}

		private void button_CreateNewForm1_Click(object sender, EventArgs e) {
			BaseForm form = new DerivedForm1();
			form.Show();
		}

		private void button_CreateNewForm2_Click(object sender, EventArgs e) {
			BaseForm form = new DerivedForm2();
			form.Show();
		}
	}
}
