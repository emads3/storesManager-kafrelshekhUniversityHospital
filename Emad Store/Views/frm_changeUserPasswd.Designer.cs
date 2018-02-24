namespace Emad_Store.Views
{
	partial class frm_changeUserPasswd
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_changeUserPasswd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNewPasswd2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOldPasswd = new System.Windows.Forms.TextBox();
			this.txtNewPasswd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNewPasswd2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtOldPasswd);
			this.groupBox1.Controls.Add(this.txtNewPasswd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox1.Size = new System.Drawing.Size(532, 146);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات المستخدم";
			// 
			// txtNewPasswd2
			// 
			this.txtNewPasswd2.Location = new System.Drawing.Point(7, 101);
			this.txtNewPasswd2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtNewPasswd2.Name = "txtNewPasswd2";
			this.txtNewPasswd2.Size = new System.Drawing.Size(258, 24);
			this.txtNewPasswd2.TabIndex = 6;
			this.txtNewPasswd2.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(273, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "اعد كتابة كلمة السر الجديدة مرة اخري";
			// 
			// txtOldPasswd
			// 
			this.txtOldPasswd.Location = new System.Drawing.Point(7, 26);
			this.txtOldPasswd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtOldPasswd.Name = "txtOldPasswd";
			this.txtOldPasswd.Size = new System.Drawing.Size(258, 24);
			this.txtOldPasswd.TabIndex = 0;
			this.txtOldPasswd.UseSystemPasswordChar = true;
			// 
			// txtNewPasswd
			// 
			this.txtNewPasswd.Location = new System.Drawing.Point(7, 69);
			this.txtNewPasswd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtNewPasswd.Name = "txtNewPasswd";
			this.txtNewPasswd.Size = new System.Drawing.Size(258, 24);
			this.txtNewPasswd.TabIndex = 1;
			this.txtNewPasswd.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "كلمة السر الجديدة :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "كلمة السر القديمة :";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.button2.Location = new System.Drawing.Point(275, 170);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 46);
			this.button2.TabIndex = 9;
			this.button2.Text = "الغاء";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(382, 170);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 46);
			this.button1.TabIndex = 8;
			this.button1.Text = "تغير كلمة السر";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frm_changeUserPasswd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 226);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Tahoma", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_changeUserPasswd";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تغير كلمة السر";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNewPasswd2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOldPasswd;
		private System.Windows.Forms.TextBox txtNewPasswd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}