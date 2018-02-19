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



namespace Emad_Store.Views
{
	public partial class frm_mngProducts : Form
	{
		// object of the products controller that control this form
		Controllers.CLS_Products productsController = new Controllers.CLS_Products();

		// priavte object of this form (singleton pattern) (1)
		// I create just one instance of this form to controll it from the (add product form)..
		// after adding a new product, the frm_addNewProduct refreshes this form so it can be controlled just via one instance
		private static frm_mngProducts frm_mngProductsUniqueInstance;

		static void frm_closed(object sender, FormClosedEventArgs e)
		{
			// (2)
			frm_mngProductsUniqueInstance = null;
		}

		// singleton pattern (return just one and only one instance of the class on the runtime) no nultiple instances
		//(3)

		public static frm_mngProducts get_frm_mngProductsUniqueInstance
		{
			get {
				if (frm_mngProductsUniqueInstance == null)
				{
					frm_mngProductsUniqueInstance = new frm_mngProducts();
					frm_mngProductsUniqueInstance.FormClosed += new FormClosedEventHandler(frm_closed);
				}
				return frm_mngProductsUniqueInstance;
			}
		}

		// private constructor, to make it impossible to instanciate this class (except from the getter property above ) (singleton pattern)
		private frm_mngProducts() // set to private (4)
		{
			InitializeComponent();

			// singleton pattern
			//(5)
			if (frm_mngProductsUniqueInstance == null)
				frm_mngProductsUniqueInstance = this;

			// initialize and fill the list
			refreshProductsList();

			// hide the "unit_id" column from the list
			// I could delete this column from the stored procedure but I get it to control the product from the id not from its name or data
			dgvProductsLst.Columns[0].Visible = false;
			dgvProductsLst.Columns[8].Visible = false;

			// categories comboBox
			cmbFilterByCat.DataSource = productsController.getAllCategories();
			cmbFilterByCat.DisplayMember = "cat_name";
			cmbFilterByCat.ValueMember = "cat_id";

		}

		public void refreshProductsList()
		{
			this.dgvProductsLst.DataSource = productsController.getAllProducts();
		}


		// add new product button, shows the form for adding new product "frm_addProduct"
		private void button1_Click(object sender, EventArgs e)
		{
			frm_addProduct f = new frm_addProduct();
			f.ShowDialog();
		}

		// search box, on changing the text inside it, instantly search
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = productsController.searchProduct(textBox1.Text);
			this.dgvProductsLst.DataSource = dt;
		}

