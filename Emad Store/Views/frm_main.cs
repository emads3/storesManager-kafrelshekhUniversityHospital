﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// remove these namespaces (just for reports) and i will move the reports code to another layer
using System.Data.Sql;
using System.Data.SqlClient;


namespace Emad_Store.Views
{
	public partial class frm_main : Form
	{
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
		

		private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_addProduct f = new frm_addProduct();
			f.ShowDialog();
		}
		

		private void mngCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_mngCategories f = new frm_mngCategories();
			f.ShowDialog();
		}

		private void frm_main_Load(object sender, EventArgs e)
		{
			//new frm_login().ShowDialog();
			//fillMainScreenInfo();//moved this function to session control
			
		}

		public void fillMainScreenInfo()
		{

			Controllers.CLS_reportsAndInfo _reportsAndInfo = new Controllers.CLS_reportsAndInfo();

			// TODO :: add a condition to make this visible only for allowed users
			Views.frm_main.getMainFormInstance.txtNumOfProductsOutOfStock.Text = _reportsAndInfo.getNumOfOutOfStockProducts();
			Views.frm_main.getMainFormInstance.txtNumProductsAboutToFinish.Text = _reportsAndInfo.getNumOfProductsAboutToFinish();
			Views.frm_main.getMainFormInstance.txtNumOfBills.Text = _reportsAndInfo.getNumOfRegisteredBills();
			Views.frm_main.getMainFormInstance.txtNumOfProductsInStock.Text = _reportsAndInfo.getNumOfUnitsInStock();
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
			new Reports.frm_listProductsAboutToFinish(1).Show();
		}

		private void outOfStockProductsReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Reports.frm_listProductsAboutToFinish(2).Show();
		}

		private void inStockProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Reports.frm_listProductsAboutToFinish(3).Show();
		}

		private void lblRefresh_Click(object sender, EventArgs e)
		{
			fillMainScreenInfo();
		}

		private void aboutTheAppToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_aboutUs().ShowDialog();
		}

		private void changeUserPasswdToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_changeUserPasswd().ShowDialog();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_login frm = new frm_login();
			frm.ShowDialog();
		}

		private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_addUser().ShowDialog();
		}

		private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_addSupplier().ShowDialog();
		}

		private void mngProductsCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frm_mngProducts().ShowDialog();
		}

		private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_mngProducts f = new frm_mngProducts();

			// hide some useless info from the form
			// note that the same form is used to manage the products (CRUD)
			// but I used it here just to view and list the products (after hiding the buttons and disable them)
			// also resize the form after hiding the its operation buttons
			f.Size = new System.Drawing.Size(986, 473);     /* resize the form */
			f.gbOperations.Visible = false;                 /* hide the buttons in group box */
			f.lblState.Visible = false;                     /* hide the state label */

			f.Show();                                       /* show the form after modifying its layout and view, EMAD */
		}
	}
}
