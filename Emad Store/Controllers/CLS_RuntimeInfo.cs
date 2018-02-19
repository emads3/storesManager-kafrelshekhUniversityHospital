using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emad_Store.Controllers
{

	// TODO: recieve permissions as setters and return them as properties (getters) from the login class

	/// <summary>
	/// this class is used in the runtime
	/// u can use it anywhere while app is running, u can get info like currently logged username and userID from this class
	/// this class' info (such is userID and username) is set after a sccussfull loging in attemp, EMAD
	/// </summary>
	class CLS_RuntimeInfo
	{
		int _userID;
		string _username;
		string _fullUserName;
		// singleton pattern
		private static CLS_RuntimeInfo _instance = null;
		private CLS_RuntimeInfo() { } // private constructor

		public static CLS_RuntimeInfo getInstance
		{
			get
			{
				if (_instance == null)
					_instance = new CLS_RuntimeInfo();
				return _instance;
			}
		}

		//property for userID
		public int userID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

		// propery for username
		public string username
		{
			get { return this._username; }
			set { this._username = value; }
		}

		public string fullUserName
		{
			get { return this._fullUserName; }
			set { this._fullUserName = value; }
		}


	}
}
