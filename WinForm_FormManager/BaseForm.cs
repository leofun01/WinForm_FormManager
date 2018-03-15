using System;
using System.Windows.Forms;

namespace WinForm_FormManager {
	public class BaseForm : Form {
		public BaseForm() {
			FormManager.Instance.Add(this);
		}
		~BaseForm() {
			FormManager.Instance.Remove(this);
		}

		protected override void Dispose(bool disposing) {
			FormManager.Instance.Remove(this);
			base.Dispose(disposing);
		}
		protected override void OnClosed(EventArgs e) {
			FormManager.Instance.Remove(this);
			base.OnClosed(e);
		}
	}
}
