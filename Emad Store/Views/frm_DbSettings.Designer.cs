namespace Emad_Store.Views
{
	partial class frm_DbSettings
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDBpassword = new System.Windows.Forms.TextBox();
			this.radioBtnSQL = new System.Windows.Forms.RadioButton();
			this.radioBtnWin = new System.Windows.Forms.RadioButton();
			this.txtDBUsername = new System.Windows.Forms.TextBox();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDBpassword);
			this.groupBox1.Controls.Add(this.radioBtnSQL);
			this.groupBox1.Controls.Add(this.radioBtnWin);
			this.groupBox1.Controls.Add(this.txtDBUsername);
			this.groupBox1.Controls.Add(this.txtDBName);
			this.groupBox1.Controls.Add(this.txtServerName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 217);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات الاتصال بالسيرفر";
			// 
			// txtDBpassword
			// 
			this.txtDBpassword.Location = new System.Drawing.Point(6, 177);
			this.txtDBpassword.Name = "txtDBpassword";
			this.txtDBpassword.ReadOnly = true;
			this.txtDBpassword.Size = new System.Drawing.Size(196, 23);
			this.txtDBpassword.TabIndex = 11;
			this.txtDBpassword.UseSystemPasswordChar = true;
			// 
			// radioBtnSQL
			// 
			this.radioBtnSQL.AutoSize = true;
			this.radioBtnSQL.Location = new System.Drawing.Point(6, 119);
			this.radioBtnSQL.Name = "radioBtnSQL";
			this.radioBtnSQL.Size = new System.Drawing.Size(176, 20);
			this.radioBtnSQL.TabIndex = 10;
			this.radioBtnSQL.Text = "SQL Server Authentication";
			this.radioBtnSQL.UseVisualStyleBackColor = true;
			this.radioBtnSQL.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioBtnWin
			// 
			this.radioBtnWin.AutoSize = true;
			this.radioBtnWin.Checked = true;
			this.radioBtnWin.Location = new System.Drawing.Point(19, 93);
			this.radioBtnWin.Name = "radioBtnWin";
			this.radioBtnWin.Size = new System.Drawing.Size(163, 20);
			this.radioBtnWin.TabIndex = 9;
			this.radioBtnWin.TabStop = true;
			this.radioBtnWin.Text = "Windows Authentication";
			this.radioBtnWin.UseVisualStyleBackColor = true;
			this.radioBtnWin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// txtDBUsername
			// 
			this.txtDBUsername.Location = new System.Drawing.Point(6, 148);
			this.txtDBUsername.Name = "txtDBUsername";
			this.txtDBUsername.ReadOnly = true;
			this.txtDBUsername.Size = new System.Drawing.Size(196, 23);
			this.txtDBUsername.TabIndex = 7;
			// 
			// txtDBName
			// 
			this.txtDBName.Location = new System.Drawing.Point(6, 51);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(196, 23);
			this.txtDBName.TabIndex = 6;
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(6, 22);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(196, 23);
			this.txtServerName.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(209, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "كلمة المرور :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(209, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "اسم المستخدم :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(209, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "طريقة الدخول الي السيرفر :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(209, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "اسم قاعدة البيانات :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(209, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "اسم السيرفر :";
			// 
			// btnSave
			// 
			this.btnSave.Image = global::Emad_Store.Properties.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(172, 235);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(121, 32);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "حفظ الاعدادات";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnClose
			// 
			this.btnClose.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.btnClose.Location = new System.Drawing.Point(299, 235);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(89, 32);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "الغاء";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frm_DbSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 279);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_DbSettings";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "اعدادات الاتصال بالسيرفر";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDBpassword;
		private System.Windows.Forms.RadioButton radioBtnSQL;
		private System.Windows.Forms.RadioButton radioBtnWin;
		private System.Windows.Forms.TextBox txtDBUsername;
		private System.Windows.Forms.TextBox txtDBName;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
	}
}