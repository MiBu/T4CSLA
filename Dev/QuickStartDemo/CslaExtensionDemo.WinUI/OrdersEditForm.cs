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
		//HACK: DataGridView can't bind to complex properties 
		CustomComboBoxColumn cboProduct = new CustomComboBoxColumn();

		public OrdersEditForm()
		{
			InitializeComponent();

			#region Custom product combo box colum
			cboProduct.Name = "ProductComboBox";
			cboProduct.HeaderText = "Product";
			cboProduct.DataPropertyName = "Product";
			cboProduct.DisplayMember = "ProductName";
			cboProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.order_DetailsDataGridView.Columns.Insert(0, cboProduct);
			#endregion
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
			shippersBindingSource.DataSource = Library.ShippersList.GetAll();
			orderBindingSource.DataSource = order;
			cboProduct.DataSource = Library.ProductList.GetAll().OrderBy(p => p.ProductName).ToArray();

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			orderBindingSource.EndEdit();
			order.Save();
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			order.ShipToCustomer();
		}

	}
}
