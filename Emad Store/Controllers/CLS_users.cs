using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace Emad_Store.Controllers
{
	class CLS_users
	{
		Models.DataAcessLayer dal = new Models.DataAcessLayer();


		// TODO :: use this function just if the logged in user == admin (based on permissions)
		public int addNewUser(string username, string passwd, string fullName, string phoneNO)
		{
			// see if the username exists (search the username)
			string querySearch = "select * from users where users.username = " + username;
			if (dal.selectData(querySearch).Rows.Count > 0)
				return -1; // user already exists with the same username

			
			SqlParameter[] param = new SqlParameter[4];

			param[0] = new SqlParameter("@", SqlDbType.VarChar, 30);
			param[0].Value = username;

			param[1] = new SqlParameter("@", SqlDbType.VarChar, 40);
			param[1].Value = passwd;

			param[2] = new SqlParameter("@", SqlDbType.VarChar, 100);
			param[2].Value = fullName;

			param[3] = new SqlParameter("@", SqlDbType.VarChar, 15);
			param[3].Value = phoneNO;

			int result = dal.excuteCommand("sp_create_new_user", param);
			if (result == 1)
				return 0;

			return -1;

		}

		public int removeUser(string username)
		{
			int result = dal.excuteCommand("delete from users where username = '" + username + "'");

			if (result == 1)
				return 0;
			else if (result > 1)
				return 2;

			return 3;
		}
		
		public int removeUser(int userID)
		{
			int result = dal.excuteCommand("delete from users where user_id = " + userID);

			if (result == 1)
				return 0;
			else if (result > 1)
				return 2;

			return 3;
		}

		public DataTable getUsersList()
		{
			return dal.selectData("select * from users");
		}

	}
}
