using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emad_Store.Reports
{
	public partial class frm_Reports : Form
	{
		public frm_Reports()
		{
			InitializeComponent();
		}

		private void frm_Reports_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
