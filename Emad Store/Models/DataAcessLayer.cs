using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Emad_Store.Models
{
	class DataAcessLayer
	{
		Controllers.CLS_dbSettings _dbConnectionSettings = new Controllers.CLS_dbSettings();
		SqlConnection sqlCon;
		public DataAcessLayer()
		{

			//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\kfs_hospital.mdf;Integrated Security=True;Connect Timeout=30

			// kh..
			//Server=.\nameOfServer; Database=kfs_hospital; Integrated Security=True;

			// prepared conenction string from the r.click on the database on the server instance
			//sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\bolli\documents\visual studio 2015\Projects\Emad Store\Emad Store\kfs_hospital.mdf';Integrated Security=True;Connect Timeout=30");

			/* edited prepared one */
			string[] dbServerInfo = _dbConnectionSettings.getDBserverInfo();
			string dbServerName = dbServerInfo[0]; //"(LocalDB)\\MSSQLLocalDB";
			string dbName = dbServerInfo[1]; //"C:\\Users\bolli\\documents\\visual studio 2015\\Projects\\Emad Store\\Emad Store\\kfs_hospital.mdf";
			string authMode = dbServerInfo[2]; //"Windows";
			string dbUsername = dbServerInfo[3]; //"temporary username";
			string dbPasswd = dbServerInfo[4]; //"temp password";

			// todo: use "AttachDbFilename" only if the user chose to store the db on the local machine
			// otherwise give the user an option to install the sqlserver
			sqlCon = new SqlConnection(@"Data Source=" + dbServerName + ";AttachDbFilename='" + dbName+ "';" + (authMode == "Windows" ? "Integrated Security=True;" : "Integrated Security=false; User ID=" + dbUsername + "; Password=" + dbPasswd + ";") + "Connect Timeout=30");
		}

		//method to open the connection
		public void Open()
		{
			if (sqlCon.State != ConnectionState.Open)
				sqlCon.Open();
		}

		//method to close the connection
		public void Close()
		{
			if (sqlCon.State == ConnectionState.Open)
				sqlCon.Close();
		}

		/// <summary>
		/// read data from database (using pre-definded storedProc in DB)
		/// </summary>
		/// <param name="storedProc">name of predefined DB stored procedure</param>
		/// <param name="param">arr of parameters of type "sqlParameter"</param>
		/// <returns></returns>
		public DataTable selectData(string storedProc, SqlParameter[] param)
		{
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = storedProc;
			sqlCmd.Connection = sqlCon;

			/*
			 * for(int i = 0; i < param.Length; ++i)
			 *	sqlCmd.Parameters.Add(param[i]);
			 */

			// check if there are sent params or not (learned)
			if (param != null)
				foreach (SqlParameter sp in param)
					sqlCmd.Parameters.Add(sp);

			SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		// overloaded function
		/// <summary>
		/// read data from database (using written query)
		/// </summary>
		/// <param name="query">sql query</param>
		/// <returns>datatable filled with the query results</returns>
		public DataTable selectData(string query)
		{
			SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}






		/// <summary>
		/// read data from database (using pre-definded storedProc in DB)
		/// </summary>
		/// <param name="storedProc">name of predefined DB stored procedure</param>
		/// <param name="param">arr of parameters of type "sqlParameter"</param>
		/// <returns>dataAdapter</returns>
		public SqlDataAdapter selectDataAdapter(string storedProc, SqlParameter[] param)
		{
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = storedProc;
			sqlCmd.Connection = sqlCon;

			/*
			 * for(int i = 0; i < param.Length; ++i)
			 *	sqlCmd.Parameters.Add(param[i]);
			 */

			// check if there are sent params or not (learned)
			if (param != null)
				foreach (SqlParameter sp in param)
					sqlCmd.Parameters.Add(sp);

			return new SqlDataAdapter(sqlCmd);
		}
		// overloaded function
		/// <summary>
		/// read data from database (using written query)
		/// </summary>
		/// <param name="query">sql query</param>
		/// <returns>dataAdapter filled with the query results</returns>
		public SqlDataAdapter selectDataAdapter(string query)
		{
			return new SqlDataAdapter(query, sqlCon);
		}


		/// <summary>
		/// C_UD (CRUD without read, we have defined a function for reading above) method (via storedProc only)
		/// </summary>
		/// <param name="storedProc"></param>
		/// <param name="param"></param>
		/// <returns type="int">number of affected rows</returns>
		public int excuteCommand(string storedProc, SqlParameter[] param)
		{
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = storedProc;
			sqlCmd.Connection = sqlCon;


			// check if there are sent params or not
			if (param != null)
				sqlCmd.Parameters.AddRange(param); // same as loop in the selectData method

			sqlCon.Open();

			// returns the the number of rows affected.
			//https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executenonquery(v=vs.110).aspx
			int emad = sqlCmd.ExecuteNonQuery();

			sqlCon.Close();

			return emad;
		}

		public int excuteCommand(string query)
		{
			SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
			sqlCon.Open();
			int emad = sqlCmd.ExecuteNonQuery();
			sqlCon.Close();
			return emad;
		}


		#region immediate editing using dataBinding
		/*
		// immediate editing
		// directly editing the table through dataAdapter (connected mode)
		public SqlDataAdapter immediateEditTbl(string query)
		{
			return new SqlDataAdapter(query, sqlCon);
		}
		
		//https://msdn.microsoft.com/en-us/library/z1z2bkx2%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
		// return the number of rows successfully updated from the DataTable.
		public int immediateEditTbl(DataTable dt, SqlDataAdapter da)
		{
			SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
			return da.Update(dt);
		}
		*/
		#endregion immediate editing using dataBinding




	} // end class DataAcessLayer
}
