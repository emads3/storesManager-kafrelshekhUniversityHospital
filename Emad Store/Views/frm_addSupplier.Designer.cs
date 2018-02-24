namespace Emad_Store.Views
{
	partial class frm_addSupplier
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addSupplier));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSuppNotes = new System.Windows.Forms.TextBox();
			this.txtSuppNO = new System.Windows.Forms.TextBox();
			this.txtSuppAddress = new System.Windows.Forms.TextBox();
			this.txtSuppName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelAddProductForm = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSuppNotes);
			this.groupBox1.Controls.Add(this.txtSuppNO);
			this.groupBox1.Controls.Add(this.txtSuppAddress);
			this.groupBox1.Controls.Add(this.txtSuppName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 222);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات المورد";
			// 
			// txtSuppNotes
			// 
			this.txtSuppNotes.Location = new System.Drawing.Point(15, 130);
			this.txtSuppNotes.MaxLength = 200;
			this.txtSuppNotes.Multiline = true;
			this.txtSuppNotes.Name = "txtSuppNotes";
			this.txtSuppNotes.Size = new System.Drawing.Size(231, 72);
			this.txtSuppNotes.TabIndex = 3;
			// 
			// txtSuppNO
			// 
			this.txtSuppNO.Location = new System.Drawing.Point(15, 96);
			this.txtSuppNO.MaxLength = 15;
			this.txtSuppNO.Name = "txtSuppNO";
			this.txtSuppNO.Size = new System.Drawing.Size(231, 24);
			this.txtSuppNO.TabIndex = 2;
			// 
			// txtSuppAddress
			// 
			this.txtSuppAddress.Location = new System.Drawing.Point(15, 61);
			this.txtSuppAddress.MaxLength = 200;
			this.txtSuppAddress.Name = "txtSuppAddress";
			this.txtSuppAddress.Size = new System.Drawing.Size(231, 24);
			this.txtSuppAddress.TabIndex = 1;
			// 
			// txtSuppName
			// 
			this.txtSuppName.Location = new System.Drawing.Point(15, 23);
			this.txtSuppName.MaxLength = 100;
			this.txtSuppName.Name = "txtSuppName";
			this.txtSuppName.Size = new System.Drawing.Size(231, 24);
			this.txtSuppName.TabIndex = 0;
			this.txtSuppName.Validated += new System.EventHandler(this.txtSuppName_Validated);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(252, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "ملحوظات :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(252, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "رقم تليفون المورد :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "عنوان المورد :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(252, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "اسم المورد :";
			// 
			// btnCancelAddProductForm
			// 
			this.btnCancelAddProductForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelAddProductForm.Image = global::Emad_Store.Properties.Resources.Cancel;
			this.btnCancelAddProductForm.Location = new System.Drawing.Point(165, 241);
			this.btnCancelAddProductForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancelAddProductForm.Name = "btnCancelAddProductForm";
			this.btnCancelAddProductForm.Size = new System.Drawing.Size(87, 37);
			this.btnCancelAddProductForm.TabIndex = 1;
			this.btnCancelAddProductForm.Text = "الغاء";
			this.btnCancelAddProductForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelAddProductForm.UseVisualStyleBackColor = true;
			this.btnCancelAddProductForm.Click += new System.EventHandler(this.btnCancelAddProductForm_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddProduct.Location = new System.Drawing.Point(258, 241);
			this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(127, 37);
			this.btnAddProduct.TabIndex = 0;
			this.btnAddProduct.Text = "اضافة";
			this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// frm_addSupplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 287);
			this.Controls.Add(this.btnCancelAddProductForm);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_addSupplier";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اضافة مورد جديد";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSuppNotes;
		private System.Windows.Forms.TextBox txtSuppNO;
		private System.Windows.Forms.TextBox txtSuppAddress;
		private System.Windows.Forms.TextBox txtSuppName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnCancelAddProductForm;
		public System.Windows.Forms.Button btnAddProduct;
	}
}