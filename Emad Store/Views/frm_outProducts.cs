/*
 * TODO :: add another button to the export groupbox to show the details of the bill in another form containg the a datagridView like the one in "stockStatusReports"
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

//for crystal report to export as excel
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

// used for sqlDataAdapter
using System.Data.SqlClient;

/*
 * TODO: later,,,
 * 1- add a feature to add multiple items to the bill list at once directly from the frm_mngProducts
 *		-Add context menu strip to that form from the parent form, select multiple with control button then r.click >> add to bill list
 * 2- enable multiple select in frm_mngProducts to add multiple products directly
 */

namespace Emad_Store.Views
{
	public partial class frm_outProducts : Form
	{
		// this form is used to add products to the stock
		//		and to get products out
		// the default mode : out products, so to use it to fill the stock some modifications to the form are made (from the caller form)
		//string _formStatus;
		enum e_formStatus {outProducts, inProducts};
		e_formStatus formState = e_formStatus.outProducts;

		// this form is used in this form to select products to be added to the bill
		frm_mngProducts f;

		Controllers.CLS_Products productsController = new Controllers.CLS_Products();

		DataTable dt = new DataTable();

		int productID /*used when binding from the productsList form to this form*/;

		// used to update the textbox of current time and date to show the user the date of the bill
		Timer tmr;

