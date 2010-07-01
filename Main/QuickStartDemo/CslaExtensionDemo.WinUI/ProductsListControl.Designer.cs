namespace CslaExtensionDemo.WinUI
{
	partial class ProductsListControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsListControl));
			this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.productListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.productListDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).BeginInit();
			this.productListBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// productListBindingSource
			// 
			this.productListBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Product);
			// 
			// productListBindingNavigator
			// 
			this.productListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.productListBindingNavigator.BindingSource = this.productListBindingSource;
			this.productListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.productListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.productListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.productListBindingNavigatorSaveItem});
			this.productListBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.productListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.productListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.productListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.productListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.productListBindingNavigator.Name = "productListBindingNavigator";
			this.productListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.productListBindingNavigator.Size = new System.Drawing.Size(493, 25);
			this.productListBindingNavigator.TabIndex = 0;
			this.productListBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// productListBindingNavigatorSaveItem
			// 
			this.productListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.productListBindingNavigatorSaveItem.Enabled = false;
			this.productListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productListBindingNavigatorSaveItem.Image")));
			this.productListBindingNavigatorSaveItem.Name = "productListBindingNavigatorSaveItem";
			this.productListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.productListBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// productListDataGridView
			// 
			this.productListDataGridView.AutoGenerateColumns = false;
			this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
			this.productListDataGridView.DataSource = this.productListBindingSource;
			this.productListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productListDataGridView.Location = new System.Drawing.Point(0, 25);
			this.productListDataGridView.Name = "productListDataGridView";
			this.productListDataGridView.Size = new System.Drawing.Size(493, 352);
			this.productListDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
			this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierID";
			this.dataGridViewTextBoxColumn3.HeaderText = "SupplierID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
			this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
			this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
			this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
			this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder";
			this.dataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel";
			this.dataGridViewTextBoxColumn9.HeaderText = "ReorderLevel";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Discontinued";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// ProductsListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.productListDataGridView);
			this.Controls.Add(this.productListBindingNavigator);
			this.Name = "ProductsListControl";
			this.Size = new System.Drawing.Size(493, 377);
			this.Load += new System.EventHandler(this.ProductsListControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).EndInit();
			this.productListBindingNavigator.ResumeLayout(false);
			this.productListBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productListBindingSource;
		private System.Windows.Forms.BindingNavigator productListBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton productListBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView productListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	}
}
