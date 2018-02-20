namespace Emad_Store.Views
{
	partial class frm_aboutUs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aboutUs));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 13F);
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(527, 339);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// frm_aboutUs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 340);
			this.Controls.Add(this.richTextBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_aboutUs";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "عن المبرمج";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}