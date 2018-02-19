using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Emad_Store.Controllers
{
	class CLS_Settings
	{
		Models.DataAcessLayer dal;
		public DataSet ds_emad;

		//SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB; Database=master; Integrated Security=True");

		public CLS_Settings()
		{
			dal = new Models.DataAcessLayer();
		}

		public int backUpDB(string backUpPath)
		{
			string fileName = backUpPath + "\\emad_01112137376_" + DateTime.Now.ToShortDateString().Replace('/', '-') + "_" + DateTime.Now.ToLongTimeString().Replace(':', '-');
			// TODO: edit this string
			string strQuery = "Backup Database [C:\\USERS\\BOLLI\\DOCUMENTS\\VISUAL STUDIO 2015\\PROJECTS\\EMAD STORE\\EMAD STORE\\KFS_HOSPITAL.MDF] to Disk='" + fileName + ".bak'";
			/*
			SqlCommand cmd;
			cmd = new SqlCommand(strQuery, con);
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			*/
			// ALTER Database [KFS_hospital] SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database [KFS_hospital] from Disk=path

			int operationResult;
			try
			{
				operationResult = dal.excuteCommand(strQuery);
			}
			catch (UnauthorizedAccessException)
			{
				// unified return value that tells the user that he has no permission to write in this path
				return -1;
			}
			return operationResult;
			
		}


	}
}
