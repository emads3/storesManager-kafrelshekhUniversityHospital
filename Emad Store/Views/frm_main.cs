using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// remove these namespaces (just for reports) and i will move the reports code to another layer
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Emad_Store.Views
{
	public partial class frm_main : Form
	{
		Controllers.CLS_reportsAndInfo _reportsAndInfo = new Controllers.CLS_reportsAndInfo();

		private static frm_main _instance;

		static void frm_FormClosed(object sender, FormClosedEventArgs e)
		{
			// for security purposes
			// dispose the form object on closing the form, just to make sure that no other forms are using this object
			_instance = null;
		}

		// to make sure it's unique instance (singleton desPattern)
		public static frm_main getMainFormInstance // TODO: see that function again
		{
			get
			{
				if(_instance == null)
				{
					_instance = new frm_main();
					_instance.FormClosed += new FormClosedEventHandler(frm_FormClosed);
				}
				return _instance;
			}
		}


		public frm_main() // private constructor (singleton desPattern)
		{
			InitializeComponent();

			if (_instance == null)
				_instance = this;

			//file, prodcuts, users
			this.productsToolStripMenuItem.Enabled = false;
			this.usersToolStripMenuItem.Enabled = false;
			this.backUpDbToolStripMenuItem.Enabled = false;
			this.restoreDbBackupToolStripMenuItem.Enabled = false;

			// used to update the textbox of current time and date
			Timer tmr;
			// timer to update the txt_dateTime textbox
			tmr = new Timer();
			tmr.Interval = 1000;
			tmr.Tick += tmr_Tick;
			tmr.Enabled = true;




		}

		void tmr_Tick(object sender, EventArgs e)
		{
			txtTimeDate.Text = DateTime.Now.ToString();
		}

		private void دخولToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_login frm = new frm_login();
			frm.ShowDialog();
		}

		private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_addProduct f = new frm_addProduct();
			f.ShowDialog();
		}

		private void productsMngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// dones not work after applying the singleton pattern
			/*
			frm_mngProducts f = new frm_mngProducts();
			f.ShowDialog();
			*/
			//it was a singleton pattern but now not used
			frm_mngProducts f = frm_mngProducts.get_frm_mngProductsUniqueInstance;
			f.ShowDialog();
			//frm_mngProducts.get_frm_mngProductsUniqueInstance.ShowDialog();
		}

		private void mngCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_mngCategories f = new frm_mngCategories();
			f.ShowDialog();
		}

		private void frm_main_Load(object sender, EventArgs e)
		{
			frm_login frm = new frm_login();
			frm.ShowDialog();
		}

		private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// default parameter of constructor "outProducts"
			
			new frm_outProducts().ShowDialog();
		}

		private void fillStockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_outProducts("inProducts").ShowDialog();
			
		}

		private void backUpDbToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog() != DialogResult.OK)
				return;

			string bkupPath = fbd.SelectedPath;

			Controllers.CLS_Settings settingsObj = new Controllers.CLS_Settings();
			MessageBox.Show(Convert.ToString(settingsObj.backUpDB(bkupPath)));

		}

		private void dbSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_DbSettings().ShowDialog();
		}

		private void rptProductsAboutToFinishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Models.DataAcessLayer dal = new Models.DataAcessLayer();
			SqlDataAdapter da = dal.selectDataAdapter("select * from v_get_products_with_details where stock_quantity <= alert_quantity");
			//Reports.DataSet1 ds = new Reports.DataSet1();
			dbSchemaAsDataSet ds = new dbSchemaAsDataSet();
			da.Fill(ds, "v_get_products_with_details");
			Reports.deleteThisReport r = new Reports.deleteThisReport();
			r.Refresh();
			r.SetDataSource(ds);
			Reports.frm_crRpt f = new Reports.frm_crRpt();
			f.crystalReportViewer1.ReportSource = r;
			f.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			// fill the dataset, bind the Report1.rdlc to the form report viewer
			// fill the dataset, lec 108
			// bind the report to the report viewer
			//https://stackoverflow.com/questions/9929336/dynamically-binding-report-to-reportviewer-component


			//TODO : uncomment this
			Views.frm_reports f = new Views.frm_reports();


			Controllers.CLS_dbSettings _dbConnectionSettings = new Controllers.CLS_dbSettings();
			SqlConnection sqlCon;
			/* edited prepared one */
			string[] dbServerInfo = _dbConnectionSettings.getDBserverInfo();
			string dbServerName = dbServerInfo[0]; //"(LocalDB)\\MSSQLLocalDB";
			string dbName = dbServerInfo[1]; //"C:\\Users\bolli\\documents\\visual studio 2015\\Projects\\Emad Store\\Emad Store\\kfs_hospital.mdf";
			string authMode = dbServerInfo[2]; //"Windows";
			string dbUsername = dbServerInfo[3]; //"temporary username";
			string dbPasswd = dbServerInfo[4]; //"temp password";

			f.crystalReportViewer1.RefreshReport();

			//f.Show();


		}

		private void button2_Click(object sender, EventArgs e)
		{

			// instanciate on object of the crystal report (report for printing all products stored in db "stored proc called get all products")
			Reports.rpt_singleCategoryProducts rptSingleCatProducts = new Reports.rpt_singleCategoryProducts();
			// obj from the form of reports
			Views.frm_reports reportsFrm = new Views.frm_reports();

			// refresh the sub report
			new Reports.rpt_all_products().Refresh();

			// refresh the report in case if a change has made in the database
			rptSingleCatProducts.Refresh();

			rptSingleCatProducts.SetParameterValue("@cat_id", 1);

			//bind the crystal report to the crystal report viewer on the reports form
			reportsFrm.crystalReportViewer1.ReportSource = rptSingleCatProducts;
			reportsFrm.ShowDialog();
		}
	}
}
