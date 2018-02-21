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

// namespaces used to access the report objects (to change the the headline of the report "rpt_productsAboutToFinish.rpt") which is used many times so we need to change its headline according to the form state
/*
* form states
*	1 ==> products about to finished from the stock (the list include the out of stock products)
*	2 ==> list ot out of stock products
*	3 ==> in stock products
*/
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace Emad_Store.Reports
{
	public partial class frm_listProductsAboutToFinish : Form
	{
		Controllers.CLS_reportsAndInfo _reportsAndInfo = new Controllers.CLS_reportsAndInfo();

		enum formState { productsAboutToFinish, outOfStockProducts, inStockProducts};
		formState fState;
		

		public frm_listProductsAboutToFinish(int iFormState)
		{

			InitializeComponent();

			/*
			 * form states
			 *	1 ==> products about to finished from the stock (the list include the out of stock products)
			 *	2 ==> list ot out of stock products
			 *	3 ==> in stock products
			 */

			if (iFormState == 1)
				fState = formState.productsAboutToFinish;
			else if (iFormState == 2)
				fState = formState.outOfStockProducts;
			else if (iFormState == 3)
				fState = formState.inStockProducts;

			SqlDataAdapter daForGridView = new SqlDataAdapter();// dataAdapter used to fill the dataset
			DataTable dt = new DataTable();

			if (fState == formState.productsAboutToFinish)
			{
				daForGridView = _reportsAndInfo.getLstProductsAboutToFinish();
			}
			else if (fState == formState.outOfStockProducts)
			{
				daForGridView = _reportsAndInfo.getLstOutOfStockProducts();
				label1.Text = "عدد المنتجات المنتهية من المخزن :";// edit the label1 text
				this.Text = "قائمة المنتجات المنتهية من المخزن";
			} else if(fState == formState.inStockProducts)
			{
				daForGridView = _reportsAndInfo.getLstInOfStockProducts();
				label1.Text = "عدد المنتجات الموجودة في المخزن";// edit the label1 text
				this.Text = "قائمة المنتجات الموجودة في المخزن";
			}


			daForGridView.Fill(dt);
			dataGridView1.DataSource = dt;
			lblListRowsCount.Text = dt.Rows.Count.ToString(); // count the list rows and bind it to the label that shows the nummber

			// in case of the form is used to show  "v_get_products_with_details" from the dataset
			// so make some modifications
			if (fState == formState.outOfStockProducts || fState == formState.productsAboutToFinish || fState == formState.inStockProducts)
			{
				dataGridView1.Columns[0].Visible = false; // hide the first column (id of the product)
														  //dataGridView1.Columns[dt.Columns.Count - 1].Visible = false; // hide the last column (id of category)
				dt.Columns.RemoveAt(dt.Columns.Count - 1); // hide the last column (id of category)

				// edit the columns captions, bcz it comes from the dataset in engish heasers
				dt.Columns[1].ColumnName = "اسم المنتج - الدواء";
				dt.Columns[2].ColumnName = "الكمية الموجودة";
				dt.Columns[3].ColumnName = "تحذير الانتهاء";
				dt.Columns[4].ColumnName = "وحدة القياس";
				dt.Columns[5].ColumnName = "وصف المنتج";
				dt.Columns[6].ColumnName = "اسم المورد";
				dt.Columns[7].ColumnName = "التصنيف";
				//dt.Columns[7].Caption = "التصنيف";
			}


		}

		private void btnPrintList_Click(object sender, EventArgs e)
		{
			dbSchemaAsDataSet ds = new dbSchemaAsDataSet();// object of the database schema typical as the source of the report
			SqlDataAdapter da = new SqlDataAdapter();// dataadapter used to fill the dataset
			stockStatusReports.rpt_productsAboutToFinish r = new stockStatusReports.rpt_productsAboutToFinish();  // object of the report
			Reports.frm_crRpt f = new Reports.frm_crRpt();// object of the report viewer form


			// to change the text report headline according to the formsate
			CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
			txtReportHeader = r.ReportDefinition.ReportObjects["txtHeadLine"] as TextObject;


			if (fState == formState.productsAboutToFinish)
			{
				DialogResult dr = MessageBox.Show("هل تريد ارفاق المنتجات المنتهية من المخزن ضمن التقرير ؟", "ارفاق المنتجات المنتهية ايضا", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

				if (dr == DialogResult.Yes)
					da = _reportsAndInfo.getLstProductsAboutToFinish(true);
				else if(dr == DialogResult.No) // did't use if..else bcz the user might press cancel
					da = _reportsAndInfo.getLstProductsAboutToFinish();

				f.Text = "تقرير المنتجات التي قاربت علي الانتهاء من المخزن";//change the form title

			} else if(fState == formState.outOfStockProducts)
			{
				da = _reportsAndInfo.getLstOutOfStockProducts();
				f.Text = "تقرير بالمنتجات المنتهية من المخزن";
				txtReportHeader.Text = "تقرير بالمنتجات المنتهية من المخزن";
			} else if(fState == formState.inStockProducts)
			{
				da = _reportsAndInfo.getLstInOfStockProducts();
				f.Text = "تقرير جرد المنتجات الموجودة بالمخزن";
				txtReportHeader.Text = "تقرير جرد المنتجات الموجودة في المخزن";
			}

			da.Fill(ds, "v_get_products_with_details");
			r.Refresh();
			r.SetDataSource(ds);
			f.crystalReportViewer1.ReportSource = r;
			f.Show();
		}
	}
}
