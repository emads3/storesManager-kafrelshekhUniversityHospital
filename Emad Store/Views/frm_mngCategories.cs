using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


//for crystal report to export as excel
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Emad_Store.Views
{
	public partial class frm_mngCategories : Form
	{
		Controllers.CLS_Categories catController = new Controllers.CLS_Categories();
		DataTable dt;
		BindingManagerBase bmb; // using currenct manager


		public frm_mngCategories()
		{
			InitializeComponent();

			// initialize the list
			refreshList();

			// hide the first column (id column) of the dataGridView
			this.dataGridView1.Columns[0].Visible = false;
	
		}

		private void refreshList()
		{
			// bind the categories from the controller to the dataGridView on the form to display all the categories
			dt = catController.getAllCategories();
			this.dataGridView1.DataSource = dt;

			// clear the bindings
			// without these two lines, if the "refreshList()" is called twice, this will create a bug (add binding again)
			// so the solution is to first clear the already existing binding and then create new one
			txtCatName.DataBindings.Clear();
			txtCatNotes.DataBindings.Clear();

			// bind data to txtBox name of cat & txtBox description of category
			txtCatName.DataBindings.Add("text", dt, "cat_name");
			txtCatNotes.DataBindings.Add("text", dt, "notes");
			

			// using currenct manager
			bmb = this.BindingContext[dt];

			// using currenct manager
			lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

		}
		
		private void btnFrstCat_Click(object sender, EventArgs e)
		{
			// using currenct manager
			bmb.Position = 0;
			lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

		}

		private void btnLstCat_Click(object sender, EventArgs e)
		{
			// using currenct manager
			bmb.Position = bmb.Count;
			lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
		}

		private void btnPrevCat_Click(object sender, EventArgs e)
		{
			// using currenct manager
			bmb.Position -= 1;
			lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
		}

		private void btnNxtCat_Click(object sender, EventArgs e)
		{
			// using currenct manager
			bmb.Position += 1;
			lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
		}


		#region events of somebuttons (جديد - اضافة - حذف - تعديل)
		/*
		private void btnFrmtFrm2AddNewCat_Click(object sender, EventArgs e)
		{
			bmb.AddNew();
			btnFrmtFrm2AddNewCat.Enabled = false;
			btnAddNewCat.Enabled = true;
			txtCatName.Focus();
		}

		private void btnAddNewCat_Click(object sender, EventArgs e)
		{
			bmb.EndCurrentEdit();
			if (catController.addNewCategory(txtCatName.Text, dt) == 1)
			{
				lblState.Text = "تم اضافة التصنيف: " + " بنجاح";
				btnAddNewCat.Enabled = false;
				btnFrmtFrm2AddNewCat.Enabled = true;

				// refresh the position label after addition process
				lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
			}
			

		}

		private void btnDelSlctd_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("هل انت متأكد من حذف التصنيف المحدد ؟", "حذف !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				bmb.RemoveAt(bmb.Position);
				bmb.EndCurrentEdit();

				// refresh the position label after deletion process
				lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

				if (catController.deleteUpdateCategory(dt) == 1)
					lblState.Text = "تم حذف التصنيف بنجاح";
			}
		}

		private void btnUpdateSelected_Click(object sender, EventArgs e)
		{
			if (catController.deleteUpdateCategory(dt) == 1)
				lblState.Text = "تم التحديث بنجاح";
		}
		*/
		#endregion events of somebuttons (جديد - اضافة - حذف - تعديل)

		private void btnAddNewCat_Click(object sender, EventArgs e)
		{
			new frm_addCategory().ShowDialog();
		}

		private void btnRefreshLst_Click(object sender, EventArgs e)
		{
			refreshList();
		}

		private void btnDelSlctd_Click(object sender, EventArgs e)
		{
			//TODO: bug here, if there are any products under this category, delete it
			int catID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
			string catName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
			if (MessageBox.Show("هل انت متأكد من حذف التصنيف " + catName + " ?", "تأكيد حذف التصنيف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				if (catController.deleteCategory(catID) == 1)
				{
					lblState.Text = "تم حذف التصنيف بنجاح";
					refreshList();
				}
				else
					lblState.Text = "حدث خطأ اثناء حذف التصنيف من فضلك راجع مبرمج البرنامج";
		}

		private void btnUpdateSelected_Click(object sender, EventArgs e)
		{
			//TODO: validate the name (if it exist before adding the new one)
			int catID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
			string newCateName = txtCatName.Text;
			string newCatDesc = txtCatNotes.Text;

			if (catController.updateCategory(catID, newCateName, newCatDesc) == 1)
			{
				lblState.Text = "تم تحديث التصنيف";
				refreshList();
			}
			else
				lblState.Text = "حدث خطأ اثناء تحديث بيانات التصنيف";
		}

		private void prtSlctCat_Click(object sender, EventArgs e)
		{
			// instanciate on object of the crystal report (report for printing all products stored in db "stored proc called get all products")
			Reports.rpt_singleCategoryProducts rptSingleCatProducts= new Reports.rpt_singleCategoryProducts();
			// obj from the form of reports
			Views.frm_reports reportsFrm = new Views.frm_reports();

			// refresh the sub report
			new Reports.rpt_all_products().Refresh();

			// refresh the report in case if a change has made in the database
			rptSingleCatProducts.Refresh();

			rptSingleCatProducts.SetParameterValue("@cat_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

			//bind the crystal report to the crystal report viewer on the reports form
			reportsFrm.crystalReportViewer1.ReportSource = rptSingleCatProducts;
			reportsFrm.ShowDialog();
		}

		private void saveCatsProdsToPdf_Click(object sender, EventArgs e)
		{

			// todo : fix the save file problem (fixed and now works properly) Emad .. Feb 2, 2018
			try
			{
				lblState.Text = "جاري الحفظ ...";
				this.Cursor = Cursors.WaitCursor;
				Reports.rpt_singleCategoryProducts rpt_singleCatProducts = new Reports.rpt_singleCategoryProducts();

				// refresh the report (clear any binded params, if the report was used before and already has a binded param)
				rpt_singleCatProducts.Refresh();

				// bind the category_ID param to the report
				rpt_singleCatProducts.SetParameterValue("@cat_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

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

				exprtOpts = rpt_singleCatProducts.ExportOptions;
				exprtOpts.ExportDestinationType = ExportDestinationType.DiskFile;
				exprtOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
				exprtOpts.ExportFormatOptions = pdfFrmtOps;
				exprtOpts.ExportDestinationOptions = dfOptions;

				

				rpt_singleCatProducts.Export();

				lblState.Text = "تم الحفظ بنجاح";
				this.Cursor = Cursors.Default;
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("ليس لديك صلاحية لحفظ الملف في هذا المسار. من فضلك اختر مسار مختلف", "خطا بالصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblState.Text = "..";
			}

		}

		private void txtCatName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				txtCatNotes.Focus();
		}

		private void prtAllCats_Click(object sender, EventArgs e)
		{

		}
	} // end form
}
