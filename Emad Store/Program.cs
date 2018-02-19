using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emad_Store
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		//public static userName = "";
		/*
		 * program.userName = dt.Rows[0]['username'].ToString();
		 * Rows[0]['username'] == >  can be written [0][0]
		 */
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Views.frm_main());
			//Application.Run(new Views.frm_outProducts());
			//Application.Run(new Views.FormCRByCode());


		}
	}
}
