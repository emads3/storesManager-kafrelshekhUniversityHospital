namespace Emad_Store.Reports
{
	partial class frm_listProductsAboutToFinish
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listProductsAboutToFinish));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPrintList = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(1, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(813, 268);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnPrintList
			// 
			this.btnPrintList.Image = global::Emad_Store.Properties.Resources.Print;
			this.btnPrintList.Location = new System.Drawing.Point(38, 276);
			this.btnPrintList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnPrintList.Name = "btnPrintList";
			this.btnPrintList.Size = new System.Drawing.Size(131, 28);
			this.btnPrintList.TabIndex = 1;
			this.btnPrintList.Text = "طباعة القائمة";
			this.btnPrintList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintList.UseVisualStyleBackColor = true;
			this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(438, 282);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "اجمالي عدد المنتجات التي قاربت علي الانتهاء:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(728, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "..";
			// 
			// frm_listProductsAboutToFinish
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 314);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPrintList);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_listProductsAboutToFinish";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "قائمة بالمنتجات التي قاربت علي الانتاء من المخزن";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnPrintList;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
	}
}