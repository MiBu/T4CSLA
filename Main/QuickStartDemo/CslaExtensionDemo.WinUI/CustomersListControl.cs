using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CslaExtensionDemo.WinUI
{
	public partial class CustomersListControl : UserControl
	{
		private Library.CustomerList customers;
		public CustomersListControl()
		{
			InitializeComponent();
		}

		private void CustomersListControl_Load(object sender, EventArgs e)
		{
			customers = Library.CustomerList.GetAll();
			customerBindingSource.DataSource = customers;
		}

		private void customerDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (customerBindingSource.Current != null)
			{
				var customer = (Library.Customer)customerBindingSource.Current;
				CustomersEditForm.Show(customer);
			}
		}
	}
}
