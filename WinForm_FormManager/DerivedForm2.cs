using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CultureInfo = System.Globalization.CultureInfo;

namespace WinForm_FormManager {
	public partial class DerivedForm2 : BaseForm {
		public DerivedForm2() {
			InitializeComponent();
			FormManager.Instance.FormAdded += FormsCountChanged;
			FormManager.Instance.FormRemoved += FormsCountChanged;
			FormsCountChanged(this, new FormEventArgs(this));
		}
		protected override void OnClosed(EventArgs e) {
			FormManager.Instance.FormAdded -= FormsCountChanged;
			FormManager.Instance.FormRemoved -= FormsCountChanged;
			base.OnClosed(e);
		}
		void FormsCountChanged(object sender, FormEventArgs e) {
			this.toolStripStatusLabel_FormsCount.Text = string.Format(
				CultureInfo.InvariantCulture,
				"Forms count : {0}",
				FormManager.Instance.Count
			);
		}

		private void button_CloseAllOtherForms_Click(object sender, EventArgs e) {
			FormManager.Instance.RemoveAll(f => {
				if(f == this) return false;
				f.Close();
				return true;
			});
		}

		private void button1_Click(object sender, EventArgs e) {
			BaseForm form = new DerivedForm1();
			form.Show();
		}
	}
}
