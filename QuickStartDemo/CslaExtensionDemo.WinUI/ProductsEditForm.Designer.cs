namespace CslaExtensionDemo.WinUI
{
	partial class ProductsEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsEditForm));
			System.Windows.Forms.Label categoryIDLabel;
			System.Windows.Forms.Label discontinuedLabel;
			System.Windows.Forms.Label productIDLabel;
			System.Windows.Forms.Label productNameLabel;
			System.Windows.Forms.Label quantityPerUnitLabel;
			System.Windows.Forms.Label reorderLevelLabel;
			System.Windows.Forms.Label supplierIDLabel;
			System.Windows.Forms.Label unitPriceLabel;
			System.Windows.Forms.Label unitsInStockLabel;
			System.Windows.Forms.Label unitsOnOrderLabel;
			this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.productListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.categoryIDTextBox = new System.Windows.Forms.TextBox();
			this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
			this.productIDTextBox = new System.Windows.Forms.TextBox();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
			this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
			this.supplierIDTextBox = new System.Windows.Forms.TextBox();
			this.unitPriceTextBox = new System.Windows.Forms.TextBox();
			this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
			this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
			categoryIDLabel = new System.Windows.Forms.Label();
			discontinuedLabel = new System.Windows.Forms.Label();
			productIDLabel = new System.Windows.Forms.Label();
			productNameLabel = new System.Windows.Forms.Label();
			quantityPerUnitLabel = new System.Windows.Forms.Label();
			reorderLevelLabel = new System.Windows.Forms.Label();
			supplierIDLabel = new System.Windows.Forms.Label();
			unitPriceLabel = new System.Windows.Forms.Label();
			unitsInStockLabel = new System.Windows.Forms.Label();
			unitsOnOrderLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).BeginInit();
			this.productListBindingNavigator.SuspendLayout();
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
			this.productListBindingNavigator.Size = new System.Drawing.Size(505, 25);
			this.productListBindingNavigator.TabIndex = 0;
			this.productListBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// categoryIDLabel
			// 
			categoryIDLabel.AutoSize = true;
			categoryIDLabel.Location = new System.Drawing.Point(46, 57);
			categoryIDLabel.Name = "categoryIDLabel";
			categoryIDLabel.Size = new System.Drawing.Size(66, 13);
			categoryIDLabel.TabIndex = 1;
			categoryIDLabel.Text = "Category ID:";
			// 
			// categoryIDTextBox
			// 
			this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "CategoryID", true));
			this.categoryIDTextBox.Location = new System.Drawing.Point(142, 54);
			this.categoryIDTextBox.Name = "categoryIDTextBox";
			this.categoryIDTextBox.Size = new System.Drawing.Size(283, 20);
			this.categoryIDTextBox.TabIndex = 2;
			// 
			// discontinuedLabel
			// 
			discontinuedLabel.AutoSize = true;
			discontinuedLabel.Location = new System.Drawing.Point(46, 85);
			discontinuedLabel.Name = "discontinuedLabel";
			discontinuedLabel.Size = new System.Drawing.Size(72, 13);
			discontinuedLabel.TabIndex = 3;
			discontinuedLabel.Text = "Discontinued:";
			// 
			// discontinuedCheckBox
			// 
			this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productListBindingSource, "Discontinued", true));
			this.discontinuedCheckBox.Location = new System.Drawing.Point(142, 80);
			this.discontinuedCheckBox.Name = "discontinuedCheckBox";
			this.discontinuedCheckBox.Size = new System.Drawing.Size(283, 24);
			this.discontinuedCheckBox.TabIndex = 4;
			this.discontinuedCheckBox.Text = "checkBox1";
			this.discontinuedCheckBox.UseVisualStyleBackColor = true;
			// 
			// productIDLabel
			// 
			productIDLabel.AutoSize = true;
			productIDLabel.Location = new System.Drawing.Point(46, 113);
			productIDLabel.Name = "productIDLabel";
			productIDLabel.Size = new System.Drawing.Size(61, 13);
			productIDLabel.TabIndex = 5;
			productIDLabel.Text = "Product ID:";
			// 
			// productIDTextBox
			// 
			this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "ProductID", true));
			this.productIDTextBox.Location = new System.Drawing.Point(142, 110);
			this.productIDTextBox.Name = "productIDTextBox";
			this.productIDTextBox.Size = new System.Drawing.Size(283, 20);
			this.productIDTextBox.TabIndex = 6;
			// 
			// productNameLabel
			// 
			productNameLabel.AutoSize = true;
			productNameLabel.Location = new System.Drawing.Point(46, 139);
			productNameLabel.Name = "productNameLabel";
			productNameLabel.Size = new System.Drawing.Size(78, 13);
			productNameLabel.TabIndex = 7;
			productNameLabel.Text = "Product Name:";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "ProductName", true));
			this.productNameTextBox.Location = new System.Drawing.Point(142, 136);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(283, 20);
			this.productNameTextBox.TabIndex = 8;
			// 
			// quantityPerUnitLabel
			// 
			quantityPerUnitLabel.AutoSize = true;
			quantityPerUnitLabel.Location = new System.Drawing.Point(46, 165);
			quantityPerUnitLabel.Name = "quantityPerUnitLabel";
			quantityPerUnitLabel.Size = new System.Drawing.Size(90, 13);
			quantityPerUnitLabel.TabIndex = 9;
			quantityPerUnitLabel.Text = "Quantity Per Unit:";
			// 
			// quantityPerUnitTextBox
			// 
			this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "QuantityPerUnit", true));
			this.quantityPerUnitTextBox.Location = new System.Drawing.Point(142, 162);
			this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
			this.quantityPerUnitTextBox.Size = new System.Drawing.Size(283, 20);
			this.quantityPerUnitTextBox.TabIndex = 10;
			// 
			// reorderLevelLabel
			// 
			reorderLevelLabel.AutoSize = true;
			reorderLevelLabel.Location = new System.Drawing.Point(46, 191);
			reorderLevelLabel.Name = "reorderLevelLabel";
			reorderLevelLabel.Size = new System.Drawing.Size(77, 13);
			reorderLevelLabel.TabIndex = 11;
			reorderLevelLabel.Text = "Reorder Level:";
			// 
			// reorderLevelTextBox
			// 
			this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "ReorderLevel", true));
			this.reorderLevelTextBox.Location = new System.Drawing.Point(142, 188);
			this.reorderLevelTextBox.Name = "reorderLevelTextBox";
			this.reorderLevelTextBox.Size = new System.Drawing.Size(283, 20);
			this.reorderLevelTextBox.TabIndex = 12;
			// 
			// supplierIDLabel
			// 
			supplierIDLabel.AutoSize = true;
			supplierIDLabel.Location = new System.Drawing.Point(46, 217);
			supplierIDLabel.Name = "supplierIDLabel";
			supplierIDLabel.Size = new System.Drawing.Size(62, 13);
			supplierIDLabel.TabIndex = 13;
			supplierIDLabel.Text = "Supplier ID:";
			// 
			// supplierIDTextBox
			// 
			this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "SupplierID", true));
			this.supplierIDTextBox.Location = new System.Drawing.Point(142, 214);
			this.supplierIDTextBox.Name = "supplierIDTextBox";
			this.supplierIDTextBox.Size = new System.Drawing.Size(283, 20);
			this.supplierIDTextBox.TabIndex = 14;
			// 
			// unitPriceLabel
			// 
			unitPriceLabel.AutoSize = true;
			unitPriceLabel.Location = new System.Drawing.Point(46, 243);
			unitPriceLabel.Name = "unitPriceLabel";
			unitPriceLabel.Size = new System.Drawing.Size(56, 13);
			unitPriceLabel.TabIndex = 15;
			unitPriceLabel.Text = "Unit Price:";
			// 
			// unitPriceTextBox
			// 
			this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "UnitPrice", true));
			this.unitPriceTextBox.Location = new System.Drawing.Point(142, 240);
			this.unitPriceTextBox.Name = "unitPriceTextBox";
			this.unitPriceTextBox.Size = new System.Drawing.Size(283, 20);
			this.unitPriceTextBox.TabIndex = 16;
			// 
			// unitsInStockLabel
			// 
			unitsInStockLabel.AutoSize = true;
			unitsInStockLabel.Location = new System.Drawing.Point(46, 269);
			unitsInStockLabel.Name = "unitsInStockLabel";
			unitsInStockLabel.Size = new System.Drawing.Size(77, 13);
			unitsInStockLabel.TabIndex = 17;
			unitsInStockLabel.Text = "Units In Stock:";
			// 
			// unitsInStockTextBox
			// 
			this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "UnitsInStock", true));
			this.unitsInStockTextBox.Location = new System.Drawing.Point(142, 266);
			this.unitsInStockTextBox.Name = "unitsInStockTextBox";
			this.unitsInStockTextBox.Size = new System.Drawing.Size(283, 20);
			this.unitsInStockTextBox.TabIndex = 18;
			// 
			// unitsOnOrderLabel
			// 
			unitsOnOrderLabel.AutoSize = true;
			unitsOnOrderLabel.Location = new System.Drawing.Point(46, 295);
			unitsOnOrderLabel.Name = "unitsOnOrderLabel";
			unitsOnOrderLabel.Size = new System.Drawing.Size(80, 13);
			unitsOnOrderLabel.TabIndex = 19;
			unitsOnOrderLabel.Text = "Units On Order:";
			// 
			// unitsOnOrderTextBox
			// 
			this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productListBindingSource, "UnitsOnOrder", true));
			this.unitsOnOrderTextBox.Location = new System.Drawing.Point(142, 292);
			this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
			this.unitsOnOrderTextBox.Size = new System.Drawing.Size(283, 20);
			this.unitsOnOrderTextBox.TabIndex = 20;
			// 
			// ProductsEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 398);
			this.Controls.Add(categoryIDLabel);
			this.Controls.Add(this.categoryIDTextBox);
			this.Controls.Add(discontinuedLabel);
			this.Controls.Add(this.discontinuedCheckBox);
			this.Controls.Add(productIDLabel);
			this.Controls.Add(this.productIDTextBox);
			this.Controls.Add(productNameLabel);
			this.Controls.Add(this.productNameTextBox);
			this.Controls.Add(quantityPerUnitLabel);
			this.Controls.Add(this.quantityPerUnitTextBox);
			this.Controls.Add(reorderLevelLabel);
			this.Controls.Add(this.reorderLevelTextBox);
			this.Controls.Add(supplierIDLabel);
			this.Controls.Add(this.supplierIDTextBox);
			this.Controls.Add(unitPriceLabel);
			this.Controls.Add(this.unitPriceTextBox);
			this.Controls.Add(unitsInStockLabel);
			this.Controls.Add(this.unitsInStockTextBox);
			this.Controls.Add(unitsOnOrderLabel);
			this.Controls.Add(this.unitsOnOrderTextBox);
			this.Controls.Add(this.productListBindingNavigator);
			this.Name = "ProductsEditForm";
			this.Text = "ProductsEditForm";
			((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productListBindingNavigator)).EndInit();
			this.productListBindingNavigator.ResumeLayout(false);
			this.productListBindingNavigator.PerformLayout();
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
		private System.Windows.Forms.TextBox categoryIDTextBox;
		private System.Windows.Forms.CheckBox discontinuedCheckBox;
		private System.Windows.Forms.TextBox productIDTextBox;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.TextBox quantityPerUnitTextBox;
		private System.Windows.Forms.TextBox reorderLevelTextBox;
		private System.Windows.Forms.TextBox supplierIDTextBox;
		private System.Windows.Forms.TextBox unitPriceTextBox;
		private System.Windows.Forms.TextBox unitsInStockTextBox;
		private System.Windows.Forms.TextBox unitsOnOrderTextBox;
	}
}