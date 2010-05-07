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
			System.Windows.Forms.Label companyNameLabel;
			System.Windows.Forms.Label orderDateLabel;
			System.Windows.Forms.Label requiredDateLabel;
			System.Windows.Forms.Label shippedDateLabel;
			System.Windows.Forms.Label shipNameLabel;
			System.Windows.Forms.Label shipAddressLabel;
			System.Windows.Forms.Label shipPostalCodeLabel;
			System.Windows.Forms.Label shipCountryLabel;
			System.Windows.Forms.Label shipRegionLabel;
			System.Windows.Forms.Label shipViaLabel;
			System.Windows.Forms.Label freightLabel;
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.order_DetailsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.freightTextBox = new System.Windows.Forms.TextBox();
			this.cboCustomer = new System.Windows.Forms.ComboBox();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.shipRegionTextBox = new System.Windows.Forms.TextBox();
			this.shipCountryTextBox = new System.Windows.Forms.TextBox();
			this.shipCityTextBox = new System.Windows.Forms.TextBox();
			this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
			this.shipAddressTextBox = new System.Windows.Forms.TextBox();
			this.shipNameTextBox = new System.Windows.Forms.TextBox();
			companyNameLabel = new System.Windows.Forms.Label();
			orderDateLabel = new System.Windows.Forms.Label();
			requiredDateLabel = new System.Windows.Forms.Label();
			shippedDateLabel = new System.Windows.Forms.Label();
			shipNameLabel = new System.Windows.Forms.Label();
			shipAddressLabel = new System.Windows.Forms.Label();
			shipPostalCodeLabel = new System.Windows.Forms.Label();
			shipCountryLabel = new System.Windows.Forms.Label();
			shipRegionLabel = new System.Windows.Forms.Label();
			shipViaLabel = new System.Windows.Forms.Label();
			freightLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(11, 27);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(57, 13);
			companyNameLabel.TabIndex = 5;
			companyNameLabel.Text = "Customer:";
			// 
			// orderDateLabel
			// 
			orderDateLabel.AutoSize = true;
			orderDateLabel.Location = new System.Drawing.Point(11, 54);
			orderDateLabel.Name = "orderDateLabel";
			orderDateLabel.Size = new System.Drawing.Size(65, 13);
			orderDateLabel.TabIndex = 7;
			orderDateLabel.Text = "Order Date:";
			// 
			// requiredDateLabel
			// 
			requiredDateLabel.AutoSize = true;
			requiredDateLabel.Location = new System.Drawing.Point(11, 80);
			requiredDateLabel.Name = "requiredDateLabel";
			requiredDateLabel.Size = new System.Drawing.Size(80, 13);
			requiredDateLabel.TabIndex = 9;
			requiredDateLabel.Text = "Required Date:";
			// 
			// shippedDateLabel
			// 
			shippedDateLabel.AutoSize = true;
			shippedDateLabel.Location = new System.Drawing.Point(11, 106);
			shippedDateLabel.Name = "shippedDateLabel";
			shippedDateLabel.Size = new System.Drawing.Size(75, 13);
			shippedDateLabel.TabIndex = 11;
			shippedDateLabel.Text = "Shipped Date:";
			// 
			// shipNameLabel
			// 
			shipNameLabel.AutoSize = true;
			shipNameLabel.Location = new System.Drawing.Point(10, 27);
			shipNameLabel.Name = "shipNameLabel";
			shipNameLabel.Size = new System.Drawing.Size(38, 13);
			shipNameLabel.TabIndex = 0;
			shipNameLabel.Text = "Name:";
			// 
			// shipAddressLabel
			// 
			shipAddressLabel.AutoSize = true;
			shipAddressLabel.Location = new System.Drawing.Point(10, 53);
			shipAddressLabel.Name = "shipAddressLabel";
			shipAddressLabel.Size = new System.Drawing.Size(50, 13);
			shipAddressLabel.TabIndex = 2;
			shipAddressLabel.Text = "Address:";
			// 
			// shipPostalCodeLabel
			// 
			shipPostalCodeLabel.AutoSize = true;
			shipPostalCodeLabel.Location = new System.Drawing.Point(10, 79);
			shipPostalCodeLabel.Name = "shipPostalCodeLabel";
			shipPostalCodeLabel.Size = new System.Drawing.Size(30, 13);
			shipPostalCodeLabel.TabIndex = 4;
			shipPostalCodeLabel.Text = "City:";
			// 
			// shipCountryLabel
			// 
			shipCountryLabel.AutoSize = true;
			shipCountryLabel.Location = new System.Drawing.Point(10, 105);
			shipCountryLabel.Name = "shipCountryLabel";
			shipCountryLabel.Size = new System.Drawing.Size(50, 13);
			shipCountryLabel.TabIndex = 7;
			shipCountryLabel.Text = "Country:";
			// 
			// shipRegionLabel
			// 
			shipRegionLabel.AutoSize = true;
			shipRegionLabel.Location = new System.Drawing.Point(10, 131);
			shipRegionLabel.Name = "shipRegionLabel";
			shipRegionLabel.Size = new System.Drawing.Size(44, 13);
			shipRegionLabel.TabIndex = 9;
			shipRegionLabel.Text = "Region:";
			// 
			// shipViaLabel
			// 
			shipViaLabel.AutoSize = true;
			shipViaLabel.Location = new System.Drawing.Point(10, 157);
			shipViaLabel.Name = "shipViaLabel";
			shipViaLabel.Size = new System.Drawing.Size(25, 13);
			shipViaLabel.TabIndex = 11;
			shipViaLabel.Text = "Via:";
			// 
			// freightLabel
			// 
			freightLabel.AutoSize = true;
			freightLabel.Location = new System.Drawing.Point(11, 132);
			freightLabel.Name = "freightLabel";
			freightLabel.Size = new System.Drawing.Size(45, 13);
			freightLabel.TabIndex = 11;
			freightLabel.Text = "Freight:";
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Order);
			// 
			// orderDateDateTimePicker
			// 
			this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
			this.orderDateDateTimePicker.Location = new System.Drawing.Point(102, 50);
			this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
			this.orderDateDateTimePicker.Size = new System.Drawing.Size(139, 21);
			this.orderDateDateTimePicker.TabIndex = 1;
			// 
			// requiredDateDateTimePicker
			// 
			this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "RequiredDate", true));
			this.requiredDateDateTimePicker.Location = new System.Drawing.Point(102, 77);
			this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
			this.requiredDateDateTimePicker.Size = new System.Drawing.Size(139, 21);
			this.requiredDateDateTimePicker.TabIndex = 2;
			// 
			// shippedDateDateTimePicker
			// 
			this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ShippedDate", true));
			this.shippedDateDateTimePicker.Location = new System.Drawing.Point(102, 103);
			this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
			this.shippedDateDateTimePicker.Size = new System.Drawing.Size(139, 21);
			this.shippedDateDateTimePicker.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.order_DetailsDataGridView.DataSource = this.order_DetailsBindingSource;
			this.order_DetailsDataGridView.Location = new System.Drawing.Point(12, 206);
			this.order_DetailsDataGridView.Name = "order_DetailsDataGridView";
			this.order_DetailsDataGridView.Size = new System.Drawing.Size(678, 179);
			this.order_DetailsDataGridView.TabIndex = 2;
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
			this.groupBox1.Controls.Add(freightLabel);
			this.groupBox1.Controls.Add(this.freightTextBox);
			this.groupBox1.Controls.Add(this.orderDateDateTimePicker);
			this.groupBox1.Controls.Add(orderDateLabel);
			this.groupBox1.Controls.Add(this.cboCustomer);
			this.groupBox1.Controls.Add(this.requiredDateDateTimePicker);
			this.groupBox1.Controls.Add(companyNameLabel);
			this.groupBox1.Controls.Add(shippedDateLabel);
			this.groupBox1.Controls.Add(this.shippedDateDateTimePicker);
			this.groupBox1.Controls.Add(requiredDateLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 188);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Order details";
			// 
			// freightTextBox
			// 
			this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Freight", true));
			this.freightTextBox.Location = new System.Drawing.Point(102, 129);
			this.freightTextBox.Name = "freightTextBox";
			this.freightTextBox.Size = new System.Drawing.Size(139, 21);
			this.freightTextBox.TabIndex = 12;
			// 
			// cboCustomer
			// 
			this.cboCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "Customer", true));
			this.cboCustomer.DataSource = this.customersBindingSource;
			this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCustomer.FormattingEnabled = true;
			this.cboCustomer.Location = new System.Drawing.Point(102, 23);
			this.cboCustomer.Name = "cboCustomer";
			this.cboCustomer.Size = new System.Drawing.Size(230, 21);
			this.cboCustomer.TabIndex = 0;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Customer);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.DataSource = this.orderBindingSource;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(611, 391);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(529, 391);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Controls.Add(shipViaLabel);
			this.groupBox3.Controls.Add(shipRegionLabel);
			this.groupBox3.Controls.Add(this.shipRegionTextBox);
			this.groupBox3.Controls.Add(shipCountryLabel);
			this.groupBox3.Controls.Add(this.shipCountryTextBox);
			this.groupBox3.Controls.Add(this.shipCityTextBox);
			this.groupBox3.Controls.Add(shipPostalCodeLabel);
			this.groupBox3.Controls.Add(this.shipPostalCodeTextBox);
			this.groupBox3.Controls.Add(shipAddressLabel);
			this.groupBox3.Controls.Add(this.shipAddressTextBox);
			this.groupBox3.Controls.Add(shipNameLabel);
			this.groupBox3.Controls.Add(this.shipNameTextBox);
			this.groupBox3.Location = new System.Drawing.Point(356, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(333, 188);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ship To";
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "Shipper", true));
			this.comboBox1.DataSource = this.shippersBindingSource;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(72, 154);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(248, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// shippersBindingSource
			// 
			this.shippersBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Shippers);
			// 
			// shipRegionTextBox
			// 
			this.shipRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipRegion", true));
			this.shipRegionTextBox.Location = new System.Drawing.Point(72, 128);
			this.shipRegionTextBox.Name = "shipRegionTextBox";
			this.shipRegionTextBox.Size = new System.Drawing.Size(248, 21);
			this.shipRegionTextBox.TabIndex = 5;
			// 
			// shipCountryTextBox
			// 
			this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipCountry", true));
			this.shipCountryTextBox.Location = new System.Drawing.Point(72, 102);
			this.shipCountryTextBox.Name = "shipCountryTextBox";
			this.shipCountryTextBox.Size = new System.Drawing.Size(248, 21);
			this.shipCountryTextBox.TabIndex = 4;
			// 
			// shipCityTextBox
			// 
			this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipCity", true));
			this.shipCityTextBox.Location = new System.Drawing.Point(146, 76);
			this.shipCityTextBox.Name = "shipCityTextBox";
			this.shipCityTextBox.Size = new System.Drawing.Size(174, 21);
			this.shipCityTextBox.TabIndex = 3;
			// 
			// shipPostalCodeTextBox
			// 
			this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipPostalCode", true));
			this.shipPostalCodeTextBox.Location = new System.Drawing.Point(72, 76);
			this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
			this.shipPostalCodeTextBox.Size = new System.Drawing.Size(67, 21);
			this.shipPostalCodeTextBox.TabIndex = 2;
			// 
			// shipAddressTextBox
			// 
			this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipAddress", true));
			this.shipAddressTextBox.Location = new System.Drawing.Point(72, 50);
			this.shipAddressTextBox.Name = "shipAddressTextBox";
			this.shipAddressTextBox.Size = new System.Drawing.Size(248, 21);
			this.shipAddressTextBox.TabIndex = 1;
			// 
			// shipNameTextBox
			// 
			this.shipNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShipName", true));
			this.shipNameTextBox.Location = new System.Drawing.Point(72, 24);
			this.shipNameTextBox.Name = "shipNameTextBox";
			this.shipNameTextBox.Size = new System.Drawing.Size(248, 21);
			this.shipNameTextBox.TabIndex = 0;
			// 
			// OrdersEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(698, 426);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.order_DetailsDataGridView);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Name = "OrdersEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Order";
			this.Load += new System.EventHandler(this.OrdersEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
		private System.Windows.Forms.BindingSource order_DetailsBindingSource;
		private System.Windows.Forms.DataGridView order_DetailsDataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.ComboBox cboCustomer;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox shipCountryTextBox;
		private System.Windows.Forms.TextBox shipCityTextBox;
		private System.Windows.Forms.TextBox shipPostalCodeTextBox;
		private System.Windows.Forms.TextBox shipAddressTextBox;
		private System.Windows.Forms.TextBox shipNameTextBox;
		private System.Windows.Forms.TextBox shipRegionTextBox;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource shippersBindingSource;
		private System.Windows.Forms.TextBox freightTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}