		public frm_outProducts(string sFormStatusParam = "outProducts")
		{
			// status of the form

			if (sFormStatusParam == "outProducts")
				formState = e_formStatus.outProducts;
			else if (sFormStatusParam == "inProducts")
				formState = e_formStatus.inProducts;

			InitializeComponent();

			// bind the name of the username to the textbox in this form
			txtUsername.Text = Controllers.CLS_RuntimeInfo.getInstance.fullUserName;

			if (formState == e_formStatus.outProducts)
			{
				//get all departments comboBox
				cmbDeparments.DataSource = productsController.getAllDeparments();
				cmbDeparments.DisplayMember = "dept_name";
				cmbDeparments.ValueMember = "dept_id";
			}
			else if(formState == e_formStatus.inProducts) // hide textbox of receiver name and the combobox
			{
				label5.Text = "اسم المندوب :";

				label10.Enabled = false;
				label10.Visible = false;

				cmbDeparments.Enabled = false;
				cmbDeparments.Visible = false;

				this.Text = "اضافة ادوية الي المخزن";
			}

			// get the latest bill number... the new bill number will be latestBillNumber + 1
			txtNewBillNum.Text = (productsController.getLatestBillNumber() + 1).ToString();

			

			// inialize the column of the bill list
			dt.Columns.Add(); // thie first column for id
			dt.Columns.Add("اسم الدواء او الصنف");
			dt.Columns.Add("الكمية");

			dataGridView1.DataSource = dt;
			// TODO: uncommecnt it (commented just for debugging)
			dataGridView1.Columns[0].Visible = false; // remove the first column (used for productID)

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

		// edit the "frm_mngProducts" layout and show it
		private void btnSelectProduct_Click(object sender, EventArgs e)
		{
			//TODO: if user clicked twice on the show dialog of browse products



			// object of the form (frm_mngProducts) to show products for the user to select products from it
			// in order to fill a bill with roducts
			// I assign an instance to "f" variable bcz if the form was closed, the ojbect is disposed and the functions of the form would not work again
			// including the event that handles
			f = frm_mngProducts.get_frm_mngProductsUniqueInstance;


			// attach an event from the form (frm_mngProducts) to this eventHandler (which exist in this form -frm_outProducts)
			//f.dgvProductsLst.SelectionChanged += bindDataFromProductsListToOutProductsForm;
			f.dgvProductsLst.DoubleClick += bindDataFromProductsListToOutProductsForm;

			// hide some useless info from the form
			// note that the same form is used to manage the products (CRUD)
			// but I used it here just to view and list the products (after hiding the buttons and disable them)
			// also resize the form after hiding the its operation buttons
			f.Size = new System.Drawing.Size(986, 473);     /* resize the form */
			f.gbOperations.Visible = false;                 /* hide the buttons in group box */
			f.lblState.Visible = false;                     /* hide the state label */
			try
			{
				f.Show();                                       /* show the form after modifying its layout and view, EMAD */
			}
			//after closing the form, the object is disposed, means that f = null, so showing the form again after disposing it requires reinitializing it
			catch (ObjectDisposedException)
			{
				f.Show();
			}
		}


		/*
		 * this is en event that handles the selection change in the dialog form
		 * when the user change the selection of the selected product, bind the data of the selected..
		 * row from the dataGridView to the frm_OutProducts textBoxes and sooo
		 */
		void bindDataFromProductsListToOutProductsForm(object sender, EventArgs e)
		{
			// TODO: fix a bug
			//MessageBox.Show("emad");

			// to add products to the list, there must be an enough quantity in the stock (just in the state of outProducts)
			// bcz in the state of the inProducts we don't need that
			if(Convert.ToInt32(f.dgvProductsLst.CurrentRow.Cells[2].Value) <= 0 && formState == e_formStatus.outProducts)
			{
				MessageBox.Show("لا يوجد مخزون من هذا الدواء. لا يمكن اخراجه", "لا يوجد مخزون", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // end the eventHandler don't bind the rest of data
			}


			// deny the user from adding over quantity than the quantity the is stored in the stock
			// set the maximum quantity of this product to (number of sotred units in the stock)
			if (formState == e_formStatus.outProducts) // // just in the state of (outProducts)
				numUpDwnQntty.Maximum = Convert.ToInt32(f.dgvProductsLst.CurrentRow.Cells[2].Value);

			// copy the name of the product form the dataGridView in the frm_mngProducts to the txtProdName in the in the frm_OutProducts
			txtProdName.Text = f.dgvProductsLst.CurrentRow.Cells[1].Value.ToString();

			// bind the prodcutID to the productID field inside this class (to be used later)
			productID = Convert.ToInt16(f.dgvProductsLst.CurrentRow.Cells[0].Value.ToString());
		}

		private void btnAddProductToBillLst_Click(object sender, EventArgs e)
		{
			// don't add empty products to the 
			if (txtProdName.Text == string.Empty)
			{
				MessageBox.Show("خطأ باسم المنتج. قم باختيار منتج من القائمة عن طريق الضغط علي زر ...", "اسم المنتج خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // end the event handler (don't add anything to the list)
			}

			// note that this piece of code (the followin 2 lines "else if" will never work), (added for security purposes)
			// bcz if there is not enough quantity, txtProductName textbox will be empty,
			// so the eventHandler will be termintaed (return in the previos 2 lines) before even reching this line
			else if (numUpDwnQntty.Value < 1)
			{
				MessageBox.Show("اختار علي الاقل كمية واحدة", "الكمية المطلوبة خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // end the event handler (don't add anything to the list)
			}

			// if the user added an alraedy added product to the list
			// loop and find if the product_id was added before or not
			int omda = 0;
			bool foundDuplicated = false;
			for(int i = 0; i < dataGridView1.Rows.Count; ++i)
				// if added before
				if(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()) == productID)
				{
					omda = i;
					foundDuplicated = true;
					break;
				}

			if (foundDuplicated)
			{
				int quantityInList = Convert.ToInt32(dataGridView1.Rows[omda].Cells[2].Value.ToString());

				if (formState == e_formStatus.outProducts)// just in the state of (outProducts)
				{
					bool changeLblState = true;
					if (Convert.ToInt32(numUpDwnQntty.Value) + quantityInList > Convert.ToInt32(numUpDwnQntty.Maximum))
					{
						quantityInList = Convert.ToInt32(numUpDwnQntty.Maximum);
						lblState.Text = "الكمية المحددة اكبر من الكمية الموجودة بالمخزن. تم اضافة كل الكمية الموجودة بالمخزن الي القائمة";
						changeLblState = false;
					}

					dataGridView1.Rows[omda].Cells[2].Value = quantityInList;

					if (changeLblState)// not to change the state and override the previous msg quickly
						lblState.Text = "المنتج مضاف من قبل الي القائمة.. تم زيادة الكمية المحددة";
					
				}
				else if (formState == e_formStatus.inProducts)
				{
					dataGridView1.Rows[omda].Cells[2].Value = quantityInList + Convert.ToInt32(numUpDwnQntty.Value);
					lblState.Text = "المنتج مضاف من قبل الي القائمة.. تم زيادة الكمية المحددة";
				}
				
				clearBoxes();

				return; // end the function
			}

			// if the event handler not terminated so .. go through the following

			// after validation .....
			//add to list

			DataRow r = dt.NewRow();
			r[0] = productID;
			r[1] = txtProdName.Text;
			r[2] = numUpDwnQntty.Value;

			if (productID != 0)
			{
				dt.Rows.Add(r);
				lblState.Text = "تم اضافة " + txtProdName.Text + " الي القائمة";
			}

			clearBoxes();

		}

		//reset the boxes and update the total quantity and some other trivial stuff, EMAD
		void clearBoxes()
		{
			txtProdName.Clear();
			productID = 0;
			numUpDwnQntty.Value = 1;
			btnSelectProduct.Focus();
			updateTotalQuantity();
		}

		void updateTotalQuantity()
		{
			txtSumQntts.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[2].FormattedValue.ToString() != string.Empty select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
		}

		//pressing enter in the numericUpDown quantity
		private void numUpDwnQntty_KeyDown(object sender, KeyEventArgs e)
		{
			// pressing enter == pressing the button add
			if (e.KeyCode == Keys.Enter)
				btnAddProductToBillLst_Click(null, null);

		}

		private void bntDeleteSlctProd_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count > 0)
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

			updateTotalQuantity();
		}

		private void bntNewBill_Click(object sender, EventArgs e)
		{
			RestForm4NewBill();
		}

		void RestForm4NewBill()
		{
			//dt.Rows.Clear();
			dt.Clear();
			dataGridView1.Refresh();
			numUpDwnQntty.Value = 1;
			txtProdName.Clear();
			txtNewBillNum.Text = (productsController.getLatestBillNumber() + 1).ToString();
			txtReceiverName.Clear();
			bntSaveBill.Enabled = true;
			gbExportBill.Enabled = false;
			lblState.Text = "";
		}
		

		private void bntSaveBill_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count < 1)
			{
				lblState.Text = "لا يمكن حفظ فاتورة فارغه. من فضلك اضف بعض الادوية";
				return;
			}

