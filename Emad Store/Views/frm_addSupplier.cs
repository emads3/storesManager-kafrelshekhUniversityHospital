using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emad_Store.Views
{
	public partial class frm_addSupplier : Form
	{
		Controllers.CLS_suppliers _controller = new Controllers.CLS_suppliers();
		public frm_addSupplier()
		{
			InitializeComponent();
		}

		private void txtSuppName_Validated(object sender, EventArgs e)
		{
			// if supplier name does not exist, terminate the handler, otherwise do the following stuff..
			if (!_controller.supplierNameExists(txtSuppName.Text))
				return;
			
			MessageBox.Show("يوجد اسم مورد اخر بنفس الاسم", "خطأ في اسم المورد", MessageBoxButtons.OK, MessageBoxIcon.Error);

			txtSuppName.Focus();
			txtSuppName.SelectionStart = 0;
			txtSuppName.SelectionLength = txtSuppName.TextLength;
		}

		private void btnCancelAddProductForm_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			string suppName = txtSuppName.Text, suppAddress = txtSuppAddress.Text, suppPhone = txtSuppNO.Text, suppNotes = txtSuppNotes.Text;

			//validatation
			if (suppName == "")
			{
				MessageBox.Show("لا يمكن ترك اسم المورد فارغ", "خطا باسم المورد", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSuppName.Focus();
				return;
			}

			//testboxes length validation done from length property for textbox.. no need to make it manually

			int result = _controller.addSupplier(suppName, suppAddress, suppPhone, suppNotes);

			if (result == 0)
			{
				MessageBox.Show("تم اضافة المورد بنجاح");
				clearBoxes();
			}
			else if (result == -2)
			{
				MessageBox.Show("لم يتم اضافة المورد. يوجد مورد اخر بنفس الاسم");
			}
			else
			{
				MessageBox.Show("حدث خطأ غير متوقع");
			}


		}

		void clearBoxes()
		{
			txtSuppName.Clear();
			txtSuppAddress.Clear();
			txtSuppNO.Clear();
			txtSuppNotes.Clear();
		}
	}
}
