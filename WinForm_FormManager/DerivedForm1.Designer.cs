using System.Drawing;

namespace WinForm_FormManager {
	partial class DerivedForm1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.button_CreateNewForm1 = new System.Windows.Forms.Button();
			this.button_CreateNewForm2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_CreateNewForm1
			// 
			this.button_CreateNewForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CreateNewForm1.Location = new System.Drawing.Point(13, 13);
			this.button_CreateNewForm1.Margin = new System.Windows.Forms.Padding(4);
			this.button_CreateNewForm1.Name = "button_CreateNewForm1";
			this.button_CreateNewForm1.Size = new System.Drawing.Size(198, 39);
			this.button_CreateNewForm1.TabIndex = 0;
			this.button_CreateNewForm1.Text = "create new form 1";
			this.button_CreateNewForm1.UseVisualStyleBackColor = true;
			this.button_CreateNewForm1.Click += new System.EventHandler(this.button_CreateNewForm1_Click);
			// 
			// button_CreateNewForm2
			// 
			this.button_CreateNewForm2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CreateNewForm2.Location = new System.Drawing.Point(13, 60);
			this.button_CreateNewForm2.Margin = new System.Windows.Forms.Padding(4);
			this.button_CreateNewForm2.Name = "button_CreateNewForm2";
			this.button_CreateNewForm2.Size = new System.Drawing.Size(198, 39);
			this.button_CreateNewForm2.TabIndex = 1;
			this.button_CreateNewForm2.Text = "create new form 2";
			this.button_CreateNewForm2.UseVisualStyleBackColor = true;
			this.button_CreateNewForm2.Click += new System.EventHandler(this.button_CreateNewForm2_Click);
			// 
			// DerivedForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 112);
			this.Controls.Add(this.button_CreateNewForm2);
			this.Controls.Add(this.button_CreateNewForm1);
			this.Font = new System.Drawing.Font("Consolas", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "DerivedForm1";
			this.Text = "Derived form 1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_CreateNewForm1;
		private System.Windows.Forms.Button button_CreateNewForm2;
	}
}