			// collecting bill data from the form
			string receiverName = txtReceiverName.Text;						// the name of the guy who will recieve the bill
			string billNotes = txtBillNotes.Text;							// notes and details of bill
			int userID = Controllers.CLS_RuntimeInfo.getInstance.userID;    // id of the current logged in user
			int departmentID = Convert.ToInt32(cmbDeparments.SelectedValue);    // id of the department that will receive that item
			int billNum = Convert.ToInt32(txtNewBillNum.Text);              // bill number

			// validate the receiver name (just in case of outProducts)
			if(receiverName == string.Empty && formState == e_formStatus.outProducts)
			{
				MessageBox.Show("يجب ادخال اسم الشخص المستلم للادوات", "اسم المستلم", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtReceiverName.Focus();
				return;
			}


			// get the list of the products added to the datagridview
			// the copy here is copy by reference
			// so modifying the "billProductsList" will affect the original "dataGridView1.DataSource"
			// that's why we use .Copy() function
			// without it, removing any column from the "billProductsList" will affect the original datatable and the datatable will affect the dataGridView
			DataTable billProductsList = ((DataTable)dataGridView1.DataSource).Copy();

			// remove the prodcut_name column (we need just its ID)
			billProductsList.Columns.RemoveAt(1);


			// just for debugging
			/*
			MessageBox.Show(billProductsList.Rows[0][1].ToString());
			return;
			*/
			int resultReturnValue = -10;
			if (formState == e_formStatus.outProducts)
				//send bill info including a list of the bill products with details to controller
				resultReturnValue = productsController.createNewBillOutProducts(billNum, DateTime.Now, receiverName, billNotes, userID, departmentID, billProductsList);
			else if(formState == e_formStatus.inProducts)
				//send bill info including a list of the bill products with details to controller
				resultReturnValue = productsController.createNewBillInProducts(billNum, DateTime.Now, receiverName, billNotes, userID, billProductsList);

			if (resultReturnValue == 0) // on success (function returned 0)
			{
				bntSaveBill.Enabled = false; // disable the save button, not to allow the user to enable it again
				gbExportBill.Enabled = true; //after successfully saving the bill, enable the expoert & print bill options
				lblState.Text = "تم حفظ الفاتورة بنجاح. يمكنك الان طباعتها او تصديرها";
				dt.Clear();
				dataGridView1.Refresh();
			}
			else
				lblState.Text = "حدث خطأ رقم " + resultReturnValue + "لم يتم حفظ الفاتورة من فضلك كلم عماد ";


		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			clearBoxes();

			if (dataGridView1.Rows.Count > 0)
			{
				productID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				txtProdName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				numUpDwnQntty.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString());
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
			}
			
		}

