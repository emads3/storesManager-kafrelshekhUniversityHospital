﻿using System;
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
	public partial class frm_DbSettings : Form
	{
		// abstract class
		Controllers.CLS_dbSettings _dbConnectionSettings;
		public frm_DbSettings()
		{
			_dbConnectionSettings = new Controllers.CLS_dbSettings(); // TODO: remove the instant (astract class)
			InitializeComponent();


			string[] dbConnectionInfo = _dbConnectionSettings.getDBserverInfo();

			txtServerName.Text = dbConnectionInfo[0];
			txtDBName.Text= dbConnectionInfo[1];

			if (dbConnectionInfo[2] == "SQL")
			{
				radioBtnSQL.Checked = true;
				txtDBUsername.ReadOnly = false;
				txtDBpassword.ReadOnly = false;
				txtDBUsername.Text = dbConnectionInfo[3];
			}
			else
			{
				radioBtnWin.Checked = true;
				txtDBpassword.Clear();
				txtDBUsername.Clear();
				txtDBUsername.ReadOnly = true;
				txtDBpassword.ReadOnly = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioBtnSQL.Checked)
				_dbConnectionSettings.setDBserverSettings(txtServerName.Text, txtDBName.Text, "SQL", txtDBUsername.Text, txtDBpassword.Text);
			else if(radioBtnWin.Checked)
				_dbConnectionSettings.setDBserverSettings(txtServerName.Text, txtDBName.Text, "Windows");

			MessageBox.Show("تم حفظ الاعدادات بنجاح");

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			txtDBUsername.ReadOnly = false;
			txtDBpassword.ReadOnly = false;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			txtDBUsername.ReadOnly = true;
			txtDBpassword.ReadOnly = true;
		}

		private void btnTestConeection_Click(object sender, EventArgs e)
		{
            string[] dbServerInfo = _dbConnectionSettings.getDBserverInfo();
            string dbServerName = dbServerInfo[0]; //"(LocalDB)\\MSSQLLocalDB";
            string dbName = dbServerInfo[1]; //"C:\\Users\emad\\documents\\visual studio 2015\\Projects\\Emad Store\\Emad Store\\kfs_hospital.mdf";

            if (dbServerName == "" || dbName == "")// make sure that there is some info stored in the settings
            {
                MessageBox.Show("لا يوجد معلومات اتصال بقاعدة البيانات مخزنة في البرنامج");
                return;
            }
            else
            {
                Models.DataAcessLayer dal = new Models.DataAcessLayer();
                if (dal.testDBConnection())
                    MessageBox.Show("الاتصال يعمل بشكل صحيح");
                else
                    MessageBox.Show("يوجد خطأ في الاتصال بقاعدة البيانات");
            }
		}
	}
}
