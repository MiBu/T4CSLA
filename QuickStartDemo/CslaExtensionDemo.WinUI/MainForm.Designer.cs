namespace CslaExtensionDemo.WinUI
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProducts = new System.Windows.Forms.Button();
			this.lblFirstLoad = new System.Windows.Forms.Label();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.pnlWorkspace = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnProducts);
			this.panel1.Controls.Add(this.lblFirstLoad);
			this.panel1.Controls.Add(this.btnCustomers);
			this.panel1.Controls.Add(this.btnOrders);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(156, 433);
			this.panel1.TabIndex = 0;
			// 
			// btnProducts
			// 
			this.btnProducts.Location = new System.Drawing.Point(3, 70);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(147, 23);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// lblFirstLoad
			// 
			this.lblFirstLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFirstLoad.ForeColor = System.Drawing.Color.Red;
			this.lblFirstLoad.Location = new System.Drawing.Point(12, 343);
			this.lblFirstLoad.Name = "lblFirstLoad";
			this.lblFirstLoad.Size = new System.Drawing.Size(122, 81);
			this.lblFirstLoad.TabIndex = 0;
			this.lblFirstLoad.Text = "First data load may last longer because mdf file has to be attached to the sqlexp" +
				"ress";
			// 
			// btnCustomers
			// 
			this.btnCustomers.Location = new System.Drawing.Point(3, 41);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(147, 23);
			this.btnCustomers.TabIndex = 1;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.Location = new System.Drawing.Point(3, 12);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(147, 23);
			this.btnOrders.TabIndex = 0;
			this.btnOrders.Text = "Orders";
			this.btnOrders.UseVisualStyleBackColor = true;
			this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
			// 
			// pnlWorkspace
			// 
			this.pnlWorkspace.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlWorkspace.Location = new System.Drawing.Point(156, 0);
			this.pnlWorkspace.Name = "pnlWorkspace";
			this.pnlWorkspace.Size = new System.Drawing.Size(467, 433);
			this.pnlWorkspace.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 433);
			this.Controls.Add(this.pnlWorkspace);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnOrders;
		private System.Windows.Forms.Panel pnlWorkspace;
		private System.Windows.Forms.Label lblFirstLoad;
		private System.Windows.Forms.Button btnProducts;

	}
}

