using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace Emad_Store.Views
{
	
	public partial class frm_login : Form
	{
		Controllers.CLS_Session loginObj = new Controllers.CLS_Session();
		public frm_login()
		{
			InitializeComponent();

			txtUsername.Focus();// set the focus to the username textbox on load
		}

		// close the login form (cencel button)
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		// login button
		private void button1_Click(object sender, EventArgs e)
		{
			if(txtUsername.Text == "" || txtPasswd.Text == "")
			{
				MessageBox.Show("قم بادخال اسم المستخدم و كلمة السر");
				return;
			}

			bool validUser = loginObj.login(txtUsername.Text, txtPasswd.Text);

			if (validUser) // successfull login attempt
				this.Close(); // close the login form dialog
			else
			{
				txtPasswd.Clear();
				MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة");
			}
		}

		private void frm_login_Load(object sender, EventArgs e)
		{
			// TODO: fix it does not work, try to place this piece of code inside the constructor
			txtUsername.Focus();
			//for debuging
			//txtUsername.Text = " emad ";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//txtUsername.Text = txtPasswd.Text = "a";
			txtUsername.Text = "emads3";
			txtPasswd.Text = "123456";
		}
	}
}
