// FormEventArgs.cs

using System;
using Form = System.Windows.Forms.Form;

namespace WinForm_FormManager {
	public class FormEventArgs : EventArgs {
		private Form _form;
		public Form Form { get { return _form; } }
		public FormEventArgs(Form form) { _form = form; }
	}
}