		// search box (keydown event)
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			// useless
			textBox1_TextChanged(sender, e);
		}

		private void cmbFilterByCat_SelectedIndexChanged(object sender, EventArgs e)
		{
			//search by the combobox
			textBox1_TextChanged(sender, e);
		}


		private void deleteSlctPrdct_Click(object sender, EventArgs e)
		{
			string prodName = this.dgvProductsLst.CurrentRow.Cells[1].Value.ToString();

			if (MessageBox.Show("هل انت متأكد من حذف " + prodName, prodName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				if (productsController.deleteProduct(Convert.ToInt32(this.dgvProductsLst.CurrentRow.Cells[0].Value.ToString())) > 0)
				{
					lblState.Text = "تم حذف " + prodName + " بنجاح";
					// refresh the datagridView again in case of "Yes" pressed
					refreshProductsList();
				} else
					// should delete the related transactions that associate with this product first in other related DB tables
					lblState.Text = "حدث خطأ اثناء مسح المنتج";
		}

		private void edtSlctdPrdct_Click(object sender, EventArgs e)
		{
			frm_addProduct f = new frm_addProduct();
			f.Text = "تحديث بيانات : " + this.dgvProductsLst.CurrentRow.Cells[1].Value.ToString();
			f.txtProdName.Text = this.dgvProductsLst.CurrentRow.Cells[1].Value.ToString();
			f.txtProductNotes.Text = this.dgvProductsLst.CurrentRow.Cells[4].Value.ToString();
			f.alrtQntnumericUpDown.Value = Convert.ToInt32(this.dgvProductsLst.CurrentRow.Cells[3].Value);
			f.cmbSplrs.Text = this.dgvProductsLst.CurrentRow.Cells[5].Value.ToString();
			f.cmbCats.Text = this.dgvProductsLst.CurrentRow.Cells[6].Value.ToString();
			f.cmbMsrUnt.Text = f.textBox1.Text = this.dgvProductsLst.CurrentRow.Cells[7].Value.ToString();
			f.btnAddProduct.Text = "تحديث";
			
			f.pictureBox1.Image = productImg.Image;

			// change the state of the form to update state, Default state: add
			f._formState = "update";
			f._productIDToUpdt = Convert.ToInt16(this.dgvProductsLst.CurrentRow.Cells[0].Value.ToString());

			f.ShowDialog();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			// get the img from the db, get the first cell in the returned dataTable firstRow[firstColumn]: returned datatable[0][0]
			// then cast the img to arr of bytes[]
			// but img maybe null, so we use "InvalidCastException"
			int productId;
			if (int.TryParse(this.dgvProductsLst.CurrentRow.Cells[0].Value.ToString(), out productId))
			{
				try {

					byte[] prodImg = (byte[])(productsController.getProductImg(productId).Rows[0][0]); // TODO: fix this bug, EMAD
					System.IO.MemoryStream prodImgStrm = new System.IO.MemoryStream(prodImg);
					productImg.Image = Image.FromStream(prodImgStrm);
				}
				catch (InvalidCastException)
				{
					productImg.Image = null;
				} catch (IndexOutOfRangeException)
				{
					productImg.Image = null;
				}
			}
		}

		private void btnUpdtList_Click(object sender, EventArgs e)
		{
			refreshProductsList();
			lblState.Text = "تم تحديث القائمة بنجاح";
		}

		private void prtSlctdPrdct_Click(object sender, EventArgs e)
		{
			// instanciate on object of the crystal report: rpt_single_unit for selected product report
			Reports.rpt_single_unit singleUnitCrystalReport = new Reports.rpt_single_unit();
			//pass the selected product id to the crystal report (the report it self uses a stored procedure in the db with a single parameter "product_id")
			singleUnitCrystalReport.SetParameterValue("@product_id", Convert.ToInt32(this.dgvProductsLst.CurrentRow.Cells[0].Value.ToString()));
			// obj from the form of reports
			Views.frm_reports reportsFrm = new Views.frm_reports();
			//bind the crystal report to the crystal report viewer on the reports form
			reportsFrm.crystalReportViewer1.ReportSource = singleUnitCrystalReport;
			reportsFrm.ShowDialog();


		}

		private void btnPrintAllProducts_Click(object sender, EventArgs e)
		{

			/*using dotnet report viewer*/
			
			//f.reportViewer1.LocalReport.ReportEmbeddedResource


			/*using crystal reports*/

			/*
			// instanciate on object of the crystal report (report for printing all products stored in db "stored proc called get all products")
			Reports.rpt_all_products allProductsCrystalRpt = new Reports.rpt_all_products();
			// obj from the form of reports
			Views.frm_reports reportsFrm = new Views.frm_reports();

			// in case if a change happened in the database, refresh the report
			allProductsCrystalRpt.Refresh();

			//bind the crystal report to the crystal report viewer on the reports form
			reportsFrm.crystalReportViewer1.ReportSource = allProductsCrystalRpt;
			reportsFrm.ShowDialog();
			*/

		}

		// export the report to an excel sheet 
		private void btnExprtExcel_Click(object sender, EventArgs e)
		{

			// todo : fix the save file problem
			try
			{
				lblState.Text = "جاري الحفظ ...";
				Reports.rpt_all_products allProductsCrystalRpt = new Reports.rpt_all_products();

				//create export report options
				ExportOptions exprtOpts = new ExportOptions();

				DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();
				ExcelFormatOptions exlFrmtOps = new ExcelFormatOptions();

				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Title = "حفظ قائمة المنتجات";
				sfd.Filter = "excel files (*.xls)|*.xls|All files (*.*)|*.*";
				sfd.CheckPathExists = true;
				sfd.ShowDialog();

				//MessageBox.Show(sfd.FileName);
				
				dfOptions.DiskFileName = sfd.FileName;
				exprtOpts = allProductsCrystalRpt.ExportOptions;
				exprtOpts.ExportDestinationType = ExportDestinationType.DiskFile;
				exprtOpts.ExportFormatType = ExportFormatType.Excel;
				exprtOpts.ExportFormatOptions = exlFrmtOps;
				exprtOpts.ExportDestinationOptions = dfOptions;

				allProductsCrystalRpt.Export();

				lblState.Text = "تم الحفظ بنجاح";
			} catch (UnauthorizedAccessException)
			{
				MessageBox.Show("ليس لديك صلاحية لحفظ الملف في هذا المسار. من فضلك اختر مسار مختلف","خطا بالصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void bntExprtPDF_Click(object sender, EventArgs e)
		{

			// todo : fix the save file problem (fixed and now works properly) Emad .. Feb 2, 2018
			try
			{
				lblState.Text = "جاري الحفظ ...";
				Reports.rpt_all_products allProductsCrystalRpt = new Reports.rpt_all_products();

				// refresh the report (clear any binded params, if the report was used before and already has a binded param)
				allProductsCrystalRpt.Refresh();
				

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

				exprtOpts = allProductsCrystalRpt.ExportOptions;
				exprtOpts.ExportDestinationType = ExportDestinationType.DiskFile;
				exprtOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
				exprtOpts.ExportFormatOptions = pdfFrmtOps;
				exprtOpts.ExportDestinationOptions = dfOptions;

				allProductsCrystalRpt.Export();

				lblState.Text = "تم الحفظ بنجاح";
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("ليس لديك صلاحية لحفظ الملف في هذا المسار. من فضلك اختر مسار مختلف", "خطا بالصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblState.Text = "..";
			}


		}

	}
}
