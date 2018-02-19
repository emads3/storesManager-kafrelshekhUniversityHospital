namespace Emad_Store.Views
{
	partial class frm_mngCategories
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mngCategories));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCatName = new System.Windows.Forms.TextBox();
			this.txtCatNotes = new System.Windows.Forms.TextBox();
			this.btnNxtCat = new System.Windows.Forms.Button();
			this.btnPrevCat = new System.Windows.Forms.Button();
			this.lblPosition = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLstCat = new System.Windows.Forms.Button();
			this.btnFrstCat = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddNewCat = new System.Windows.Forms.Button();
			this.saveCatsProdsToExl = new System.Windows.Forms.Button();
			this.saveCatsProdsToPdf = new System.Windows.Forms.Button();
			this.exprtAllCatsToExl = new System.Windows.Forms.Button();
			this.exprtAllCats2pdf = new System.Windows.Forms.Button();
			this.prtAllCats = new System.Windows.Forms.Button();
			this.prtSlctCat = new System.Windows.Forms.Button();
			this.btnUpdateSelected = new System.Windows.Forms.Button();
			this.btnDelSlctd = new System.Windows.Forms.Button();
			this.btnRefreshLst = new System.Windows.Forms.Button();
			this.lblState = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(690, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "اسم التصنيف :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(691, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "ملحوظات :";
			// 
			// txtCatName
			// 
			this.txtCatName.Location = new System.Drawing.Point(302, 25);
			this.txtCatName.Name = "txtCatName";
			this.txtCatName.Size = new System.Drawing.Size(385, 23);
			this.txtCatName.TabIndex = 2;
			this.txtCatName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatName_KeyDown);
			// 
			// txtCatNotes
			// 
			this.txtCatNotes.Location = new System.Drawing.Point(302, 51);
			this.txtCatNotes.Multiline = true;
			this.txtCatNotes.Name = "txtCatNotes";
			this.txtCatNotes.Size = new System.Drawing.Size(385, 89);
			this.txtCatNotes.TabIndex = 3;
			// 
			// btnNxtCat
			// 
			this.btnNxtCat.Image = global::Emad_Store.Properties.Resources.Go_back;
			this.btnNxtCat.Location = new System.Drawing.Point(403, 146);
			this.btnNxtCat.Name = "btnNxtCat";
			this.btnNxtCat.Size = new System.Drawing.Size(60, 30);
			this.btnNxtCat.TabIndex = 4;
			this.btnNxtCat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnNxtCat.UseVisualStyleBackColor = true;
			this.btnNxtCat.Click += new System.EventHandler(this.btnNxtCat_Click);
			// 
			// btnPrevCat
			// 
			this.btnPrevCat.Image = global::Emad_Store.Properties.Resources.Go_forward;
			this.btnPrevCat.Location = new System.Drawing.Point(528, 146);
			this.btnPrevCat.Name = "btnPrevCat";
			this.btnPrevCat.Size = new System.Drawing.Size(60, 30);
			this.btnPrevCat.TabIndex = 5;
			this.btnPrevCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrevCat.UseVisualStyleBackColor = true;
			this.btnPrevCat.Click += new System.EventHandler(this.btnPrevCat_Click);
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(486, 151);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(20, 16);
			this.lblPosition.TabIndex = 6;
			this.lblPosition.Text = "...";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnLstCat);
			this.groupBox1.Controls.Add(this.btnFrstCat);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.txtCatName);
			this.groupBox1.Controls.Add(this.lblPosition);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnPrevCat);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnNxtCat);
			this.groupBox1.Controls.Add(this.txtCatNotes);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 192);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "التصنيفات";
			// 
			// btnLstCat
			// 
			this.btnLstCat.Image = global::Emad_Store.Properties.Resources.First;
			this.btnLstCat.Location = new System.Drawing.Point(337, 146);
			this.btnLstCat.Name = "btnLstCat";
			this.btnLstCat.Size = new System.Drawing.Size(60, 30);
			this.btnLstCat.TabIndex = 9;
			this.btnLstCat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnLstCat.UseVisualStyleBackColor = true;
			this.btnLstCat.Click += new System.EventHandler(this.btnLstCat_Click);
			// 
			// btnFrstCat
			// 
			this.btnFrstCat.Image = global::Emad_Store.Properties.Resources.Last;
			this.btnFrstCat.Location = new System.Drawing.Point(594, 146);
			this.btnFrstCat.Name = "btnFrstCat";
			this.btnFrstCat.Size = new System.Drawing.Size(60, 30);
			this.btnFrstCat.TabIndex = 8;
			this.btnFrstCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFrstCat.UseVisualStyleBackColor = true;
			this.btnFrstCat.Click += new System.EventHandler(this.btnFrstCat_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(283, 150);
			this.dataGridView1.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddNewCat);
			this.groupBox2.Controls.Add(this.saveCatsProdsToExl);
			this.groupBox2.Controls.Add(this.saveCatsProdsToPdf);
			this.groupBox2.Controls.Add(this.exprtAllCatsToExl);
			this.groupBox2.Controls.Add(this.exprtAllCats2pdf);
			this.groupBox2.Controls.Add(this.prtAllCats);
			this.groupBox2.Controls.Add(this.prtSlctCat);
			this.groupBox2.Controls.Add(this.btnUpdateSelected);
			this.groupBox2.Controls.Add(this.btnDelSlctd);
			this.groupBox2.Controls.Add(this.btnRefreshLst);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 210);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(774, 132);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "العمليات علي الاصناف";
			// 
			// btnAddNewCat
			// 
			this.btnAddNewCat.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAddNewCat.Location = new System.Drawing.Point(396, 19);
			this.btnAddNewCat.Name = "btnAddNewCat";
			this.btnAddNewCat.Size = new System.Drawing.Size(148, 30);
			this.btnAddNewCat.TabIndex = 10;
			this.btnAddNewCat.Text = "اضافة تصنيف جديد";
			this.btnAddNewCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNewCat.UseVisualStyleBackColor = true;
			this.btnAddNewCat.Click += new System.EventHandler(this.btnAddNewCat_Click);
			// 
			// saveCatsProdsToExl
			// 
			this.saveCatsProdsToExl.Image = ((System.Drawing.Image)(resources.GetObject("saveCatsProdsToExl.Image")));
			this.saveCatsProdsToExl.Location = new System.Drawing.Point(396, 91);
			this.saveCatsProdsToExl.Name = "saveCatsProdsToExl";
			this.saveCatsProdsToExl.Size = new System.Drawing.Size(281, 30);
			this.saveCatsProdsToExl.TabIndex = 8;
			this.saveCatsProdsToExl.Text = "حفظ منتجات الصنف الحالي في ملف اكسيل";
			this.saveCatsProdsToExl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveCatsProdsToExl.UseVisualStyleBackColor = true;
			// 
			// saveCatsProdsToPdf
			// 
			this.saveCatsProdsToPdf.Image = ((System.Drawing.Image)(resources.GetObject("saveCatsProdsToPdf.Image")));
			this.saveCatsProdsToPdf.Location = new System.Drawing.Point(126, 91);
			this.saveCatsProdsToPdf.Name = "saveCatsProdsToPdf";
			this.saveCatsProdsToPdf.Size = new System.Drawing.Size(264, 30);
			this.saveCatsProdsToPdf.TabIndex = 7;
			this.saveCatsProdsToPdf.Text = "حفظ منتجات الصنف الحالي في ملف PDF";
			this.saveCatsProdsToPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveCatsProdsToPdf.UseVisualStyleBackColor = true;
			this.saveCatsProdsToPdf.Click += new System.EventHandler(this.saveCatsProdsToPdf_Click);
			// 
			// exprtAllCatsToExl
			// 
			this.exprtAllCatsToExl.Image = ((System.Drawing.Image)(resources.GetObject("exprtAllCatsToExl.Image")));
			this.exprtAllCatsToExl.Location = new System.Drawing.Point(9, 55);
			this.exprtAllCatsToExl.Name = "exprtAllCatsToExl";
			this.exprtAllCatsToExl.Size = new System.Drawing.Size(231, 30);
			this.exprtAllCatsToExl.TabIndex = 6;
			this.exprtAllCatsToExl.Text = "حفظ لائحة الاصناف في ملف اكسيل";
			this.exprtAllCatsToExl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.exprtAllCatsToExl.UseVisualStyleBackColor = true;
			// 
			// exprtAllCats2pdf
			// 
			this.exprtAllCats2pdf.Image = ((System.Drawing.Image)(resources.GetObject("exprtAllCats2pdf.Image")));
			this.exprtAllCats2pdf.Location = new System.Drawing.Point(244, 55);
			this.exprtAllCats2pdf.Name = "exprtAllCats2pdf";
			this.exprtAllCats2pdf.Size = new System.Drawing.Size(212, 30);
			this.exprtAllCats2pdf.TabIndex = 5;
			this.exprtAllCats2pdf.Text = "حفظ لائحة الاصناف في ملف PDF";
			this.exprtAllCats2pdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.exprtAllCats2pdf.UseVisualStyleBackColor = true;
			// 
			// prtAllCats
			// 
			this.prtAllCats.Image = global::Emad_Store.Properties.Resources.Print;
			this.prtAllCats.Location = new System.Drawing.Point(461, 55);
			this.prtAllCats.Name = "prtAllCats";
			this.prtAllCats.Size = new System.Drawing.Size(133, 30);
			this.prtAllCats.TabIndex = 4;
			this.prtAllCats.Text = "طباعة كل الاصناف";
			this.prtAllCats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.prtAllCats.UseVisualStyleBackColor = true;
			this.prtAllCats.Click += new System.EventHandler(this.prtAllCats_Click);
			// 
			// prtSlctCat
			// 
			this.prtSlctCat.Image = global::Emad_Store.Properties.Resources.Print;
			this.prtSlctCat.Location = new System.Drawing.Point(600, 55);
			this.prtSlctCat.Name = "prtSlctCat";
			this.prtSlctCat.Size = new System.Drawing.Size(168, 30);
			this.prtSlctCat.TabIndex = 3;
			this.prtSlctCat.Text = "طباعة الصنف المحدد";
			this.prtSlctCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.prtSlctCat.UseVisualStyleBackColor = true;
			this.prtSlctCat.Click += new System.EventHandler(this.prtSlctCat_Click);
			// 
			// btnUpdateSelected
			// 
			this.btnUpdateSelected.Image = global::Emad_Store.Properties.Resources.Modify;
			this.btnUpdateSelected.Location = new System.Drawing.Point(67, 19);
			this.btnUpdateSelected.Name = "btnUpdateSelected";
			this.btnUpdateSelected.Size = new System.Drawing.Size(162, 30);
			this.btnUpdateSelected.TabIndex = 2;
			this.btnUpdateSelected.Text = "تعديل الصنف المحدد";
			this.btnUpdateSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdateSelected.UseVisualStyleBackColor = true;
			this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
			// 
			// btnDelSlctd
			// 
			this.btnDelSlctd.Image = global::Emad_Store.Properties.Resources.Delete;
			this.btnDelSlctd.Location = new System.Drawing.Point(235, 19);
			this.btnDelSlctd.Name = "btnDelSlctd";
			this.btnDelSlctd.Size = new System.Drawing.Size(155, 30);
			this.btnDelSlctd.TabIndex = 1;
			this.btnDelSlctd.Text = "حذف الصنف المحدد";
			this.btnDelSlctd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelSlctd.UseVisualStyleBackColor = true;
			this.btnDelSlctd.Click += new System.EventHandler(this.btnDelSlctd_Click);
			// 
			// btnRefreshLst
			// 
			this.btnRefreshLst.Image = global::Emad_Store.Properties.Resources.Refresh;
			this.btnRefreshLst.Location = new System.Drawing.Point(550, 19);
			this.btnRefreshLst.Name = "btnRefreshLst";
			this.btnRefreshLst.Size = new System.Drawing.Size(110, 30);
			this.btnRefreshLst.TabIndex = 0;
			this.btnRefreshLst.Text = "تحديث القائمة";
			this.btnRefreshLst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefreshLst.UseVisualStyleBackColor = true;
			this.btnRefreshLst.Click += new System.EventHandler(this.btnRefreshLst_Click);
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.lblState.Location = new System.Drawing.Point(12, 358);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(20, 16);
			this.lblState.TabIndex = 9;
			this.lblState.Text = "...";
			// 
			// frm_mngCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 384);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_mngCategories";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ادارة اصناف الادوية و المواد";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCatName;
		private System.Windows.Forms.TextBox txtCatNotes;
		private System.Windows.Forms.Button btnNxtCat;
		private System.Windows.Forms.Button btnPrevCat;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button exprtAllCatsToExl;
		private System.Windows.Forms.Button exprtAllCats2pdf;
		private System.Windows.Forms.Button prtAllCats;
		private System.Windows.Forms.Button prtSlctCat;
		private System.Windows.Forms.Button saveCatsProdsToExl;
		private System.Windows.Forms.Button saveCatsProdsToPdf;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Button btnLstCat;
		private System.Windows.Forms.Button btnFrstCat;
		private System.Windows.Forms.Button btnAddNewCat;
		private System.Windows.Forms.Button btnUpdateSelected;
		private System.Windows.Forms.Button btnDelSlctd;
		private System.Windows.Forms.Button btnRefreshLst;
	}
}