using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emad_Store.Controllers
{
	// this class is independant and can be used without a connection to the database
	/*abstract*/
	class CLS_dbSettings
	{
		//TODO :: change the connection string in the app.config
		//https://stackoverflow.com/questions/502411/change-connection-string-reload-app-config-at-run-time
		public void setDBserverSettings(string serverName, string dbName, string authMode, string username = "", string password = "")
		{
			Properties.Settings.Default.db_Server = serverName;
			Properties.Settings.Default.db_Name = dbName;
			Properties.Settings.Default.db_Mode = authMode == "SQL" ? "SQL" : "Windows";


			if (authMode == "SQL")
			{
				Properties.Settings.Default.db_ID = username;
				Properties.Settings.Default.db_Password = password;
			}
			else
			{
				Properties.Settings.Default.db_ID = string.Empty;
				Properties.Settings.Default.db_Password = string.Empty;
			}
			

			Properties.Settings.Default.Save();

			// TODO : add test connection, try-catch a connection string
			//https://stackoverflow.com/questions/3668506/efficient-sql-test-query-or-validation-query-that-will-work-across-all-or-most
		}

		/// <summary>
		/// get the conenction to database server information
		/// </summary>
		/// <returns type=arr[string]>arr[0] ==> server name, arr[1] ==> database name, arr[2] ==> authentication mode, arr[3] ==> authentication username, arr[4] ==> authentication password</returns>
		public string[] getDBserverInfo()
		{
			string serverName = Properties.Settings.Default.db_Server;
			string dbName = Properties.Settings.Default.db_Name;
			string authMode = Properties.Settings.Default.db_Mode;
			string username = Properties.Settings.Default.db_ID;
			string password = Properties.Settings.Default.db_Password; // don't return the password to the view, but i need it in connection strign

			return new string[] { serverName, dbName, authMode, username, password };
		}

	} // end abstract class


}
