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
		

		public frm_listProductsAboutToFinish()
		{
			InitializeComponent();

			SqlDataAdapter daForGridView;// dataadapter used to fill the dataset
			DataTable dt = new DataTable();

			daForGridView = _reportsAndInfo.getLstProductsAboutToFinish(true);
			daForGridView.Fill(dt);
			dataGridView1.DataSource = dt;
			label2.Text = dt.Rows.Count.ToString();

			dataGridView1.Columns[0].Visible = false; // hide the first column (id of the product)
		}

		private void btnPrintList_Click(object sender, EventArgs e)
		{
			dbSchemaAsDataSet ds = new dbSchemaAsDataSet();// object of the database schema typical as the source of the report
			SqlDataAdapter da;// dataadapter used to fill the dataset
			Reports.rpt_productsAboutToFinish r = new Reports.rpt_productsAboutToFinish();  // object of the report
			Reports.frm_crRpt f = new Reports.frm_crRpt();// object of the report viewer form

			if (MessageBox.Show("هل تريد ارفاق المنتجات المنتهية من المخزن ضمن التقرير ؟", "ارفاق المنتجات المنتهية ايضا", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				da = _reportsAndInfo.getLstProductsAboutToFinish(true);
			else
				da = _reportsAndInfo.getLstProductsAboutToFinish();


			da.Fill(ds, "v_get_products_with_details");
			r.Refresh();
			r.SetDataSource(ds);
			f.crystalReportViewer1.ReportSource = r;
			f.Show();
		}
	}
}
