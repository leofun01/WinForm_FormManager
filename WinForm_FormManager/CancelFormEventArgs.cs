// CancelFormEventArgs.cs

using System;
using Form = System.Windows.Forms.Form;

namespace WinForm_FormManager {
	public class CancelFormEventArgs : FormEventArgs {
		public bool Cancel;
		public CancelFormEventArgs(Form form) : base(form) { }
		public CancelFormEventArgs(Form form, bool cancel) : base(form) { Cancel = cancel; }
	}
}
