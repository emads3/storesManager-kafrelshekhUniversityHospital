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
	public partial class frm_addUser : Form
	{

		Controllers.CLS_users _usersController = new Controllers.CLS_users();

		public frm_addUser()
		{
			InitializeComponent();
		}
		

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text, fullName = txtFullName.Text, passwd = txtPasswd.Text, phoneNO = txtPhoneNo.Text;

			if(username == "")
			{
				MessageBox.Show("لا يمكن ترك اسم الدخول فارغ", "خطا باسم الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
				return;
			} else if(passwd == string.Empty)
			{
				MessageBox.Show("لا يمكن ترك خانة الباسوورد فارغة", "خطأ بكلمة السر", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPasswd.Focus();
				return;
			}else if(txtFullName.Text == "")
			{
				MessageBox.Show("لا يمكن ترك اسم المستخدم فارغاً", "خطأ باسم المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFullName.Focus();
				return;
			}


			// validate length of boxes[[fixed and validated by max length property]]

			/*
			if (username.Length > 30)
			{
				MessageBox.Show("اسم الدخول لا يمكن ان يكون اكبر من 30 حرف", "خطا باسم الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUsername.Focus();
				return;
			}
			else if (fullName.Length > 100)
			{
				MessageBox.Show("اسم امين المخزن لا يمكن ان يتجاوز 100 حرف", "الاسم طويل", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtFullName.Focus();
				return;
			} else if (phoneNO.Length > 15)
			{
				MessageBox.Show("رقم الهاتف لا يمكن ان يتجاوز 15 رقم", "رقم هاتف طويل", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPhoneNo.Focus();
				return;
			}
			*/


			int result = _usersController.addNewUser(username, passwd, fullName, phoneNO);

			if (result == 0)
			{
				MessageBox.Show("تم اضافة المستخدم بنجاح");
				clearBoxes();
			} else if(result == -2)
			{
				MessageBox.Show("لم يتم اضافة المستخدم. يوجد مستخدم اخر بنفس اسم الدخول");
			}

		}

		void clearBoxes()
		{
			txtUsername.Clear();
			txtPasswd.Clear();
			txtFullName.Clear();
			txtPhoneNo.Clear();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtUsername_Validated(object sender, EventArgs e)
		{
			// if user name does not exist, terminate the handler, otherwise do the following stuff..
			if (!_usersController.userNameExists(txtUsername.Text))
				return;

			MessageBox.Show("يوجد اسم مستخدم اخر بنفس الاسم", "خطأ في اسم المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);

			txtUsername.Focus();
			txtUsername.SelectionStart = 0;
			txtUsername.SelectionLength = txtUsername.TextLength;
		}
	}
}
