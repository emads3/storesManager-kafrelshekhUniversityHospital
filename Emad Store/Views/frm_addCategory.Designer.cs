namespace Emad_Store.Views
{
	partial class frm_addCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addCategory));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCncl = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCatName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.btnAdd.Image = global::Emad_Store.Properties.Resources.Create;
			this.btnAdd.Location = new System.Drawing.Point(281, 157);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "اضافة";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCncl
			// 
			this.btnCncl.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.btnCncl.Image = global::Emad_Store.Properties.Resources.Delete;
			this.btnCncl.Location = new System.Drawing.Point(200, 157);
			this.btnCncl.Name = "btnCncl";
			this.btnCncl.Size = new System.Drawing.Size(75, 23);
			this.btnCncl.TabIndex = 1;
			this.btnCncl.Text = "الغاء";
			this.btnCncl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCncl.UseVisualStyleBackColor = true;
			this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(250, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "اسم التصنيف :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(250, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "وصف التصنيف :";
			// 
			// txtCatName
			// 
			this.txtCatName.Location = new System.Drawing.Point(23, 19);
			this.txtCatName.Name = "txtCatName";
			this.txtCatName.Size = new System.Drawing.Size(221, 23);
			this.txtCatName.TabIndex = 4;
			this.txtCatName.Validated += new System.EventHandler(this.txtCatName_Validated);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(23, 45);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(221, 75);
			this.txtDescription.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCatName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 139);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات التصنيف";
			// 
			// frm_addCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 192);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCncl);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_addCategory";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اضافة تصنيف جديد للادوية";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCncl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCatName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}