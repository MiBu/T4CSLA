using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CslaExtensionDemo.WinUI
{
	public partial class CustomersEditForm : Form
	{
		private Library.Customer customer;

		public CustomersEditForm()
		{
			InitializeComponent();
		}

		public static bool Show(Library.Customer customer)
		{
			using (CustomersEditForm fm = new CustomersEditForm())
			{
				fm.customer = customer;
				return fm.ShowDialog() == DialogResult.OK;
			}
		}

		private void CustomersEditForm_Load(object sender, EventArgs e)
		{
			customerBindingSource.DataSource = customer;
		}
	}
}
