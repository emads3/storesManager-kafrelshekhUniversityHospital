using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Emad_Store.Controllers
{
	class CLS_Products
	{
		Models.DataAcessLayer dal = new Models.DataAcessLayer();


		/*
		 * // no longer need it, replaced with more general function execProc()
		public DataTable getCategories()
		{
			DAL.DataAcessLayer dal = new DAL.DataAcessLayer();
			DataTable dt = new DataTable();
			return dal.selectData("get_categories", null);
		}
		*/

		/*
		 * // no longer need it, replaced with more general function execProc()
		public DataTable getSuppliers()
		{
			DAL.DataAcessLayer dal = new DAL.DataAcessLayer();
			DataTable dt = new DataTable();
			return dal.selectData("get_suppliers", null);
		}
		*/

		#region mng/add products
		/// <summary>
		/// get all stored products in the database
		/// </summary>
		/// <returns type="datatable">list of products from a stored procedure</returns>
		public DataTable getAllProducts()
		{
			return dal.selectData("get_all_products", null);
		}


		public DataTable getAllCategories()
		{
			return dal.selectData("get_categories", null);
		}
		public DataTable getAllSuppliers()
		{
			return dal.selectData("get_suppliers", null);
		}

		public DataTable getMsrentUnits()
		{
			return dal.selectData("get_measure_units", null);
		}



		/// <summary>
		/// receive the params (add product form) and insert them into the DB
		/// </summary>
		/// <param name="productName"> name of the product, string max:200 charracter</param>
		/// <param name="alertQnt"> alert when the quantity goes uner xxx , type : int</param>
		/// <param name="notes">notes or short description, max 200 characters. string</param>
		/// <param name="suppId"></param>
		/// <param name="catId"></param>
		/// <param name="msrUntId"></param>
		/// <param name="unitImg"></param>
		/// <returns>
		/// returns the the number of rows affected. to check whether it did what it has to to do or not
		/// </returns>
		public int addProduct(string productName, int alertQnt, string notes, int suppId, int catId, int msrUntId, byte[] unitImg)
		{
			SqlParameter[] param = new SqlParameter[7];


			param[0] = new SqlParameter("@prod_name", SqlDbType.VarChar, 200);
			param[0].Value = productName;

			param[1] = new SqlParameter("@alert_quantity", SqlDbType.Int);
			param[1].Value = alertQnt;

			param[2] = new SqlParameter("@notes", SqlDbType.VarChar, 200);
			param[2].Value = notes;

			param[3] = new SqlParameter("@supplier_id", SqlDbType.Int);
			param[3].Value = suppId;

			param[4] = new SqlParameter("@cat_id", SqlDbType.Int);
			param[4].Value = catId;

			param[5] = new SqlParameter("@msr_unt_id", SqlDbType.Int);
			param[5].Value = msrUntId;

			param[6] = new SqlParameter("@prod_img", SqlDbType.Image);
			param[6].Value = unitImg;

			// returns the the number of rows affected.
			return dal.excuteCommand("add_product", param);
		}

		/// <summary>
		/// check if there is a product with this name or not
		/// </summary>
		/// <param name="prodName">product name type:string</param>
		/// <returns></returns>
		public bool productExists(string prodName)
		{
			DataTable dt = dal.selectData("select * from units where unit_name = '" + prodName + "'");
			if (dt.Rows.Count > 0)
				return true;
			return false;
		}

		public DataTable searchProduct(string searchKeyword)
		{
			SqlParameter[] param = new SqlParameter[] { new SqlParameter("@srch_word", SqlDbType.VarChar, 100) };
			param[0].Value = searchKeyword;
			return dal.selectData("serch_products", param);
		}

		public int deleteProduct(int product_id)
		{
			return dal.excuteCommand("delete from units where unit_id = " + product_id);
		}

		public DataTable getProductImg(int prodId)
		{
			return dal.selectData("select unit_img from units where unit_id = " + prodId);
		}

		/// <summary>
		/// receive the params (add product form) and insert them into the DB
		/// </summary>
		/// <param name="productName"> name of the product, string max:200 charracter</param>
		/// <param name="alertQnt"> alert when the quantity goes uner xxx , type : int</param>
		/// <param name="notes">notes or short description, max 200 characters. string</param>
		/// <param name="suppId"></param>
		/// <param name="catId"></param>
		/// <param name="msrUntId"></param>
		/// <param name="unitImg"></param>
		/// <returns>
		/// returns the the number of rows affected. to check whether it did what it has to to do or not
		/// </returns>
		public bool updtProduct(int product_id, string productName, int alertQnt, string notes, int suppId, int catId, int msrUntId, byte[] unitImg)
		{
			SqlParameter[] param = new SqlParameter[8];

			param[0] = new SqlParameter("@prod_name", SqlDbType.VarChar, 200);
			param[0].Value = productName;

			param[1] = new SqlParameter("@alert_quantity", SqlDbType.Int);
			param[1].Value = alertQnt;

			param[2] = new SqlParameter("@notes", SqlDbType.VarChar, 200);
			param[2].Value = notes;

			param[3] = new SqlParameter("@supplier_id", SqlDbType.Int);
			param[3].Value = suppId;

			param[4] = new SqlParameter("@cat_id", SqlDbType.Int);
			param[4].Value = catId;

			param[5] = new SqlParameter("@msr_unt_id", SqlDbType.Int);
			param[5].Value = msrUntId;

			param[6] = new SqlParameter("@prod_img", SqlDbType.Image);
			param[6].Value = unitImg;

			param[7] = new SqlParameter("@unit_id", SqlDbType.Int);
			param[7].Value = product_id;

			// returns the the number of rows affected.
			if (dal.excuteCommand("update_product", param) > 0)
				return true;

			return false;
		}

		public DataTable getAllDeparments()
		{
			return dal.selectData("select * from departments");
		}

		#endregion mng/add products


		#region bills
		
		public int getLatestBillNumber()
		{
			DataTable dt =  dal.selectData("select isnull(max(trans_id), 0) from transactions"); // if there are no bills, return 0 instead of null
			int latestBillNum = Convert.ToInt32(dt.Rows[0][0]);
			return latestBillNum;
		}

		/// <summary>
		/// create a new bill record
		/// </summary>
		/// <param name="receiverName"></param>
		/// <param name="billNotes"></param>
		/// <param name="userID"></param>
		/// <param name="departmentID"></param>
		/// <returns type="int">-0: successfully done its job</returns>
		/// <returns type="int">-1: failed to create the bill</returns>
		/// <returns type="int">-2: craeted the bill but did't insert its items, ACID operations completed</returns>
		public int createNewBillOutProducts(int billNum, DateTime billTime, string receiverName, string billNotes, int userID, int departmentID, DataTable dtProductsList)
		{
			SqlParameter[] billParams = new SqlParameter[7];

			billParams[0] = new SqlParameter("@bill_id", SqlDbType.Int);
			billParams[0].Value = billNum;

			billParams[1] = new SqlParameter("@receiver_name", SqlDbType.VarChar, 100);
			billParams[1].Value = receiverName;

			billParams[2] = new SqlParameter("@notes", SqlDbType.VarChar, 200);
			billParams[2].Value = billNotes;

			billParams[3] = new SqlParameter("@user_id", SqlDbType.Int);
			billParams[3].Value = userID;

			billParams[4] = new SqlParameter("@dept_id", SqlDbType.Int);
			billParams[4].Value = departmentID;

			billParams[5] = new SqlParameter("@trans_time", SqlDbType.DateTime);
			billParams[5].Value = billTime;

			billParams[6] = new SqlParameter("@transaction_type", SqlDbType.Bit);
			billParams[6].Value = 0;

			int emad = dal.excuteCommand("sp_add_new_bill", billParams);
			if (emad != 1) // affected rows = 1, means the bill was created successfully
				// inform the user (the view) that the bill was not successfully created
				return -1; // -2 is a return value to know at which part the function exited


			//
			// otherwise.. continue (insert the bill units)
			//
			// will not move the following block of code to another function to guarantee ACID principles

			/*
			 * the received datatable (dtProductsList) consists of 3 cols
			 * [1] ==> the product_id
			 * [2] ==> the quantity
			 */

			SqlParameter[] omda = new SqlParameter[4];
			int unitInsertionResult = 1; // will hold the number of affected rows every single iteration
			for (int i = 0; i < dtProductsList.Rows.Count && unitInsertionResult == 1; ++i)
			{
				omda[0] = new SqlParameter("@transaction_id", SqlDbType.Int);
				omda[0].Value = billNum;

				omda[1] = new SqlParameter("@unit_id", SqlDbType.Int);
				int unit_idd = Convert.ToInt32(dtProductsList.Rows[i][0].ToString());
				omda[1].Value = unit_idd; // first column (productID)

				omda[2] = new SqlParameter("@quantity", SqlDbType.Int);
				int qntty = Convert.ToInt32(dtProductsList.Rows[i][1].ToString());
				omda[2].Value = qntty; // second column (quantity)

				omda[3] = new SqlParameter("@transaction_type", SqlDbType.Bit);
				omda[3].Value = 0;

				// the expected return value from this stored proc: 2
				// since this stored proc moifies 2 rows every single call
				// 1- insert the order detail (new row) in table "transaction_units"
				// 2- update "stock_quantity" in table "units"
				int affectedRows = dal.excuteCommand("sp_insert_transaction_items", omda);
				if (affectedRows != 2)
				{
					// this means the number of affected rows != 2, failure happened while insertion or updating the stock
					unitInsertionResult = 5555555;  // random number code.. something bad happened
					break;                          // break from the result and don't continue to insert more products
				}

				#region removed block
				// update the stock
				// added an update command to the stored procedure to update the unit after inserting it in order_details
				// so there is no need to the following block
				/*
				{
					int currentStockQntty = Convert.ToInt32(dal.selectData("select stock_quantity from units where unit_id = " + unit_idd).Rows[0][0].ToString());
					int updateUnitStockResult = dal.excuteCommand("update units set stock_quantity = " + (currentStockQntty - qntty) + " where unit_id = " + unit_idd);

					if (updateUnitStockResult != 1)
					{
						unitInsertionResult = 666666; // a unified code to know the error
						break;// something bad happedned
					}
				}
				*/
				#endregion removed block

			} // end loop

			if (unitInsertionResult == 1) // nothing bad happened, success with no failures
				return 0; // all units of the bill were created successfully
			// if something bad happened, undo what was inserted (ACID) principle in database
			else if (unitInsertionResult == 5555555)
			{
				// remove the inserted bill items, from "transaction_units" table
				dal.excuteCommand("delete from transaction_units where transaction_id = " + billNum);

				// then remove the bill itself from "transactions" table
				dal.excuteCommand("delete from transactions where trans_id = " + billNum);

				return -2;// return value for failure after guarantee ACID
			}

			// code will never reach this line, just added it to avoid the (not all code paths have a return)
			return -3;

		}





		/// <summary>
		/// recharge the stock with products
		/// </summary>
		/// <param name="billNum"></param>
		/// <param name="billTime"></param>
		/// <param name="delegateName"></param>
		/// <param name="billNotes"></param>
		/// <param name="userID"></param>
		/// <param name="dtProductsList"></param>
		/// <returns type="int">-0: successfully done its job</returns>
		/// <returns type="int">-1: failed to create the bill</returns>
		/// <returns type="int">-2: craeted the bill but did't insert its items, ACID operations completed</returns>
		public int createNewBillInProducts(int billNum, DateTime billTime, string delegateName, string billNotes, int userID, DataTable dtProductsList)
		{
			SqlParameter[] billParams = new SqlParameter[6];

			billParams[0] = new SqlParameter("@bill_id", SqlDbType.Int);
			billParams[0].Value = billNum;

			billParams[1] = new SqlParameter("@receiver_name", SqlDbType.VarChar, 100);
			billParams[1].Value = delegateName;

			billParams[2] = new SqlParameter("@notes", SqlDbType.VarChar, 200);
			billParams[2].Value = billNotes;

			billParams[3] = new SqlParameter("@user_id", SqlDbType.Int);
			billParams[3].Value = userID;

			billParams[4] = new SqlParameter("@trans_time", SqlDbType.DateTime);
			billParams[4].Value = billTime;

			billParams[5] = new SqlParameter("@transaction_type", SqlDbType.Bit); // sqlCommand.Parameters.Add("@HasPaid", SqlDbType.Bit).Value = hasPaid;
			billParams[5].Value = 1; // might cause a bug

			int emad = dal.excuteCommand("sp_add_new_bill", billParams);
			if (emad != 1) // affected rows = 1, means the bill was created successfully
						   // inform the user (the view) that the bill was not successfully created
				return -1; // -1 is a return value to know at which part the function exited


			//
			// otherwise.. continue (insert the bill units)
			//
			// will not move the following block of code to another function to guarantee ACID principles

			/*
			 * the received datatable (dtProductsList) consists of 3 cols
			 * [1] ==> the product_id
			 * [2] ==> the quantity
			 */

			SqlParameter[] omda = new SqlParameter[4];
			int unitInsertionResult = 1; // will hold the number of affected rows every single iteration
			for (int i = 0; i < dtProductsList.Rows.Count && unitInsertionResult == 1; ++i)
			{
				omda[0] = new SqlParameter("@transaction_id", SqlDbType.Int);
				omda[0].Value = billNum;

				omda[1] = new SqlParameter("@unit_id", SqlDbType.Int);
				int unit_idd = Convert.ToInt32(dtProductsList.Rows[i][0].ToString());
				omda[1].Value = unit_idd; // first column (productID)

				omda[2] = new SqlParameter("@quantity", SqlDbType.Int);
				int qntty = Convert.ToInt32(dtProductsList.Rows[i][1].ToString());
				omda[2].Value = qntty; // second column (quantity)

				omda[3] = new SqlParameter("@transaction_type", SqlDbType.Bit);
				omda[3].Value = 1;

				// the expected return value from this stored proc: 2
				// since this stored proc moifies 2 rows every single call
				//		1- insert the order detail (new row) in table "transaction_units"
				//		2- update "stock_quantity" in table "units"
				int affectedRows = dal.excuteCommand("sp_insert_transaction_items", omda);
				if (affectedRows != 2)
				{
					// this means the number of affected rows != 2, failure happened while insertion or updating the stock
					unitInsertionResult = 5555555;  // random number code.. something bad happened
					break;                          // break from the result and don't continue to insert more products
				}
				

			} // end loop

			if (unitInsertionResult == 1) // nothing bad happened, success with no failures
				return 0; // all units of the bill were created successfully
						  // if something bad happened, undo what was inserted (ACID) principle in database
			else if (unitInsertionResult == 5555555)
			{
				// remove the inserted bill items, from "transaction_units" table
				dal.excuteCommand("delete from transaction_units where transaction_id = " + billNum);

				// then remove the bill itself from "transactions" table
				dal.excuteCommand("delete from transactions where trans_id = " + billNum);

				return -2;// return value for failure after guarantee ACID
			}

			// code will never reach this line, just added it to avoid the (not all code paths have a return)
			return -3;

		}

		#endregion bills


		public SqlDataAdapter getBillReport(int billID)
		{
			SqlParameter[] storedProcParams = new SqlParameter[1];

			storedProcParams[0] = new SqlParameter("@bill_id", SqlDbType.Int);
			storedProcParams[0].Value = billID;

			return dal.selectDataAdapter("sp_get_single_bill_with_units", storedProcParams);
		}

	} // end class
} // end namespace
