namespace Emad_Store.Views
{
	partial class frm_main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.دخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.backUpDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreDbBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dbSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsMngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.اقسامالاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mngCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.اضافةمستخدمجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ادارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.المخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fillStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rptProductsAboutToFinishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.outOfStockProductsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.معدلاتالسحبلكلقسمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtTimeDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumOfProductsInStock = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtProductsAboutToFinish = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.المخزنToolStripMenuItem,
            this.التقاريرToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(830, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دخولToolStripMenuItem,
            this.تسجيلالخروجToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backUpDbToolStripMenuItem,
            this.restoreDbBackupToolStripMenuItem,
            this.dbSettingsToolStripMenuItem});
			this.fileToolStripMenuItem.Image = global::Emad_Store.Properties.Resources.Display_16x16;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.fileToolStripMenuItem.Text = "ملف";
			// 
			// دخولToolStripMenuItem
			// 
			this.دخولToolStripMenuItem.Image = global::Emad_Store.Properties.Resources.Unlock;
			this.دخولToolStripMenuItem.Name = "دخولToolStripMenuItem";
			this.دخولToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.دخولToolStripMenuItem.Text = "دخول";
			this.دخولToolStripMenuItem.Click += new System.EventHandler(this.دخولToolStripMenuItem_Click);
			// 
			// تسجيلالخروجToolStripMenuItem
			// 
			this.تسجيلالخروجToolStripMenuItem.Enabled = false;
			this.تسجيلالخروجToolStripMenuItem.Image = global::Emad_Store.Properties.Resources.Lock;
			this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
			this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
			// 
			// backUpDbToolStripMenuItem
			// 
			this.backUpDbToolStripMenuItem.Name = "backUpDbToolStripMenuItem";
			this.backUpDbToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.backUpDbToolStripMenuItem.Text = "نسخة احتياطية لقاعدة البيانات";
			this.backUpDbToolStripMenuItem.Click += new System.EventHandler(this.backUpDbToolStripMenuItem_Click);
			// 
			// restoreDbBackupToolStripMenuItem
			// 
			this.restoreDbBackupToolStripMenuItem.Enabled = false;
			this.restoreDbBackupToolStripMenuItem.Name = "restoreDbBackupToolStripMenuItem";
			this.restoreDbBackupToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.restoreDbBackupToolStripMenuItem.Text = "استعادة نسخة احتياطية لقاعدة البيانات";
			// 
			// dbSettingsToolStripMenuItem
			// 
			this.dbSettingsToolStripMenuItem.Name = "dbSettingsToolStripMenuItem";
			this.dbSettingsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
			this.dbSettingsToolStripMenuItem.Text = "اعدادات قاعدة البيانات";
			this.dbSettingsToolStripMenuItem.Click += new System.EventHandler(this.dbSettingsToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.productsMngToolStripMenuItem,
            this.toolStripMenuItem2,
            this.اقسامالاصنافToolStripMenuItem,
            this.mngCategoriesToolStripMenuItem});
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.productsToolStripMenuItem.Text = "المنتجات";
			// 
			// addNewProductToolStripMenuItem
			// 
			this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
			this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.addNewProductToolStripMenuItem.Text = "اضافة متنج جديد";
			this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
			// 
			// productsMngToolStripMenuItem
			// 
			this.productsMngToolStripMenuItem.Name = "productsMngToolStripMenuItem";
			this.productsMngToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.productsMngToolStripMenuItem.Text = "ادارة المنتجات";
			this.productsMngToolStripMenuItem.Click += new System.EventHandler(this.productsMngToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
			// 
			// اقسامالاصنافToolStripMenuItem
			// 
			this.اقسامالاصنافToolStripMenuItem.Enabled = false;
			this.اقسامالاصنافToolStripMenuItem.Name = "اقسامالاصنافToolStripMenuItem";
			this.اقسامالاصنافToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.اقسامالاصنافToolStripMenuItem.Text = "اصناف المنتجات";
			// 
			// mngCategoriesToolStripMenuItem
			// 
			this.mngCategoriesToolStripMenuItem.Name = "mngCategoriesToolStripMenuItem";
			this.mngCategoriesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.mngCategoriesToolStripMenuItem.Text = "ادارة اصناف المنتجات";
			this.mngCategoriesToolStripMenuItem.Click += new System.EventHandler(this.mngCategoriesToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةمستخدمجديدToolStripMenuItem,
            this.ادارةالمستخدمينToolStripMenuItem});
			this.usersToolStripMenuItem.Enabled = false;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.usersToolStripMenuItem.Text = "المستخدمين";
			// 
			// اضافةمستخدمجديدToolStripMenuItem
			// 
			this.اضافةمستخدمجديدToolStripMenuItem.Name = "اضافةمستخدمجديدToolStripMenuItem";
			this.اضافةمستخدمجديدToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.اضافةمستخدمجديدToolStripMenuItem.Text = "اضافة مستخدم جديد";
			// 
			// ادارةالمستخدمينToolStripMenuItem
			// 
			this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
			this.ادارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.ادارةالمستخدمينToolStripMenuItem.Text = "ادارة المستخدمين";
			// 
			// المخزنToolStripMenuItem
			// 
			this.المخزنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockOutToolStripMenuItem,
            this.fillStockToolStripMenuItem});
			this.المخزنToolStripMenuItem.Name = "المخزنToolStripMenuItem";
			this.المخزنToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.المخزنToolStripMenuItem.Text = "المخزن";
			// 
			// stockOutToolStripMenuItem
			// 
			this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
			this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.stockOutToolStripMenuItem.Text = "صرف";
			this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
			// 
			// fillStockToolStripMenuItem
			// 
			this.fillStockToolStripMenuItem.Name = "fillStockToolStripMenuItem";
			this.fillStockToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.fillStockToolStripMenuItem.Text = "ايداع";
			this.fillStockToolStripMenuItem.Click += new System.EventHandler(this.fillStockToolStripMenuItem_Click);
			// 
			// التقاريرToolStripMenuItem
			// 
			this.التقاريرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptProductsAboutToFinishToolStripMenuItem,
            this.outOfStockProductsReportToolStripMenuItem,
            this.معدلاتالسحبلكلقسمToolStripMenuItem});
			this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
			this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.التقاريرToolStripMenuItem.Text = "التقارير";
			// 
			// rptProductsAboutToFinishToolStripMenuItem
			// 
			this.rptProductsAboutToFinishToolStripMenuItem.Name = "rptProductsAboutToFinishToolStripMenuItem";
			this.rptProductsAboutToFinishToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
			this.rptProductsAboutToFinishToolStripMenuItem.Text = "منتجات قاربت علي الانتهاء";
			this.rptProductsAboutToFinishToolStripMenuItem.Click += new System.EventHandler(this.rptProductsAboutToFinishToolStripMenuItem_Click);
			// 
			// outOfStockProductsReportToolStripMenuItem
			// 
			this.outOfStockProductsReportToolStripMenuItem.Name = "outOfStockProductsReportToolStripMenuItem";
			this.outOfStockProductsReportToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
			this.outOfStockProductsReportToolStripMenuItem.Text = "الادوية و المنتجات المنتهية من المخزن";
			// 
			// معدلاتالسحبلكلقسمToolStripMenuItem
			// 
			this.معدلاتالسحبلكلقسمToolStripMenuItem.Name = "معدلاتالسحبلكلقسمToolStripMenuItem";
			this.معدلاتالسحبلكلقسمToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
			this.معدلاتالسحبلكلقسمToolStripMenuItem.Text = "معدلات السحب لكل قسم";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(631, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = " اسم المستخدم :";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(608, 68);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = true;
			this.txtUsername.Size = new System.Drawing.Size(100, 20);
			this.txtUsername.TabIndex = 6;
			this.txtUsername.Text = "...";
			// 
			// txtTimeDate
			// 
			this.txtTimeDate.Location = new System.Drawing.Point(479, 68);
			this.txtTimeDate.Name = "txtTimeDate";
			this.txtTimeDate.ReadOnly = true;
			this.txtTimeDate.Size = new System.Drawing.Size(100, 20);
			this.txtTimeDate.TabIndex = 8;
			this.txtTimeDate.Text = "3 فبراير 2018";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(493, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "الساعة الان :";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(331, 68);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "12 فاتورة";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(342, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "عدد فواتير الايداع :";
			// 
			// txtNumOfProductsInStock
			// 
			this.txtNumOfProductsInStock.Location = new System.Drawing.Point(187, 68);
			this.txtNumOfProductsInStock.Name = "txtNumOfProductsInStock";
			this.txtNumOfProductsInStock.ReadOnly = true;
			this.txtNumOfProductsInStock.Size = new System.Drawing.Size(100, 20);
			this.txtNumOfProductsInStock.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(183, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "عدد المنتجات في المخزن";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(48, 68);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 14;
			this.textBox5.Text = "1000 فاتورة";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "عدد الفواتير المسجلة :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.txtNumOfProductsInStock);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTimeDate);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(0, 244);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(830, 104);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "شوية معلومات ع السريع";
			this.groupBox1.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtProductsAboutToFinish);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.textBox9);
			this.groupBox2.Controls.Add(this.textBox10);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(0, 344);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(830, 97);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "معلومات المنتجات :";
			this.groupBox2.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(558, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "منتجات قاربت علي الانتهاء :";
			// 
			// txtProductsAboutToFinish
			// 
			this.txtProductsAboutToFinish.Location = new System.Drawing.Point(568, 62);
			this.txtProductsAboutToFinish.Name = "txtProductsAboutToFinish";
			this.txtProductsAboutToFinish.ReadOnly = true;
			this.txtProductsAboutToFinish.Size = new System.Drawing.Size(100, 20);
			this.txtProductsAboutToFinish.TabIndex = 6;
			this.txtProductsAboutToFinish.Text = "...";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(124, 62);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 12;
			this.textBox8.Text = "6";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(378, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "عدد المنتجات التي تم صرفها اليوم :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(110, 35);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "عدد المنتجات في المخزن";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(406, 62);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(132, 20);
			this.textBox9.TabIndex = 8;
			this.textBox9.Text = "50 وحدة من 20 منتج";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(258, 62);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 10;
			this.textBox10.Text = "23";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(254, 35);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "عدد الفواتير المسجلة :";
			// 
			// frm_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 441);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_main";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ادارة مخازن مستشفي كفرالشيخ الجامعي - برمجة طلاب كلية الحاسبات بكفر الشيخ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem دخولToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem backUpDbToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem restoreDbBackupToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem productsMngToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem اقسامالاصنافToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem mngCategoriesToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem اضافةمستخدمجديدToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem ادارةالمستخدمينToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ToolStripMenuItem المخزنToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fillStockToolStripMenuItem;
		public System.Windows.Forms.TextBox txtUsername;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dbSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem outOfStockProductsReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rptProductsAboutToFinishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem معدلاتالسحبلكلقسمToolStripMenuItem;
		public System.Windows.Forms.TextBox txtTimeDate;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.TextBox txtNumOfProductsInStock;
		public System.Windows.Forms.TextBox textBox5;
		public System.Windows.Forms.TextBox txtProductsAboutToFinish;
		public System.Windows.Forms.TextBox textBox8;
		public System.Windows.Forms.TextBox textBox9;
		public System.Windows.Forms.TextBox textBox10;
	}
}