using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emad_Store.Views
{
	public partial class frm_addCategory : Form
	{
		Controllers.CLS_Categories catController = new Controllers.CLS_Categories();

		public frm_addCategory()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// TODO : validate name of the category before adding it
			if (txtCatName.Text == "")
			{
				MessageBox.Show("قم بكتابة اسم التصنيف اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (catController.addNewCat(txtCatName.Text, txtDescription.Text) == 1)
					MessageBox.Show("تم اضافة التصنيف: " + txtCatName.Text + " بنجاح");
				else
					MessageBox.Show("لم يتم اضافة التصنيف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCncl_Click(object sender, EventArgs e)
		{
			// clear thr input text inside both textboxes
			txtCatName.Clear();
			txtDescription.Clear();
		}

		private void txtCatName_Validated(object sender, EventArgs e)
		{
			// short circut logical operator, will not even use the function if formState != "add"
			if(txtCatName.Text != "" && catController.categoryExists(txtCatName.Text))
			{
				MessageBox.Show("يوجد تصنيف بنفس الاسم. من فضلك اختر تصنيف اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtCatName.Focus();
				txtCatName.SelectionStart = 0;
				txtCatName.SelectionLength = txtCatName.TextLength;
			}
		}
	}
}
