namespace Emad_Store.Views
{
	partial class frm_mngProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mngProducts));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvProductsLst = new System.Windows.Forms.DataGridView();
			this.gbOperations = new System.Windows.Forms.GroupBox();
			this.bntExprtPDF = new System.Windows.Forms.Button();
			this.btnExprtExcel = new System.Windows.Forms.Button();
			this.btnPrintAllProducts = new System.Windows.Forms.Button();
			this.prtSlctdPrdct = new System.Windows.Forms.Button();
			this.btnUpdtList = new System.Windows.Forms.Button();
			this.deleteSlctPrdct = new System.Windows.Forms.Button();
			this.edtSlctdPrdct = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblState = new System.Windows.Forms.Label();
			this.productImg = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsLst)).BeginInit();
			this.gbOperations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(220, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ادخل كلمة للبحث :";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new System.Drawing.Point(317, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvProductsLst);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(943, 294);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "قائمة المنتجات";
			// 
			// dgvProductsLst
			// 
			this.dgvProductsLst.AllowUserToAddRows = false;
			this.dgvProductsLst.AllowUserToDeleteRows = false;
			this.dgvProductsLst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductsLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductsLst.Location = new System.Drawing.Point(6, 19);
			this.dgvProductsLst.MultiSelect = false;
			this.dgvProductsLst.Name = "dgvProductsLst";
			this.dgvProductsLst.ReadOnly = true;
			this.dgvProductsLst.RowHeadersVisible = false;
			this.dgvProductsLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductsLst.Size = new System.Drawing.Size(931, 257);
			this.dgvProductsLst.TabIndex = 0;
			this.dgvProductsLst.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// gbOperations
			// 
			this.gbOperations.Controls.Add(this.bntExprtPDF);
			this.gbOperations.Controls.Add(this.btnExprtExcel);
			this.gbOperations.Controls.Add(this.btnPrintAllProducts);
			this.gbOperations.Controls.Add(this.prtSlctdPrdct);
			this.gbOperations.Controls.Add(this.btnUpdtList);
			this.gbOperations.Controls.Add(this.deleteSlctPrdct);
			this.gbOperations.Controls.Add(this.edtSlctdPrdct);
			this.gbOperations.Controls.Add(this.button1);
			this.gbOperations.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.gbOperations.Location = new System.Drawing.Point(12, 442);
			this.gbOperations.Name = "gbOperations";
			this.gbOperations.Size = new System.Drawing.Size(943, 97);
			this.gbOperations.TabIndex = 3;
			this.gbOperations.TabStop = false;
			this.gbOperations.Text = "العمليات علي المنتجات";
			// 
			// bntExprtPDF
			// 
			this.bntExprtPDF.Image = global::Emad_Store.Properties.Resources.if_pdf_272711;
			this.bntExprtPDF.Location = new System.Drawing.Point(147, 58);
			this.bntExprtPDF.Name = "bntExprtPDF";
			this.bntExprtPDF.Size = new System.Drawing.Size(217, 30);
			this.bntExprtPDF.TabIndex = 11;
			this.bntExprtPDF.Text = "تصدير قائمة المنتاج الي ملف PDF";
			this.bntExprtPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntExprtPDF.UseVisualStyleBackColor = true;
			this.bntExprtPDF.Click += new System.EventHandler(this.bntExprtPDF_Click);
			// 
			// btnExprtExcel
			// 
			this.btnExprtExcel.Image = global::Emad_Store.Properties.Resources.if_excel_272697;
			this.btnExprtExcel.Location = new System.Drawing.Point(370, 58);
			this.btnExprtExcel.Name = "btnExprtExcel";
			this.btnExprtExcel.Size = new System.Drawing.Size(231, 30);
			this.btnExprtExcel.TabIndex = 10;
			this.btnExprtExcel.Text = "تصدير قائمة المنتاج الي ملف اكسيل";
			this.btnExprtExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExprtExcel.UseVisualStyleBackColor = true;
			this.btnExprtExcel.Click += new System.EventHandler(this.btnExprtExcel_Click);
			// 
			// btnPrintAllProducts
			// 
			this.btnPrintAllProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAllProducts.Image")));
			this.btnPrintAllProducts.Location = new System.Drawing.Point(607, 58);
			this.btnPrintAllProducts.Name = "btnPrintAllProducts";
			this.btnPrintAllProducts.Size = new System.Drawing.Size(186, 30);
			this.btnPrintAllProducts.TabIndex = 9;
			this.btnPrintAllProducts.Text = "طباعة تقرير بكل المنتجات";
			this.btnPrintAllProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintAllProducts.UseVisualStyleBackColor = true;
			this.btnPrintAllProducts.Click += new System.EventHandler(this.btnPrintAllProducts_Click);
			// 
			// prtSlctdPrdct
			// 
			this.prtSlctdPrdct.Image = ((System.Drawing.Image)(resources.GetObject("prtSlctdPrdct.Image")));
			this.prtSlctdPrdct.Location = new System.Drawing.Point(91, 22);
			this.prtSlctdPrdct.Name = "prtSlctdPrdct";
			this.prtSlctdPrdct.Size = new System.Drawing.Size(180, 30);
			this.prtSlctdPrdct.TabIndex = 8;
			this.prtSlctdPrdct.Text = "طباعة تقرير المنتج المحدد";
			this.prtSlctdPrdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.prtSlctdPrdct.UseVisualStyleBackColor = true;
			this.prtSlctdPrdct.Click += new System.EventHandler(this.prtSlctdPrdct_Click);
			// 
			// btnUpdtList
			// 
			this.btnUpdtList.Image = global::Emad_Store.Properties.Resources.Refresh;
			this.btnUpdtList.Location = new System.Drawing.Point(728, 22);
			this.btnUpdtList.Name = "btnUpdtList";
			this.btnUpdtList.Size = new System.Drawing.Size(126, 30);
			this.btnUpdtList.TabIndex = 7;
			this.btnUpdtList.Text = "تحديث القائمة";
			this.btnUpdtList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdtList.UseVisualStyleBackColor = true;
			this.btnUpdtList.Click += new System.EventHandler(this.btnUpdtList_Click);
			// 
			// deleteSlctPrdct
			// 
			this.deleteSlctPrdct.Image = global::Emad_Store.Properties.Resources.Delete;
			this.deleteSlctPrdct.Location = new System.Drawing.Point(428, 22);
			this.deleteSlctPrdct.Name = "deleteSlctPrdct";
			this.deleteSlctPrdct.Size = new System.Drawing.Size(147, 30);
			this.deleteSlctPrdct.TabIndex = 3;
			this.deleteSlctPrdct.Text = "حذف المنتج الحدد";
			this.deleteSlctPrdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.deleteSlctPrdct.UseVisualStyleBackColor = true;
			this.deleteSlctPrdct.Click += new System.EventHandler(this.deleteSlctPrdct_Click);
			// 
			// edtSlctdPrdct
			// 
			this.edtSlctdPrdct.Image = global::Emad_Store.Properties.Resources.Modify;
			this.edtSlctdPrdct.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.edtSlctdPrdct.Location = new System.Drawing.Point(277, 22);
			this.edtSlctdPrdct.Name = "edtSlctdPrdct";
			this.edtSlctdPrdct.Size = new System.Drawing.Size(145, 30);
			this.edtSlctdPrdct.TabIndex = 2;
			this.edtSlctdPrdct.Text = "تعديل بيانات المنتج";
			this.edtSlctdPrdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.edtSlctdPrdct.UseVisualStyleBackColor = true;
			this.edtSlctdPrdct.Click += new System.EventHandler(this.edtSlctdPrdct_Click);
			// 
			// button1
			// 
			this.button1.Image = global::Emad_Store.Properties.Resources.Create;
			this.button1.Location = new System.Drawing.Point(581, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "اضافة منتج جديد";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblState.Location = new System.Drawing.Point(15, 545);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(20, 16);
			this.lblState.TabIndex = 5;
			this.lblState.Text = "...";
			// 
			// productImg
			// 
			this.productImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("productImg.InitialImage")));
			this.productImg.Location = new System.Drawing.Point(817, 13);
			this.productImg.Name = "productImg";
			this.productImg.Size = new System.Drawing.Size(135, 112);
			this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productImg.TabIndex = 6;
			this.productImg.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(230, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "اختيار تصنيف :";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(317, 70);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(292, 24);
			this.comboBox1.TabIndex = 8;
			// 
			// frm_mngProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 572);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productImg);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.gbOperations);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_mngProducts";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ادارة المنتجات المخزنة";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsLst)).EndInit();
			this.gbOperations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button edtSlctdPrdct;
		private System.Windows.Forms.Button deleteSlctPrdct;
		private System.Windows.Forms.PictureBox productImg;
		private System.Windows.Forms.Button btnUpdtList;
		private System.Windows.Forms.Button prtSlctdPrdct;
		private System.Windows.Forms.Button btnPrintAllProducts;
		private System.Windows.Forms.Button btnExprtExcel;
		private System.Windows.Forms.Button bntExprtPDF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.GroupBox gbOperations;
		public System.Windows.Forms.DataGridView dgvProductsLst;
		public System.Windows.Forms.Label lblState;
	}
}