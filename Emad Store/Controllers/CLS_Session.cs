using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Security.Cryptography;

namespace Emad_Store.Controllers
{
	class CLS_Session
	{
		Models.DataAcessLayer dal;
		Controllers.CLS_reportsAndInfo _reportsAndInfo = new Controllers.CLS_reportsAndInfo();

		public CLS_Session()
		{
			dal = new Models.DataAcessLayer();
		}

		// TODO: this should return a boolean value not a dataTable (fix it) .. fixed (DONE), EMAD
		public int login(string username, string password)
		{
			if (!dal.testDBConnection())
				return 2;

			string hashedPassword = GetHashString(password);

			SqlParameter[] param = new SqlParameter[2];
			// first param (username)
			param[0] = new SqlParameter("@username", SqlDbType.VarChar, 30);
			param[0].Value = username;
			// first param (password), length = 40 (sha1 hash)
			param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 40);
			param[1].Value = hashedPassword;
			
			DataTable dt = dal.selectData("sp_login", param);


			if (dt.Rows.Count > 0)
			{
				
				int loggedUserID = Convert.ToInt32(dt.Rows[0][0].ToString());
				string loggedUser_username = dt.Rows[0][1].ToString();
				string loggedUser_fullName = dt.Rows[0][3].ToString();
				string loggedUser_phoneNum = dt.Rows[0][4].ToString();

				setRuntimeInfo(loggedUserID, loggedUser_username, loggedUser_fullName);

				controlMenus(); // TODO: enable the menus based on the permissions

				return 1;
			}
			return 0;
		}


		/*to functions used to get the sha1 hash for the password */
		public static byte[] GetHash(string inputString)
		{
			HashAlgorithm algorithm = SHA1.Create();  // SHA1.Create()
			return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
		}
		public static string GetHashString(string inputString)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(inputString))
				sb.Append(b.ToString("X2"));

			return sb.ToString().ToLower();
		}


		void controlMenus()
		{
			// TODO: permissions (enable the menus based on user permissions)
			Views.frm_main.getMainFormInstance.fileToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.productsToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.usersToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.backUpDbToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.restoreDbBackupToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.repotrsToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.stockToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.repotrsToolStripMenuItem.Enabled = true;

			Views.frm_main.getMainFormInstance.groupBox2.Visible = true;
			Views.frm_main.getMainFormInstance.groupBox2.Enabled = true;

			Views.frm_main.getMainFormInstance.dbSettingsToolStripMenuItem.Enabled = false;

			Views.frm_main.getMainFormInstance.changeUserPasswdToolStripMenuItem.Enabled = true;
			Views.frm_main.getMainFormInstance.changeUserPasswdToolStripMenuItem.Visible = true;

			Views.frm_main.getMainFormInstance.loginToolStripMenuItem.Enabled = false;
			Views.frm_main.getMainFormInstance.loginToolStripMenuItem.Visible = false;

			Views.frm_main.getMainFormInstance.listProductsToolStripMenuItem.Enabled = true;

			// change it later to enable it based on permissions and user groups
			if (Controllers.CLS_RuntimeInfo.getInstance.username == "admin")
			{
				Views.frm_main.getMainFormInstance.addNewUserToolStripMenuItem.Enabled = true;
				Views.frm_main.getMainFormInstance.addNewSupplierToolStripMenuItem.Enabled = true;
			}

			fillMainFormData();
		}


		// take an array of permissions and send them to the rumtime class.. take a string of username, int of userID
		void setRuntimeInfo(int userID,string loggedUser_username, string loggedUser_fullName)
		{
			//set the info in the runtime class (userID)
			// note that the application uses this static class' info during the runtime
			Controllers.CLS_RuntimeInfo.getInstance.userID = userID;						/*	set the userID			*/
			Controllers.CLS_RuntimeInfo.getInstance.fullUserName = loggedUser_fullName;     /*	set the user full name	*/
			Controllers.CLS_RuntimeInfo.getInstance.username = loggedUser_username;     /*	set the username*/
		}



		void fillMainFormData()
		{
			// make some usefull stuff here
			Views.frm_main.getMainFormInstance.txtUsername.Text = Controllers.CLS_RuntimeInfo.getInstance.fullUserName;

			Views.frm_main.getMainFormInstance.fillMainScreenInfo();
		}



		//change user password
		public int changeUserPassword(string oldPassword, string newPassword)
		{
			bool validUser = false;

			int result = login(Controllers.CLS_RuntimeInfo.getInstance.username, oldPassword);

			if (result == 1)
				validUser = true;

			if (!validUser)
				return -2;

			newPassword = GetHashString(newPassword);

			SqlParameter[] param = new SqlParameter[2];

			param[0] = new SqlParameter("@user_id", SqlDbType.Int);
			param[0].Value = Controllers.CLS_RuntimeInfo.getInstance.userID;

			param[1] = new SqlParameter("@new_passwd", SqlDbType.VarChar, 40);
			param[1].Value = newPassword;

			if (dal.excuteCommand("sp_change_password", param) == 1)
				return 0;

			return -3; // will never be reached

		}





	} // end class
}
