using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace Emad_Store.Controllers
{
	class CLS_suppliers
	{
		Models.DataAcessLayer dal = new Models.DataAcessLayer();
		public int addSupplier(string supplierName, string supplierAddress, string supplierPhone, string supplierNotes)
		{

			if (supplierNameExists(supplierName))
				return -2; // supplier exist with the same name

			SqlParameter[] param = new SqlParameter[4];

			param[0] = new SqlParameter("@supp_name", SqlDbType.VarChar, 100);
			param[0].Value = supplierName;

			param[1] = new SqlParameter("@supp_address", SqlDbType.VarChar, 200);
			param[1].Value = supplierAddress;

			param[2] = new SqlParameter("@supp_phone", SqlDbType.VarChar, 15);
			param[2].Value = supplierPhone;

			param[3] = new SqlParameter("@supp_description", SqlDbType.VarChar, 200);
			param[3].Value = supplierNotes;

			int result = dal.excuteCommand("sp_add_supplier", param);

			if (result == 1)
				return 0;

			return -1;

		}

		public bool supplierNameExists(string supplierName)
		{
			// see if the username exists (search the username)
			string querySearch = "select supp_name from suppliers where suppliers.supp_name = '" + supplierName + "'";
			if (dal.selectData(querySearch).Rows.Count > 0)
				return true;
			return false;
		}

		public int removeSupplier(string supplierName)
		{
			//TODO:: make sure of the db integrity first and violation of foreign keys
			int result = dal.excuteCommand("delete from suppliers where supp_name = '" + supplierName + "'");

			if (result == 1)
				return 0;
			else if (result > 1)
				return 2;

			return 3;
		}

		public int removeSupplier(int supplierID)
		{
			//TODO:: make sure of the db integrity first and violation of foreign keys
			int result = dal.excuteCommand("delete from suppliers where supplier_id = " + supplierID);

			if (result == 1)
				return 0;
			else if (result > 1)
				return 2;

			return 3;
		}


		public DataTable getSuppliersList()
		{
			return dal.selectData("select * from suppliers");
		}
	}
}
