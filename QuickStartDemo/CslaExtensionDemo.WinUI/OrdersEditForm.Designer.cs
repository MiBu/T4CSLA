namespace CslaExtensionDemo.WinUI
{
	partial class OrdersEditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label companyNameLabel;
			System.Windows.Forms.Label orderDateLabel;
			System.Windows.Forms.Label requiredDateLabel;
			System.Windows.Forms.Label shippedDateLabel;
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.order_DetailsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboCustomer = new System.Windows.Forms.ComboBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			orderDateLabel = new System.Windows.Forms.Label();
			requiredDateLabel = new System.Windows.Forms.Label();
			shippedDateLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(11, 58);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 1;
			addressLabel.Text = "Address:";
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(11, 84);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 3;
			cityLabel.Text = "City:";
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(11, 31);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 5;
			companyNameLabel.Text = "Company Name:";
			// 
			// orderDateLabel
			// 
			orderDateLabel.AutoSize = true;
			orderDateLabel.Location = new System.Drawing.Point(19, 34);
			orderDateLabel.Name = "orderDateLabel";
			orderDateLabel.Size = new System.Drawing.Size(62, 13);
			orderDateLabel.TabIndex = 7;
			orderDateLabel.Text = "Order Date:";
			// 
			// requiredDateLabel
			// 
			requiredDateLabel.AutoSize = true;
			requiredDateLabel.Location = new System.Drawing.Point(19, 58);
			requiredDateLabel.Name = "requiredDateLabel";
			requiredDateLabel.Size = new System.Drawing.Size(79, 13);
			requiredDateLabel.TabIndex = 9;
			requiredDateLabel.Text = "Required Date:";
			// 
			// shippedDateLabel
			// 
			shippedDateLabel.AutoSize = true;
			shippedDateLabel.Location = new System.Drawing.Point(19, 86);
			shippedDateLabel.Name = "shippedDateLabel";
			shippedDateLabel.Size = new System.Drawing.Size(75, 13);
			shippedDateLabel.TabIndex = 11;
			shippedDateLabel.Text = "Shipped Date:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer.Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(102, 55);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(187, 20);
			this.addressTextBox.TabIndex = 2;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Order);
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer.City", true));
			this.cityTextBox.Location = new System.Drawing.Point(102, 81);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(187, 20);
			this.cityTextBox.TabIndex = 4;
			// 
			// orderDateDateTimePicker
			// 
			this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
			this.orderDateDateTimePicker.Location = new System.Drawing.Point(104, 28);
			this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
			this.orderDateDateTimePicker.Size = new System.Drawing.Size(146, 20);
			this.orderDateDateTimePicker.TabIndex = 8;
			// 
			// requiredDateDateTimePicker
			// 
			this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "RequiredDate", true));
			this.requiredDateDateTimePicker.Location = new System.Drawing.Point(104, 54);
			this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
			this.requiredDateDateTimePicker.Size = new System.Drawing.Size(146, 20);
			this.requiredDateDateTimePicker.TabIndex = 10;
			// 
			// shippedDateDateTimePicker
			// 
			this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ShippedDate", true));
			this.shippedDateDateTimePicker.Location = new System.Drawing.Point(104, 80);
			this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
			this.shippedDateDateTimePicker.Size = new System.Drawing.Size(146, 20);
			this.shippedDateDateTimePicker.TabIndex = 12;
			// 
			// order_DetailsBindingSource
			// 
			this.order_DetailsBindingSource.DataMember = "Order_Details";
			this.order_DetailsBindingSource.DataSource = this.orderBindingSource;
			// 
			// order_DetailsDataGridView
			// 
			this.order_DetailsDataGridView.AutoGenerateColumns = false;
			this.order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.order_DetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Product,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.order_DetailsDataGridView.DataSource = this.order_DetailsBindingSource;
			this.order_DetailsDataGridView.Location = new System.Drawing.Point(12, 149);
			this.order_DetailsDataGridView.Name = "order_DetailsDataGridView";
			this.order_DetailsDataGridView.Size = new System.Drawing.Size(590, 230);
			this.order_DetailsDataGridView.TabIndex = 13;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// Product
			// 
			this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Product.DataPropertyName = "Product";
			this.Product.HeaderText = "Product";
			this.Product.Name = "Product";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
			this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
			this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
			this.dataGridViewTextBoxColumn5.HeaderText = "Discount";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboCustomer);
			this.groupBox1.Controls.Add(this.addressTextBox);
			this.groupBox1.Controls.Add(companyNameLabel);
			this.groupBox1.Controls.Add(this.cityTextBox);
			this.groupBox1.Controls.Add(cityLabel);
			this.groupBox1.Controls.Add(addressLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 121);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer";
			// 
			// cboCustomer
			// 
			this.cboCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "Customer", true));
			this.cboCustomer.DataSource = this.customersBindingSource;
			this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCustomer.FormattingEnabled = true;
			this.cboCustomer.Location = new System.Drawing.Point(102, 27);
			this.cboCustomer.Name = "cboCustomer";
			this.cboCustomer.Size = new System.Drawing.Size(187, 21);
			this.cboCustomer.TabIndex = 7;
			this.cboCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cboCustomer_Validating);
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Customer);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.orderDateDateTimePicker);
			this.groupBox2.Controls.Add(orderDateLabel);
			this.groupBox2.Controls.Add(this.requiredDateDateTimePicker);
			this.groupBox2.Controls.Add(shippedDateLabel);
			this.groupBox2.Controls.Add(requiredDateLabel);
			this.groupBox2.Controls.Add(this.shippedDateDateTimePicker);
			this.groupBox2.Location = new System.Drawing.Point(329, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(273, 121);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dates";
			// 
			// OrdersEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 426);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.order_DetailsDataGridView);
			this.Name = "OrdersEditForm";
			this.Text = "Order";
			this.Load += new System.EventHandler(this.OrdersEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
		private System.Windows.Forms.BindingSource order_DetailsBindingSource;
		private System.Windows.Forms.DataGridView order_DetailsDataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.ComboBox cboCustomer;
		private System.Windows.Forms.BindingSource customersBindingSource;
	}
}