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
	public partial class OrdersListControl : UserControl
	{
		private Library.OrderInfoList orders;
		public OrdersListControl()
		{
			InitializeComponent();
		}

		private void OrdersListControl_Load(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				orders = Library.OrderInfoList.GetAll();
				orderInfoBindingSource.DataSource = orders;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void orderInfoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (orderInfoBindingSource.Current != null)
			{
				Library.OrderInfo info = (Library.OrderInfo)orderInfoBindingSource.Current;
				OrdersEditForm.Show(info.OrderID);
			}
		}
	}
}
