namespace CslaExtensionDemo.WinUI
{
	partial class OrdersListControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersListControl));
			this.orderInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.orderInfoDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpOrderFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpOrderTo = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnFilter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingNavigator)).BeginInit();
			this.orderInfoBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderInfoDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// orderInfoBindingNavigator
			// 
			this.orderInfoBindingNavigator.AddNewItem = null;
			this.orderInfoBindingNavigator.BindingSource = this.orderInfoBindingSource;
			this.orderInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.orderInfoBindingNavigator.DeleteItem = null;
			this.orderInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.btnEdit});
			this.orderInfoBindingNavigator.Location = new System.Drawing.Point(163, 0);
			this.orderInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.orderInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.orderInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.orderInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.orderInfoBindingNavigator.Name = "orderInfoBindingNavigator";
			this.orderInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.orderInfoBindingNavigator.Size = new System.Drawing.Size(356, 25);
			this.orderInfoBindingNavigator.TabIndex = 0;
			this.orderInfoBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// orderInfoDataGridView
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.orderInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.orderInfoDataGridView.AutoGenerateColumns = false;
			this.orderInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.orderInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
			this.orderInfoDataGridView.DataSource = this.orderInfoBindingSource;
			this.orderInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderInfoDataGridView.Location = new System.Drawing.Point(163, 25);
			this.orderInfoDataGridView.Name = "orderInfoDataGridView";
			this.orderInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.orderInfoDataGridView.Size = new System.Drawing.Size(356, 338);
			this.orderInfoDataGridView.TabIndex = 1;
			this.orderInfoDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.orderInfoDataGridView_MouseDoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnFilter);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtCustomer);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtpOrderTo);
			this.panel1.Controls.Add(this.dtpOrderFrom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(163, 363);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DimGray;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Orders";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpOrderFrom
			// 
			this.dtpOrderFrom.Checked = false;
			this.dtpOrderFrom.Location = new System.Drawing.Point(12, 58);
			this.dtpOrderFrom.Name = "dtpOrderFrom";
			this.dtpOrderFrom.ShowCheckBox = true;
			this.dtpOrderFrom.Size = new System.Drawing.Size(133, 21);
			this.dtpOrderFrom.TabIndex = 1;
			// 
			// dtpOrderTo
			// 
			this.dtpOrderTo.Checked = false;
			this.dtpOrderTo.Location = new System.Drawing.Point(12, 107);
			this.dtpOrderTo.Name = "dtpOrderTo";
			this.dtpOrderTo.ShowCheckBox = true;
			this.dtpOrderTo.Size = new System.Drawing.Size(133, 21);
			this.dtpOrderTo.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Order date from:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Order date to:";
			// 
			// txtCustomer
			// 
			this.txtCustomer.Location = new System.Drawing.Point(12, 154);
			this.txtCustomer.Name = "txtCustomer";
			this.txtCustomer.Size = new System.Drawing.Size(133, 21);
			this.txtCustomer.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Customer:";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
			this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID";
			this.dataGridViewTextBoxColumn3.HeaderText = "EmployeeID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
			this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "RequiredDate";
			this.dataGridViewTextBoxColumn5.HeaderText = "RequiredDate";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "ShippedDate";
			this.dataGridViewTextBoxColumn6.HeaderText = "ShippedDate";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "ShipVia";
			this.dataGridViewTextBoxColumn7.HeaderText = "ShipVia";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Freight";
			this.dataGridViewTextBoxColumn8.HeaderText = "Freight";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "ShipName";
			this.dataGridViewTextBoxColumn9.HeaderText = "ShipName";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "ShipAddress";
			this.dataGridViewTextBoxColumn10.HeaderText = "ShipAddress";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "ShipCity";
			this.dataGridViewTextBoxColumn11.HeaderText = "ShipCity";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "ShipRegion";
			this.dataGridViewTextBoxColumn12.HeaderText = "ShipRegion";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "ShipPostalCode";
			this.dataGridViewTextBoxColumn13.HeaderText = "ShipPostalCode";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "ShipCountry";
			this.dataGridViewTextBoxColumn14.HeaderText = "ShipCountry";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.DataPropertyName = "CompanyName";
			this.dataGridViewTextBoxColumn15.HeaderText = "CompanyName";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn16.HeaderText = "Address";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "City";
			this.dataGridViewTextBoxColumn17.HeaderText = "City";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "Region";
			this.dataGridViewTextBoxColumn18.HeaderText = "Region";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "PostalCode";
			this.dataGridViewTextBoxColumn19.HeaderText = "PostalCode";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.DataPropertyName = "Country";
			this.dataGridViewTextBoxColumn20.HeaderText = "Country";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.ReadOnly = true;
			// 
			// orderInfoBindingSource
			// 
			this.orderInfoBindingSource.DataSource = typeof(CslaExtensionDemo.Library.OrderInfo);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 22);
			this.btnEdit.Text = "Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Image = global::CslaExtensionDemo.WinUI.Properties.Resources.view;
			this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFilter.Location = new System.Drawing.Point(15, 192);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(130, 40);
			this.btnFilter.TabIndex = 7;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// OrdersListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.orderInfoDataGridView);
			this.Controls.Add(this.orderInfoBindingNavigator);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Name = "OrdersListControl";
			this.Size = new System.Drawing.Size(519, 363);
			this.Load += new System.EventHandler(this.OrdersListControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingNavigator)).EndInit();
			this.orderInfoBindingNavigator.ResumeLayout(false);
			this.orderInfoBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderInfoDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource orderInfoBindingSource;
		private System.Windows.Forms.BindingNavigator orderInfoBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.DataGridView orderInfoDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpOrderTo;
		private System.Windows.Forms.DateTimePicker dtpOrderFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.Button btnFilter;
	}
}
