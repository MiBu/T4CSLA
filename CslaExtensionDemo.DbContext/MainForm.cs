using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CslaExtensionDemo.DbContext
{
    public partial class MainForm : Form
    {
        NorthwindModel.Products product;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            product = NorthwindModel.Products.Get(1);
            bindingSource1.DataSource = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product.ApplyEdit();
            product.Save();
        }
    }
}
