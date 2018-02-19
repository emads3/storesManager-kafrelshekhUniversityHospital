using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emad_Store.Views
{
	public partial class frm_addProduct : Form
	{
		// btn "add product" event uses this variable to check whether to call update product or add new product function
		// this variable has a public setter in this cls, Emad , just see below
		string formState = "add";

		// todo: enum instead of strings
		/*
		enum e_formStatus { outProducts, inProducts };
		e_formStatus formState = e_formStatus.outProducts;
		*/

		// in case if (string formState = "update";) this variable is used to be sent to the update product function
		// this variable has a public setter in this cls, Emad
		int productIDToUpdt;

		Controllers.CLS_Products productsController = new Controllers.CLS_Products();
		public frm_addProduct()
		{
			InitializeComponent();

			// categories comboBox
			cmbCats.DataSource = productsController.getAllCategories();
			cmbCats.DisplayMember = "cat_name";
			cmbCats.ValueMember = "cat_id";

			// suppliers comboBox
			cmbSplrs.DataSource = productsController.getAllSuppliers();
			cmbSplrs.DisplayMember = "supp_name";
			cmbSplrs.ValueMember = "supplier_id";

			// measurement units comboBox
			cmbMsrUnt.DataSource = productsController.getMsrentUnits();
			cmbMsrUnt.DisplayMember = "msr_unt_name";
			cmbMsrUnt.ValueMember = "msr_unt_id";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "images_files | *.jpg; *.jpeg; *.png; *gif; *.bmp";
			if (ofd.ShowDialog() == DialogResult.OK)
				pictureBox1.Image = Image.FromFile(ofd.FileName);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}

		private void cmbMsrUnt_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = cmbMsrUnt.Text;
		}


		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			string prodName, notes;
			int supplier_id, cat_id, msr_unt_id, alertQnt;

			// a varible that is changed to false if there is an error with the data
			// check the value of this variable before binding the data to the DB, Emad
			bool validFormData = true;

			// an arrays of bytes to store the image in it
			byte[] byteProdImg = null;
			//using the IO to convert the img to arr of bytes
			{
				if (pictureBox1.Image != null)
				{
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
					pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
					byteProdImg = ms.ToArray();
				}
			}
			
			// get data from the form
			prodName = txtProdName.Text;
			supplier_id = Convert.ToInt32(cmbSplrs.SelectedValue);
			notes = txtProductNotes.Text;
			cat_id = Convert.ToInt32(cmbCats.SelectedValue);
			msr_unt_id = Convert.ToInt32(cmbMsrUnt.SelectedValue);
			alertQnt = Convert.ToInt32(alrtQntnumericUpDown.Value);

			// just for debugging ..
			/*			
			MessageBox.Show("1- prodName" + prodName);
			MessageBox.Show("2- supplier_id" + supplier_id);
			MessageBox.Show("3- notes" + notes);
			MessageBox.Show("4- cat_id" + cat_id);
			MessageBox.Show("5- msr_unt_id" + msr_unt_id);
			*/

			if (prodName == "")
			{
				MessageBox.Show("من فضلك قم بادخال اسم المنتج");
				txtProdName.Focus();
				return;
			}


			// bind the form data to DB
			int emad; // will hold the num of affected rows
			if (this.formState == "add")
			{
				emad = productsController.addProduct(prodName, alertQnt, notes, supplier_id, cat_id, msr_unt_id, byteProdImg);
				if (emad > 0)
				{
					lblState.Text = "تمت اضافة المنتج " + prodName + " بنجاح";
					resetForm();

					// refresh the list after the product addition
					// unique instance of the class (singleton pattern)
					// if the form was opened from the main form, an exception might happen, if opended from a parent form like frm_mngProducts every thing will go smoothly
					// so for this reasom I used exception handling
					try
					{
						frm_mngProducts.get_frm_mngProductsUniqueInstance.refreshProductsList();
					}
					catch
					{
						//
					}
				}

			}
			else if (this.formState == "update")
			{
				bool updateResult = productsController.updtProduct(productIDToUpdt, prodName, alertQnt, notes, supplier_id, cat_id, msr_unt_id, byteProdImg);
				if (updateResult)
				{
					lblState.Text = "تمت تعديل المنتج " + prodName + " بنجاح";

					//refresh the products lst
					// does not work in OOP, bcz this is an instance(another copy) of the class
					// to solve it, I need to to apply the singleton pattern to make sure that there is only one instance of the form
					// big solution later TODO: singleton design Pattern
					// (doneeeeeeeeee) now it's a unique instance of the class "frm_mngProducts"
					frm_mngProducts.get_frm_mngProductsUniqueInstance.refreshProductsList();
				}

			}

		} // end button addProduct / updtProduct



		// setter property for the "productIDToUpdt" to udpate the product
		public int _productIDToUpdt
		{
			set { this.productIDToUpdt = value; }
		}

		// setter property for the "formState" to change the state of the form from add-->update
		// btn add product event uses "formState" to know which function to call (UPDATE or ADD)
		public string _formState
		{
			set { this.formState = value; }
		}
		

		// event to validate if the product name already exists in the DB (not to add duplicate product names)
		private void txtProdName_Validated(object sender, EventArgs e)
		{
			// short circut logical operator, will not even use the function if formState != "add"
			if (txtProdName.Text != "" && formState == "add" && productsController.productExists(txtProdName.Text))
			{
				MessageBox.Show("يوجد منتج اخر بنفس الاسم", "خطأ في اسم المنتج", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtProdName.Focus();
				txtProdName.SelectionStart = 0;
				txtProdName.SelectionLength = txtProdName.TextLength;

			}
		}

		void resetForm()
		{
			txtProdName.Clear();
			alrtQntnumericUpDown.Value = 0;
			pictureBox1.Image = null;
			txtProductNotes.Text = "";
		}

	} // end class form
}
