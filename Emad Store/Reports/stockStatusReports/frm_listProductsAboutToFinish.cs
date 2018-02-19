/*
 * TODO : the database view used in this list gets the name of the supplier, later add the phone number of the supplier to make it easy for the user to call the supplier
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace Emad_Store.Reports
{
	public partial class frm_listProductsAboutToFinish : Form
	{
		Controllers.CLS_reportsAndInfo _reportsAndInfo = new Controllers.CLS_reportsAndInfo();

		enum formState { productsAboutToFinish, outOfStockProducts};
		formState fState;
		

		public frm_listProductsAboutToFinish(int iFormState)
		{

			InitializeComponent();

			/*
			 * form states
			 *	1 ==> products about to finished from the stock (the list include the out of stock products)
			 *	2 ==> list ot out of stock products
			 */

			if (iFormState == 1)
				fState = formState.productsAboutToFinish;
			else if (iFormState == 2)
				fState = formState.outOfStockProducts;

			SqlDataAdapter daForGridView = new SqlDataAdapter();// dataAdapter used to fill the dataset
			DataTable dt = new DataTable();

			if (fState == formState.productsAboutToFinish)
			{
				daForGridView = _reportsAndInfo.getLstProductsAboutToFinish(true);
			}
			else if (fState == formState.outOfStockProducts)
			{
				daForGridView = _reportsAndInfo.getLstOutOfStockProducts();
				label1.Text = "عدد المنتجات المنهية من المخزن :";// edit the label1 text
				this.Text = "قائمة المنتجات المنهية من المخزن";
			}


			daForGridView.Fill(dt);
			dataGridView1.DataSource = dt;
			lblListRowsCount.Text = dt.Rows.Count.ToString(); // count the list rows and bind it to the label that shows the nummber

			// in case of the form is used to show  "v_get_products_with_details" from the dataset
			// so make some modifications
			if (fState == formState.outOfStockProducts || fState == formState.productsAboutToFinish)
			{
				dataGridView1.Columns[0].Visible = false; // hide the first column (id of the product)

				// edit the columns captions, bcz it comes from the dataset in engish heasers
				dt.Columns[1].ColumnName = "اسم المنتج - الدواء";
				dt.Columns[2].ColumnName = "الكميلة الموجودة";
				dt.Columns[6].ColumnName = "اسم المورد";
				dt.Columns[7].Caption = "التصنيف";
			}


		}

		private void btnPrintList_Click(object sender, EventArgs e)
		{
			dbSchemaAsDataSet ds = new dbSchemaAsDataSet();// object of the database schema typical as the source of the report
			SqlDataAdapter da = new SqlDataAdapter();// dataadapter used to fill the dataset
			stockStatusReports.rpt_productsAboutToFinish r = new stockStatusReports.rpt_productsAboutToFinish();  // object of the report
			Reports.frm_crRpt f = new Reports.frm_crRpt();// object of the report viewer form

			if (fState == formState.productsAboutToFinish)
			{
				if (MessageBox.Show("هل تريد ارفاق المنتجات المنتهية من المخزن ضمن التقرير ؟", "ارفاق المنتجات المنتهية ايضا", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					da = _reportsAndInfo.getLstProductsAboutToFinish(true);
				else
					da = _reportsAndInfo.getLstProductsAboutToFinish();
			} else if(fState == formState.outOfStockProducts)
			{
				da = _reportsAndInfo.getLstOutOfStockProducts();
			}

			da.Fill(ds, "v_get_products_with_details");
			r.Refresh();
			r.SetDataSource(ds);
			f.crystalReportViewer1.ReportSource = r;
			f.Show();
		}
	}
}
