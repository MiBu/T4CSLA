﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CslaExtensionDemo.WinUI
{
	public partial class MainForm : Form
	{
		OrdersListControl orders;
		CustomersListControl customers;
		ProductsListControl products;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			if (orders == null)
			{
				orders = new OrdersListControl();
			}
			showControl(orders);
		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			if (customers == null)
				customers = new CustomersListControl();
			showControl(customers);
		}

		private void showControl(UserControl control)
		{
			control.Parent = pnlWorkspace;
			control.Dock = DockStyle.Fill;
			control.Show();
			control.BringToFront();
			lblFirstLoad.Visible = false;
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			if (products == null)
				products = new ProductsListControl();
			showControl(products);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
