namespace Emad_Store.Views
{
	partial class frm_addProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addProduct));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.alrtQntnumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.txtProdName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProductNotes = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMsrUnt = new System.Windows.Forms.ComboBox();
			this.cmbCats = new System.Windows.Forms.ComboBox();
			this.cmbSplrs = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelAddProductForm = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.lblState = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.alrtQntnumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.alrtQntnumericUpDown);
			this.groupBox1.Controls.Add(this.txtProdName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtProductNotes);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbMsrUnt);
			this.groupBox1.Controls.Add(this.cmbCats);
			this.groupBox1.Controls.Add(this.cmbSplrs);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(463, 466);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات المنتج";
			// 
			// alrtQntnumericUpDown
			// 
			this.alrtQntnumericUpDown.Location = new System.Drawing.Point(135, 429);
			this.alrtQntnumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.alrtQntnumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.alrtQntnumericUpDown.Name = "alrtQntnumericUpDown";
			this.alrtQntnumericUpDown.Size = new System.Drawing.Size(203, 23);
			this.alrtQntnumericUpDown.TabIndex = 7;
			// 
			// txtProdName
			// 
			this.txtProdName.Location = new System.Drawing.Point(17, 30);
			this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtProdName.Name = "txtProdName";
			this.txtProdName.Size = new System.Drawing.Size(321, 23);
			this.txtProdName.TabIndex = 0;
			this.txtProdName.Validated += new System.EventHandler(this.txtProdName_Validated);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(347, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "اسم المنتج :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 429);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(111, 23);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "-";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(241, 393);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(101, 28);
			this.button4.TabIndex = 6;
			this.button4.Text = "الغاء الصورة";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Image = global::Emad_Store.Properties.Resources.Display_16x16;
			this.button3.Location = new System.Drawing.Point(17, 393);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(217, 28);
			this.button3.TabIndex = 5;
			this.button3.Text = "تحديد ملف الصورة";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pictureBox1.Location = new System.Drawing.Point(17, 233);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(321, 152);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(347, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "صورة وصفية :";
			// 
			// txtProductNotes
			// 
			this.txtProductNotes.Location = new System.Drawing.Point(17, 93);
			this.txtProductNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtProductNotes.Multiline = true;
			this.txtProductNotes.Name = "txtProductNotes";
			this.txtProductNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtProductNotes.Size = new System.Drawing.Size(321, 68);
			this.txtProductNotes.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(347, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "وصف المنتج :";
			// 
			// cmbMsrUnt
			// 
			this.cmbMsrUnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMsrUnt.FormattingEnabled = true;
			this.cmbMsrUnt.Location = new System.Drawing.Point(17, 201);
			this.cmbMsrUnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cmbMsrUnt.Name = "cmbMsrUnt";
			this.cmbMsrUnt.Size = new System.Drawing.Size(321, 24);
			this.cmbMsrUnt.TabIndex = 4;
			this.cmbMsrUnt.SelectedIndexChanged += new System.EventHandler(this.cmbMsrUnt_SelectedIndexChanged);
			// 
			// cmbCats
			// 
			this.cmbCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCats.FormattingEnabled = true;
			this.cmbCats.Location = new System.Drawing.Point(17, 169);
			this.cmbCats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cmbCats.Name = "cmbCats";
			this.cmbCats.Size = new System.Drawing.Size(321, 24);
			this.cmbCats.TabIndex = 3;
			// 
			// cmbSplrs
			// 
			this.cmbSplrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSplrs.FormattingEnabled = true;
			this.cmbSplrs.Location = new System.Drawing.Point(18, 61);
			this.cmbSplrs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cmbSplrs.Name = "cmbSplrs";
			this.cmbSplrs.Size = new System.Drawing.Size(321, 24);
			this.cmbSplrs.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(347, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "المورد :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(347, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "وحدة القياس :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(346, 433);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "تحذير الانتهاء عند :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(347, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "القسم ( الصنف ) :";
			// 
			// btnCancelAddProductForm
			// 
			this.btnCancelAddProductForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelAddProductForm.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.btnCancelAddProductForm.Location = new System.Drawing.Point(255, 492);
			this.btnCancelAddProductForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancelAddProductForm.Name = "btnCancelAddProductForm";
			this.btnCancelAddProductForm.Size = new System.Drawing.Size(87, 37);
			this.btnCancelAddProductForm.TabIndex = 1;
			this.btnCancelAddProductForm.Text = "الغاء";
			this.btnCancelAddProductForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelAddProductForm.UseVisualStyleBackColor = true;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddProduct.Location = new System.Drawing.Point(348, 492);
			this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(127, 37);
			this.btnAddProduct.TabIndex = 0;
			this.btnAddProduct.Text = "اضافة";
			this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(12, 528);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(20, 16);
			this.lblState.TabIndex = 4;
			this.lblState.Text = "...";
			// 
			// frm_addProduct
			// 
			this.AcceptButton = this.btnAddProduct;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelAddProductForm;
			this.ClientSize = new System.Drawing.Size(485, 555);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.btnCancelAddProductForm);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_addProduct";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اضافة منتج جديد";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.alrtQntnumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblState;
		public System.Windows.Forms.ComboBox cmbMsrUnt;
		public System.Windows.Forms.ComboBox cmbCats;
		public System.Windows.Forms.ComboBox cmbSplrs;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.TextBox txtProductNotes;
		public System.Windows.Forms.Button btnCancelAddProductForm;
		public System.Windows.Forms.Button btnAddProduct;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox txtProdName;
		public System.Windows.Forms.NumericUpDown alrtQntnumericUpDown;
	}
}