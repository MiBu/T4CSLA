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

		private void loadData()
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				orders = Library.OrderInfoList.GetAll();
				orderInfoBindingSource.DataSource = orders.OrderBy(o => o.OrderID);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void OrdersListControl_Load(object sender, EventArgs e)
		{
			loadData();
		}

		private void orderInfoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			btnEdit_Click(null, null);
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			if (OrdersEditForm.Show(null))
			{
				loadData();
				orderInfoBindingSource.MoveLast();
			}


		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (orderInfoBindingSource.Current != null)
			{
				int position = orderInfoBindingSource.Position;
				Library.OrderInfo info = (Library.OrderInfo)orderInfoBindingSource.Current;
				if (OrdersEditForm.Show(info.OrderID))
				{
					loadData();
					orderInfoBindingSource.Position = position;
				}
			}

		}
	}
}
