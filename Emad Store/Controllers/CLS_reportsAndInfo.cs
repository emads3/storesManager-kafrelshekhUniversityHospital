﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Emad_Store.Controllers
{
	class CLS_reportsAndInfo
	{


		Models.DataAcessLayer dal = new Models.DataAcessLayer();


		public SqlDataAdapter getLstProductsAboutToFinish(bool includeFinished = false)
		{
			string query = "select * from v_get_products_with_details where stock_quantity <= alert_quantity"; // including finished products
			if (!includeFinished)
				query += " and stock_quantity != 0";
			return dal.selectDataAdapter(query);
		}


		// list of out-of-stock products "stock_quantity = 0" used in reports
		public SqlDataAdapter getLstOutOfStockProducts()
		{
			return dal.selectDataAdapter("select * from v_get_products_with_details where stock_quantity = 0");
		}

		public SqlDataAdapter getLstInOfStockProducts()
		{
			return dal.selectDataAdapter("select * from v_get_products_with_details where stock_quantity > 0");
		}


		/// <summary>
		/// number of units in stock, unique units not total units
		/// </summary>
		/// <returns type="string">number of products currently in stock</returns>
		public string getNumOfUnitsInStock()
		{
			return dal.selectData("select count(unit_id) from units where stock_quantity > 0").Rows[0][0].ToString();
		}

		public string getNumOfOutOfStockProducts()
		{
			return dal.selectData("select count(unit_id) from units where stock_quantity = 0").Rows[0][0].ToString();
		}
		public string getNumOfProductsAboutToFinish()
		{
			return dal.selectData("select count(unit_id) from units where stock_quantity <= alert_quantity and stock_quantity > 0").Rows[0][0].ToString();
		}
		public string getNumOfRegisteredBills()
		{
			return dal.selectData("select count(trans_id) from transactions").Rows[0][0].ToString();
		}

		



	}
}
