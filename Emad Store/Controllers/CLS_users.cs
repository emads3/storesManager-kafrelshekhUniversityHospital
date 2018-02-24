using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using System.Security.Cryptography;

namespace Emad_Store.Controllers
{
	class CLS_users
	{
		Models.DataAcessLayer dal = new Models.DataAcessLayer();


		// TODO :: use this function just if the logged in user == admin (based on permissions)
		public int addNewUser(string username, string passwd, string fullName, string phoneNO)
		{

			if(userNameExists(username))
				return -2; // user already exists with the same username


			passwd = GetHashString(passwd); // encrypt the password SHA1
			
			SqlParameter[] param = new SqlParameter[4];

			param[0] = new SqlParameter("@username", SqlDbType.VarChar, 30);
			param[0].Value = username;

			param[1] = new SqlParameter("@passwd", SqlDbType.VarChar, 40);
			param[1].Value = passwd;

			param[2] = new SqlParameter("@fullname", SqlDbType.VarChar, 100);
			param[2].Value = fullName;

			param[3] = new SqlParameter("@phone_no", SqlDbType.VarChar, 15);
			param[3].Value = phoneNO;

			int result = dal.excuteCommand("sp_create_new_user", param);
			if (result == 1)
				return 0;

			return -1;

		}

		public bool userNameExists(string username)
		{
			// see if the username exists (search the username)
			string querySearch = "select * from users where users.username = '" + username + "'";
			if (dal.selectData(querySearch).Rows.Count > 0)
				return true;
			return false;
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
	}
}
