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
	public partial class OrdersEditForm : Form
	{
		private Library.Order order;

		public OrdersEditForm()
		{
			InitializeComponent();
		}

		public static bool Show(int? orderID)
		{
			using (OrdersEditForm fm = new OrdersEditForm())
			{
				if (orderID.HasValue)
				{
					fm.order = Library.Order.Get(orderID.Value);
				}
				else
				{
					fm.order = Library.Order.New();
				}

				return fm.ShowDialog() == DialogResult.OK;
			}
		}

		private void OrdersEditForm_Load(object sender, EventArgs e)
		{
			customersBindingSource.DataSource = Library.CustomerList.GetAll();
			orderBindingSource.DataSource = order;
		}

		private void cboCustomer_Validating(object sender, CancelEventArgs e)
		{
		}
	}
}
