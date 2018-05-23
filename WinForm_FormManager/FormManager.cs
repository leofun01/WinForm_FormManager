// FormManager.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm_FormManager {
	public class FormManager : ApplicationContext, IEnumerable<BaseForm>, ICollection<BaseForm> {
		public static readonly FormManager Instance = new FormManager();

		private readonly List<BaseForm> _forms_list = new List<BaseForm>();
		public System.Collections.ObjectModel.ReadOnlyCollection<BaseForm> FormList {
			get { return _forms_list.AsReadOnly(); }
		}

		private FormManager() {
			//Application.ThreadExit += Application_ThreadExit;
			//Application.ApplicationExit += Application_ApplicationExit;
		}
		/*//
		private static void Application_ThreadExit(object sender, EventArgs e) {
			MessageBox.Show(Application.OpenForms.Count.ToString(), "ThreadExit");
		}
		//*/
		/*//
		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			MessageBox.Show(Application.OpenForms.Count.ToString(), "ApplicationExit");
		}
		//*/

		public int Count {
			get { return _forms_list.Count; }
		}
		public bool Add(BaseForm form) {
			if(_forms_list.Contains(form))
				return false;
			EventHandler<CancelFormEventArgs> adding;
			EventHandler<FormEventArgs> added;
			lock(_lock_obj) {
				adding = _form_adding;
				added = _form_added;
			}
			if(adding != null) {
				CancelFormEventArgs args = new CancelFormEventArgs(form);
				bool cancel = false;
				foreach(EventHandler<CancelFormEventArgs> handler in adding.GetInvocationList()) {
					args.Cancel = false;
					handler(this, args);
					cancel |= args.Cancel;
				}
				if(cancel) return false;
			}
			_forms_list.Add(form);
			if(added != null)
				added(this, new FormEventArgs(form));
			return true;
		}
		public bool Remove(BaseForm form) {
			if(!_forms_list.Contains(form))
				return false;
			EventHandler<CancelFormEventArgs> removing;
			EventHandler<FormEventArgs> removed;
			lock(_lock_obj) {
				removing = _form_removing;
				removed = _form_removed;
			}
			if(removing != null) {
				CancelFormEventArgs args = new CancelFormEventArgs(form);
				bool cancel = false;
				foreach(EventHandler<CancelFormEventArgs> handler in removing.GetInvocationList()) {
					args.Cancel = false;
					handler(this, args);
					cancel |= args.Cancel;
				}
				if(cancel) return false;
			}
			_forms_list.Remove(form);
			if(removed != null)
				removed(this, new FormEventArgs(form));
			bool exit = true;
			foreach(BaseForm item in _forms_list)
				exit &= !item.Visible;
			if(exit) {
				Application.ExitThread();
				//Application.Exit();
			}
			return true;
		}
		public void RemoveAll(Predicate<BaseForm> pred) {
			IEnumerable<BaseForm> list = _forms_list.ToArray();
			foreach(BaseForm form in list)
				if(pred(form)) Remove(form);
		}
		public bool Contains(BaseForm form) {
			return _forms_list.Contains(form);
		}

		public IEnumerator<BaseForm> GetEnumerator() {
			return _forms_list.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}

		bool ICollection<BaseForm>.IsReadOnly {
			get { return ((ICollection<BaseForm>)_forms_list).IsReadOnly; }
		}
		void ICollection<BaseForm>.Add(BaseForm item) {
			Add(item);
		}
		void ICollection<BaseForm>.Clear() {
			EventHandler<FormEventArgs> removed;
			lock(_lock_obj)
				removed = _form_removed;
			if(removed != null)
				foreach(BaseForm form in _forms_list)
					removed(this, new FormEventArgs(form));
			_forms_list.Clear();
			Application.ExitThread();
			//Application.Exit();
		}
		void ICollection<BaseForm>.CopyTo(BaseForm[] array, int arrayIndex) {
			_forms_list.CopyTo(array, arrayIndex);
		}

		private readonly object _lock_obj = new object();
		private EventHandler<CancelFormEventArgs> _form_adding;
		public event EventHandler<CancelFormEventArgs> FormAdding {
			add { lock(_lock_obj) { _form_adding += value; } }
			remove { lock(_lock_obj) { _form_adding -= value; } }
		}
		private EventHandler<FormEventArgs> _form_added;
		public event EventHandler<FormEventArgs> FormAdded {
			add { lock(_lock_obj) { _form_added += value; } }
			remove { lock(_lock_obj) { _form_added -= value; } }
		}
		private EventHandler<CancelFormEventArgs> _form_removing;
		public event EventHandler<CancelFormEventArgs> FormRemoving {
			add { lock(_lock_obj) { _form_removing += value; } }
			remove { lock(_lock_obj) { _form_removing -= value; } }
		}
		private EventHandler<FormEventArgs> _form_removed;
		public event EventHandler<FormEventArgs> FormRemoved {
			add { lock(_lock_obj) { _form_removed += value; } }
			remove { lock(_lock_obj) { _form_removed -= value; } }
		}
	}
}
