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
	public partial class frm_changeUserPasswd : Form
	{
		Controllers.CLS_Session loginObj = new Controllers.CLS_Session();

		public frm_changeUserPasswd()
		{
			InitializeComponent();

			txtNewPasswd2.Focus();
		}

		void focusTextBox(TextBox tb)
		{
			tb.Focus();
			tb.SelectionStart = 0;
			tb.SelectionLength = tb.TextLength;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (txtOldPasswd.Text == string.Empty)
			{
				MessageBox.Show("ادخل كلمة السر القديمة", "ادخل كلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Error);
				focusTextBox(txtOldPasswd);
				return;
			}
			else if (txtNewPasswd.Text == string.Empty)
			{
				MessageBox.Show("ادخل كلمة السر الجديدة", "ادخل كلمة السر الجديدة", MessageBoxButtons.OK, MessageBoxIcon.Error);
				focusTextBox(txtNewPasswd);
				return;
			}
			else if (txtNewPasswd.Text.Length < 5)
			{
				MessageBox.Show("كلمة السر يجب ان تكون اطول من 5 حروف و ارقام", "كلمة سر قصيرة", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				focusTextBox(txtNewPasswd);
				return;
			}
			else if (txtNewPasswd2.Text == string.Empty)
			{
				MessageBox.Show("اعد ادخال كلمة السر مرة اخري", "اعد ادخال كلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Error);
				focusTextBox(txtNewPasswd2);
				return;
			}

			int changePasswordResult = loginObj.changeUserPassword(txtOldPasswd.Text, txtNewPasswd.Text);

			if (changePasswordResult == -2)
			{
				MessageBox.Show("كلمة السر القديمة خاطئة", "خطأ بكلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Error);
				focusTextBox(txtOldPasswd);
			}
			else if(changePasswordResult == 0)
			{
				MessageBox.Show("تم تغير كلمة السر بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			else
			{
				MessageBox.Show("حدثت مشكلة قد تؤدي الي تلف النظام. من فضلك راجع مبرمج البرنامج");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
