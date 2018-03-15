namespace WinForm_FormManager {
	partial class DerivedForm2 {
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
			this.button_CloseAllOtherForms = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_FormsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_CloseAllOtherForms
			// 
			this.button_CloseAllOtherForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CloseAllOtherForms.Location = new System.Drawing.Point(13, 60);
			this.button_CloseAllOtherForms.Margin = new System.Windows.Forms.Padding(4);
			this.button_CloseAllOtherForms.Name = "button_CloseAllOtherForms";
			this.button_CloseAllOtherForms.Size = new System.Drawing.Size(198, 58);
			this.button_CloseAllOtherForms.TabIndex = 0;
			this.button_CloseAllOtherForms.Text = "close all forms except this";
			this.button_CloseAllOtherForms.UseVisualStyleBackColor = true;
			this.button_CloseAllOtherForms.Click += new System.EventHandler(this.button_CloseAllOtherForms_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font("Consolas", 11.75F);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_FormsCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 129);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(224, 24);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_FormsCount
			// 
			this.toolStripStatusLabel_FormsCount.Name = "toolStripStatusLabel_FormsCount";
			this.toolStripStatusLabel_FormsCount.Size = new System.Drawing.Size(209, 19);
			this.toolStripStatusLabel_FormsCount.Spring = true;
			this.toolStripStatusLabel_FormsCount.Text = "Forms count : ";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 39);
			this.button1.TabIndex = 2;
			this.button1.Text = "create new form 1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DerivedForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 153);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button_CloseAllOtherForms);
			this.Font = new System.Drawing.Font("Consolas", 11.75F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "DerivedForm2";
			this.Text = "Derived form 2";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_CloseAllOtherForms;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_FormsCount;
		private System.Windows.Forms.Button button1;
	}
}