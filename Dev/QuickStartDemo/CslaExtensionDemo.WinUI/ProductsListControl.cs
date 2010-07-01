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
	public partial class ProductsListControl : UserControl
	{
		public ProductsListControl()
		{
			InitializeComponent();
		}

		private void ProductsListControl_Load(object sender, EventArgs e)
		{
			productListBindingSource.DataSource= Library.ProductList.GetAll();
		}
	}
}
