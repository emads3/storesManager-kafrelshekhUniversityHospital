using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Emad_Store.Controllers
{
	class CLS_Categories
	{
		Models.DataAcessLayer dal = new Models.DataAcessLayer();



		// u can remove this region (contains many bugs with its methods)
		#region immediate editing using dataBinding;
		/*
		SqlDataAdapter da;
		DataTable dt;

		// return a datatable of all categories
		public DataTable getAllCategories()
		{
			da = dal.immediateEditTbl("select * from categories");
			dt = new DataTable();
			da.Fill(dt);
			return dal.selectData("select * from categories");
		}
		


		// I just need the name to validate existence not to insert the name, bcz I don't insert names,..
		// I just update the table with the dataAdapter
		public int addNewCategory(string catName, DataTable dt)
		{
			if (catName == "")
				return -1; // code means that the cat exists, check on this code in the view
			else if (catExists(catName))
				return -2; // code means that the category name already exists
			else
				return dal.immediateEditTbl(dt,da);
		}


		public int deleteUpdateCategory(DataTable dt)
		{
			return dal.immediateEditTbl(dt, da);
		}
		*/
		#endregion immediate editing using dataBinding

		public bool catExists(string catName)
		{
			DataTable dt = dal.selectData("select * from categories where cat_name = '" + catName + "'");
			if (dt.Rows.Count > 0)
				return true;
			return false;
		}


		// returns a dataTable contains all the stored categories in the database
		public DataTable getAllCategories()
		{
			return dal.selectData("select * from categories");
		}


		// add new category with stored procedure
		public int addNewCat(string catName, string catDescription)
		{
			SqlParameter[] param = new SqlParameter[2];

			param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 200);
			param[0].Value = catName;

			param[1] = new SqlParameter("@notes", SqlDbType.VarChar, 200);
			param[1].Value = catDescription;

			return dal.excuteCommand("add_new_category", param);
		}


		/// <summary>
		/// delete category
		/// </summary>
		/// <param name="catID">category id to delete it</param>
		/// <returns>1 if category deleted successfully</returns>
		public int deleteCategory(int catID)
		{
			return dal.excuteCommand("delete from categories where cat_id = " + catID);
		}

		/// <summary>
		/// update categoey info
		/// </summary>
		/// <param name="catId">int: the id of the category to update</param>
		/// <param name="newcatName">the new name to be updated type: string</param>
		/// <param name="newCatDesc">the new description to be updated type:string</param>
		/// <returns></returns>
		public int updateCategory(int catId, string newcatName, string newCatDesc)
		{
			return dal.excuteCommand("update categories set cat_name = '" + newcatName + "', notes = '" + newCatDesc + "' where cat_id = " + catId);
		}


		public bool categoryExists(string catName)
		{
			DataTable dt = dal.selectData("select * from categories where cat_name = '" + catName + "'");
			if (dt.Rows.Count > 0)
				return true;
			return false;
		}


	}
}