		private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			
		}

		private void editRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGridView1_DoubleClick(sender, e); // bug, calls clear rows and deletes the product id, I guess
		}

		private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dt.Clear();
			dataGridView1.Refresh();
		}

		private void deleteCrntRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bntDeleteSlctProd_Click(sender, e);
		}

		private void bntExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bntPrintBill_Click(object sender, EventArgs e)
		{

			// TODO:
			//
			//جرب تغير الكونكشن بتاعة الداتا بيز


			if(formState == e_formStatus.outProducts)
			{
				Cursor = Cursors.WaitCursor;
				dbSchemaAsDataSet ds = new Emad_Store.dbSchemaAsDataSet();// object of the database schema typical as the source of the report
				SqlDataAdapter da = new SqlDataAdapter();// dataadapter used to fill the dataset
				Reports.inOutStockBills.rpt_printSingleBill r = new Reports.inOutStockBills.rpt_printSingleBill();// object of the report

				da = productsController.getBillReport(Convert.ToInt32(txtNewBillNum.Text));
				da.Fill(ds, "sv_get_all_bills_with_units");
				r.Refresh();
				r.SetDataSource(ds);
				Reports.frm_crRpt f = new Reports.frm_crRpt();// object of the report viewer form
				f.crystalReportViewer1.ReportSource = r;
				f.Show();
				Cursor = Cursors.Default;


				/*
				Cursor = Cursors.WaitCursor;
				// instanciate on object of the crystal report (report for printing all products stored in db "stored proc called get all products")
				Reports.rpt_printSingleBill rptSingleBill = new Reports.rpt_printSingleBill();
				// obj from the form of reports
				Views.frm_reports reportsFrm = new Views.frm_reports();

				// refresh the sub report
				new Reports.rpt_printSingleBill().Refresh();

				// refresh the report in case if a change has made in the database
				rptSingleBill.Refresh();

				rptSingleBill.SetParameterValue("@bill_id", Convert.ToInt32(txtNewBillNum.Text));

				//bind the crystal report to the crystal report viewer on the reports form
				reportsFrm.crystalReportViewer1.ReportSource = rptSingleBill;
				Cursor = Cursors.Default;
				reportsFrm.ShowDialog();
				*/
			}
		}

		private void bntSaveBillAsExl_Click(object sender, EventArgs e)
		{
			/*
			Cursor = Cursors.WaitCursor;
			if (formState == e_formStatus.outProducts)
			{
				// todo : fix the save file problem
				try
				{
					lblState.Text = "جاري الحفظ ...";
					Reports.rpt_printSingleBill rptSingleBill = new Reports.rpt_printSingleBill();

					//create export report options
					ExportOptions exprtOpts = new ExportOptions();

					DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
					ExcelFormatOptions exlFrmtOps = new ExcelFormatOptions();

					// refresh the report (clear any binded params, if the report was used before and already has a binded param)
					rptSingleBill.Refresh();

					rptSingleBill.SetParameterValue("@bill_id", Convert.ToInt32(txtNewBillNum.Text));

					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Title = "حفظ قائمة المنتجات";
					sfd.Filter = "excel files (*.xls)|*.xls|All files (*.*)|*.*";
					sfd.CheckPathExists = true;
					sfd.ShowDialog();


					dfOptions.DiskFileName = sfd.FileName;
					exprtOpts = rptSingleBill.ExportOptions;
					exprtOpts.ExportDestinationType = ExportDestinationType.DiskFile;
					exprtOpts.ExportFormatType = ExportFormatType.Excel;
					exprtOpts.ExportFormatOptions = exlFrmtOps;
					exprtOpts.ExportDestinationOptions = dfOptions;

					rptSingleBill.Export();

					lblState.Text = "تم الحفظ بنجاح";
				}
				catch (UnauthorizedAccessException)
				{
					MessageBox.Show("ليس لديك صلاحية لحفظ الملف في هذا المسار. من فضلك اختر مسار مختلف", "خطا بالصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} // end export for out products
			else if(formState == e_formStatus.inProducts)
			{

			}
			Cursor = Cursors.Default;
			*/
		}

		private void bntSaveBillAsPDF_Click(object sender, EventArgs e)
		{
			/*
			if(formState == e_formStatus.outProducts)
			{
				try
				{
					lblState.Text = "جاري الحفظ ...";
					Reports.rpt_printSingleBill rptSingleBill = new Reports.rpt_printSingleBill();

					// refresh the report (clear any binded params, if the report was used before and already has a binded param)
					rptSingleBill.Refresh();

					rptSingleBill.SetParameterValue("@bill_id", Convert.ToInt32(txtNewBillNum.Text));


					//create export report options
					ExportOptions exprtOpts = new ExportOptions();

					DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
					PdfFormatOptions pdfFrmtOps = new PdfFormatOptions();

					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Title = "حفظ قائمة المنتجات";
					sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
					sfd.CheckPathExists = true;
					sfd.ShowDialog();

					//MessageBox.Show(sfd.FileName);

					// bind the result "address of file as a string" to the dfOptions object of (DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();)
					dfOptions.DiskFileName = sfd.FileName;

					exprtOpts = rptSingleBill.ExportOptions;
					exprtOpts.ExportDestinationType = ExportDestinationType.DiskFile;
					exprtOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
					exprtOpts.ExportFormatOptions = pdfFrmtOps;
					exprtOpts.ExportDestinationOptions = dfOptions;

					rptSingleBill.Export();

					lblState.Text = "تم الحفظ بنجاح";
				}
				catch (UnauthorizedAccessException)
				{
					MessageBox.Show("ليس لديك صلاحية لحفظ الملف في هذا المسار. من فضلك اختر مسار مختلف", "خطا بالصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
					lblState.Text = "..";
				}
			}//end form sate out products
			*/
		}
	}
}
