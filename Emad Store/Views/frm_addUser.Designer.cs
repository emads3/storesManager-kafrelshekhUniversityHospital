namespace Emad_Store.Views
{
	partial class frm_addUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addUser));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtPasswd = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(4, 2);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(415, 219);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnCancel);
			this.tabPage1.Controls.Add(this.btnAddUser);
			this.tabPage1.Controls.Add(this.txtPhoneNo);
			this.tabPage1.Controls.Add(this.txtFullName);
			this.tabPage1.Controls.Add(this.txtPasswd);
			this.tabPage1.Controls.Add(this.txtUsername);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage1.Size = new System.Drawing.Size(407, 190);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "بيانات المستخدم الاساسية";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(161, 145);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(87, 37);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "الغاء";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddUser.Location = new System.Drawing.Point(18, 145);
			this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(137, 37);
			this.btnAddUser.TabIndex = 8;
			this.btnAddUser.Text = "اضافة المستخدم";
			this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// txtPhoneNo
			// 
			this.txtPhoneNo.Location = new System.Drawing.Point(18, 109);
			this.txtPhoneNo.MaxLength = 15;
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPhoneNo.Size = new System.Drawing.Size(206, 24);
			this.txtPhoneNo.TabIndex = 7;
			this.txtPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(18, 79);
			this.txtFullName.MaxLength = 100;
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFullName.Size = new System.Drawing.Size(206, 24);
			this.txtFullName.TabIndex = 6;
			this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtPasswd
			// 
			this.txtPasswd.Location = new System.Drawing.Point(18, 46);
			this.txtPasswd.Name = "txtPasswd";
			this.txtPasswd.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPasswd.Size = new System.Drawing.Size(206, 24);
			this.txtPasswd.TabIndex = 5;
			this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPasswd.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(18, 16);
			this.txtUsername.MaxLength = 30;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtUsername.Size = new System.Drawing.Size(206, 24);
			this.txtUsername.TabIndex = 4;
			this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(242, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "رقم التليفون :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(242, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "اسم المستخدم رباعياً :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "كلمة السر :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(242, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "اسم الدخول للبرنامج :";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage2.Size = new System.Drawing.Size(407, 190);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "صلاحيات المستخدم";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// frm_addUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 222);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Tahoma", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_addUser";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اضافة مستخدم جديد";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtPhoneNo;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.TextBox txtPasswd;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAddUser;
	}
}