namespace Emad_Store.Views
{
	partial class frm_outProducts
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_outProducts));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbDeparments = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtReceiverName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTimeDate = new System.Windows.Forms.TextBox();
			this.txtBillNotes = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtNewBillNum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddProductToBillLst = new System.Windows.Forms.Button();
			this.numUpDwnQntty = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSumQntts = new System.Windows.Forms.TextBox();
			this.bntDeleteSlctProd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCrntRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtProdName = new System.Windows.Forms.TextBox();
			this.btnSelectProduct = new System.Windows.Forms.Button();
			this.bntNewBill = new System.Windows.Forms.Button();
			this.bntSaveBill = new System.Windows.Forms.Button();
			this.bntExit = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblState = new System.Windows.Forms.Label();
			this.gbExportBill = new System.Windows.Forms.GroupBox();
			this.bntSaveBillAsExl = new System.Windows.Forms.Button();
			this.bntPrintBill = new System.Windows.Forms.Button();
			this.bntSaveBillAsPDF = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDwnQntty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbExportBill.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbDeparments);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtReceiverName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTimeDate);
			this.groupBox1.Controls.Add(this.txtBillNotes);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.txtNewBillNum);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 132);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات الفاتورة";
			// 
			// cmbDeparments
			// 
			this.cmbDeparments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDeparments.FormattingEnabled = true;
			this.cmbDeparments.Location = new System.Drawing.Point(23, 98);
			this.cmbDeparments.Name = "cmbDeparments";
			this.cmbDeparments.Size = new System.Drawing.Size(189, 24);
			this.cmbDeparments.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(221, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 16);
			this.label10.TabIndex = 8;
			this.label10.Text = "القسم المستلم :";
			// 
			// txtReceiverName
			// 
			this.txtReceiverName.Location = new System.Drawing.Point(23, 71);
			this.txtReceiverName.Name = "txtReceiverName";
			this.txtReceiverName.Size = new System.Drawing.Size(189, 23);
			this.txtReceiverName.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(221, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "اسم مستلم الادوية  :";
			// 
			// txtTimeDate
			// 
			this.txtTimeDate.Enabled = false;
			this.txtTimeDate.Location = new System.Drawing.Point(23, 45);
			this.txtTimeDate.Name = "txtTimeDate";
			this.txtTimeDate.ReadOnly = true;
			this.txtTimeDate.Size = new System.Drawing.Size(189, 23);
			this.txtTimeDate.TabIndex = 5;
			// 
			// txtBillNotes
			// 
			this.txtBillNotes.Location = new System.Drawing.Point(423, 45);
			this.txtBillNotes.Multiline = true;
			this.txtBillNotes.Name = "txtBillNotes";
			this.txtBillNotes.Size = new System.Drawing.Size(238, 72);
			this.txtBillNotes.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "الوقت الحالي ( تاريخ تسجيل الفاتورة ) :";
			// 
			// txtUsername
			// 
			this.txtUsername.Enabled = false;
			this.txtUsername.Location = new System.Drawing.Point(23, 19);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = true;
			this.txtUsername.Size = new System.Drawing.Size(189, 23);
			this.txtUsername.TabIndex = 4;
			// 
			// txtNewBillNum
			// 
			this.txtNewBillNum.Enabled = false;
			this.txtNewBillNum.Location = new System.Drawing.Point(533, 19);
			this.txtNewBillNum.Name = "txtNewBillNum";
			this.txtNewBillNum.ReadOnly = true;
			this.txtNewBillNum.Size = new System.Drawing.Size(129, 23);
			this.txtNewBillNum.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(679, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "وصف الفاتورة :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(221, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "اسم امين المخزن :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(679, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "رقم الفاتورة :";
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(613, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "اختيار المنتج :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(158, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(449, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "اسم المنتج :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(23, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "الكمية :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddProductToBillLst);
			this.groupBox2.Controls.Add(this.numUpDwnQntty);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtSumQntts);
			this.groupBox2.Controls.Add(this.bntDeleteSlctProd);
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Controls.Add(this.txtProdName);
			this.groupBox2.Controls.Add(this.btnSelectProduct);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.groupBox2.Location = new System.Drawing.Point(12, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(768, 252);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "تفاصيل الفاتورة :";
			// 
			// btnAddProductToBillLst
			// 
			this.btnAddProductToBillLst.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAddProductToBillLst.Location = new System.Drawing.Point(23, 57);
			this.btnAddProductToBillLst.Name = "btnAddProductToBillLst";
			this.btnAddProductToBillLst.Size = new System.Drawing.Size(68, 23);
			this.btnAddProductToBillLst.TabIndex = 11;
			this.btnAddProductToBillLst.Text = "اضافة";
			this.btnAddProductToBillLst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddProductToBillLst.UseVisualStyleBackColor = true;
			this.btnAddProductToBillLst.Click += new System.EventHandler(this.btnAddProductToBillLst_Click);
			// 
			// numUpDwnQntty
			// 
			this.numUpDwnQntty.Location = new System.Drawing.Point(97, 57);
			this.numUpDwnQntty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDwnQntty.Name = "numUpDwnQntty";
			this.numUpDwnQntty.Size = new System.Drawing.Size(55, 23);
			this.numUpDwnQntty.TabIndex = 10;
			this.numUpDwnQntty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDwnQntty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numUpDwnQntty_KeyDown);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(158, 221);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(130, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "اجمالي عدد الوحدات :";
			// 
			// txtSumQntts
			// 
			this.txtSumQntts.Location = new System.Drawing.Point(23, 218);
			this.txtSumQntts.Name = "txtSumQntts";
			this.txtSumQntts.ReadOnly = true;
			this.txtSumQntts.Size = new System.Drawing.Size(129, 23);
			this.txtSumQntts.TabIndex = 9;
			// 
			// bntDeleteSlctProd
			// 
			this.bntDeleteSlctProd.Image = global::Emad_Store.Properties.Resources.Delete;
			this.bntDeleteSlctProd.Location = new System.Drawing.Point(582, 218);
			this.bntDeleteSlctProd.Name = "bntDeleteSlctProd";
			this.bntDeleteSlctProd.Size = new System.Drawing.Size(155, 28);
			this.bntDeleteSlctProd.TabIndex = 8;
			this.bntDeleteSlctProd.Text = "حذف المنتج المحدد";
			this.bntDeleteSlctProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntDeleteSlctProd.UseVisualStyleBackColor = true;
			this.bntDeleteSlctProd.Click += new System.EventHandler(this.bntDeleteSlctProd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(23, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(714, 127);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRowToolStripMenuItem,
            this.deleteCrntRowToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip1.Size = new System.Drawing.Size(124, 70);
			// 
			// editRowToolStripMenuItem
			// 
			this.editRowToolStripMenuItem.Name = "editRowToolStripMenuItem";
			this.editRowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.editRowToolStripMenuItem.Text = "تعديل";
			this.editRowToolStripMenuItem.Click += new System.EventHandler(this.editRowToolStripMenuItem_Click);
			// 
			// deleteCrntRowToolStripMenuItem
			// 
			this.deleteCrntRowToolStripMenuItem.Name = "deleteCrntRowToolStripMenuItem";
			this.deleteCrntRowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.deleteCrntRowToolStripMenuItem.Text = "حذف";
			this.deleteCrntRowToolStripMenuItem.Click += new System.EventHandler(this.deleteCrntRowToolStripMenuItem_Click);
			// 
			// deleteAllToolStripMenuItem
			// 
			this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
			this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.deleteAllToolStripMenuItem.Text = "حذف الكل";
			this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
			// 
			// txtProdName
			// 
			this.txtProdName.Enabled = false;
			this.txtProdName.Location = new System.Drawing.Point(158, 56);
			this.txtProdName.Name = "txtProdName";
			this.txtProdName.ReadOnly = true;
			this.txtProdName.Size = new System.Drawing.Size(449, 23);
			this.txtProdName.TabIndex = 5;
			// 
			// btnSelectProduct
			// 
			this.btnSelectProduct.Location = new System.Drawing.Point(613, 56);
			this.btnSelectProduct.Name = "btnSelectProduct";
			this.btnSelectProduct.Size = new System.Drawing.Size(124, 23);
			this.btnSelectProduct.TabIndex = 4;
			this.btnSelectProduct.Text = "...";
			this.btnSelectProduct.UseVisualStyleBackColor = true;
			this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
			// 
			// bntNewBill
			// 
			this.bntNewBill.Image = global::Emad_Store.Properties.Resources.Create;
			this.bntNewBill.Location = new System.Drawing.Point(236, 22);
			this.bntNewBill.Name = "bntNewBill";
			this.bntNewBill.Size = new System.Drawing.Size(109, 28);
			this.bntNewBill.TabIndex = 5;
			this.bntNewBill.Text = "فاتورة جديدة";
			this.bntNewBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntNewBill.UseVisualStyleBackColor = true;
			this.bntNewBill.Click += new System.EventHandler(this.bntNewBill_Click);
			// 
			// bntSaveBill
			// 
			this.bntSaveBill.Image = global::Emad_Store.Properties.Resources.Save;
			this.bntSaveBill.Location = new System.Drawing.Point(121, 22);
			this.bntSaveBill.Name = "bntSaveBill";
			this.bntSaveBill.Size = new System.Drawing.Size(109, 28);
			this.bntSaveBill.TabIndex = 6;
			this.bntSaveBill.Text = "حفظ الفاتورة";
			this.bntSaveBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntSaveBill.UseVisualStyleBackColor = true;
			this.bntSaveBill.Click += new System.EventHandler(this.bntSaveBill_Click);
			// 
			// bntExit
			// 
			this.bntExit.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.bntExit.Location = new System.Drawing.Point(18, 22);
			this.bntExit.Name = "bntExit";
			this.bntExit.Size = new System.Drawing.Size(97, 28);
			this.bntExit.TabIndex = 7;
			this.bntExit.Text = "خروج";
			this.bntExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntExit.UseVisualStyleBackColor = true;
			this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.bntExit);
			this.groupBox3.Controls.Add(this.bntSaveBill);
			this.groupBox3.Controls.Add(this.bntNewBill);
			this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.groupBox3.Location = new System.Drawing.Point(12, 435);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(376, 61);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "العمليات";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(18, 503);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(16, 13);
			this.lblState.TabIndex = 9;
			this.lblState.Text = "...";
			// 
			// gbExportBill
			// 
			this.gbExportBill.Controls.Add(this.bntSaveBillAsExl);
			this.gbExportBill.Controls.Add(this.bntPrintBill);
			this.gbExportBill.Controls.Add(this.bntSaveBillAsPDF);
			this.gbExportBill.Enabled = false;
			this.gbExportBill.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.gbExportBill.Location = new System.Drawing.Point(404, 435);
			this.gbExportBill.Name = "gbExportBill";
			this.gbExportBill.Size = new System.Drawing.Size(376, 61);
			this.gbExportBill.TabIndex = 9;
			this.gbExportBill.TabStop = false;
			this.gbExportBill.Text = "تصدير و طباعة";
			// 
			// bntSaveBillAsExl
			// 
			this.bntSaveBillAsExl.Image = global::Emad_Store.Properties.Resources.if_excel_272697;
			this.bntSaveBillAsExl.Location = new System.Drawing.Point(133, 22);
			this.bntSaveBillAsExl.Name = "bntSaveBillAsExl";
			this.bntSaveBillAsExl.Size = new System.Drawing.Size(97, 28);
			this.bntSaveBillAsExl.TabIndex = 7;
			this.bntSaveBillAsExl.Text = "حفظ Excel";
			this.bntSaveBillAsExl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntSaveBillAsExl.UseVisualStyleBackColor = true;
			this.bntSaveBillAsExl.Click += new System.EventHandler(this.bntSaveBillAsExl_Click);
			// 
			// bntPrintBill
			// 
			this.bntPrintBill.Image = global::Emad_Store.Properties.Resources.Print;
			this.bntPrintBill.Location = new System.Drawing.Point(245, 22);
			this.bntPrintBill.Name = "bntPrintBill";
			this.bntPrintBill.Size = new System.Drawing.Size(109, 28);
			this.bntPrintBill.TabIndex = 6;
			this.bntPrintBill.Text = "طباعة";
			this.bntPrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntPrintBill.UseVisualStyleBackColor = true;
			this.bntPrintBill.Click += new System.EventHandler(this.bntPrintBill_Click);
			// 
			// bntSaveBillAsPDF
			// 
			this.bntSaveBillAsPDF.Image = global::Emad_Store.Properties.Resources.if_pdf_272711;
			this.bntSaveBillAsPDF.Location = new System.Drawing.Point(18, 22);
			this.bntSaveBillAsPDF.Name = "bntSaveBillAsPDF";
			this.bntSaveBillAsPDF.Size = new System.Drawing.Size(109, 28);
			this.bntSaveBillAsPDF.TabIndex = 5;
			this.bntSaveBillAsPDF.Text = "حفظ PDF";
			this.bntSaveBillAsPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntSaveBillAsPDF.UseVisualStyleBackColor = true;
			this.bntSaveBillAsPDF.Click += new System.EventHandler(this.bntSaveBillAsPDF_Click);
			// 
			// frm_outProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 525);
			this.Controls.Add(this.gbExportBill);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_outProducts";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "صرف ادوية و مستحضرات من المخزن";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDwnQntty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.gbExportBill.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtReceiverName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTimeDate;
		private System.Windows.Forms.TextBox txtBillNotes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtNewBillNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtProdName;
		private System.Windows.Forms.Button btnSelectProduct;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSumQntts;
		private System.Windows.Forms.Button bntDeleteSlctProd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bntNewBill;
		private System.Windows.Forms.Button bntSaveBill;
		private System.Windows.Forms.Button bntExit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.GroupBox gbExportBill;
		private System.Windows.Forms.Button bntSaveBillAsExl;
		private System.Windows.Forms.Button bntPrintBill;
		private System.Windows.Forms.Button bntSaveBillAsPDF;
		private System.Windows.Forms.ComboBox cmbDeparments;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numUpDwnQntty;
		private System.Windows.Forms.Button btnAddProductToBillLst;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteCrntRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
	}
}