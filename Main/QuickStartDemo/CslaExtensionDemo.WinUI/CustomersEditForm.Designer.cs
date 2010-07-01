namespace CslaExtensionDemo.WinUI
{
	partial class CustomersEditForm
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
			System.Windows.Forms.Label contactNameLabel;
			System.Windows.Forms.Label contactTitleLabel;
			System.Windows.Forms.Label countryLabel;
			System.Windows.Forms.Label faxLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label postalCodeLabel;
			System.Windows.Forms.Label regionLabel;
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.contactTitleTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.faxTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			contactNameLabel = new System.Windows.Forms.Label();
			contactTitleLabel = new System.Windows.Forms.Label();
			countryLabel = new System.Windows.Forms.Label();
			faxLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			postalCodeLabel = new System.Windows.Forms.Label();
			regionLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(36, 56);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 1;
			addressLabel.Text = "Address:";
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(36, 82);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 3;
			cityLabel.Text = "City:";
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			companyNameLabel.Location = new System.Drawing.Point(36, 30);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(98, 13);
			companyNameLabel.TabIndex = 5;
			companyNameLabel.Text = "Company Name:";
			// 
			// contactNameLabel
			// 
			contactNameLabel.AutoSize = true;
			contactNameLabel.Location = new System.Drawing.Point(36, 108);
			contactNameLabel.Name = "contactNameLabel";
			contactNameLabel.Size = new System.Drawing.Size(78, 13);
			contactNameLabel.TabIndex = 7;
			contactNameLabel.Text = "Contact Name:";
			// 
			// contactTitleLabel
			// 
			contactTitleLabel.AutoSize = true;
			contactTitleLabel.Location = new System.Drawing.Point(36, 134);
			contactTitleLabel.Name = "contactTitleLabel";
			contactTitleLabel.Size = new System.Drawing.Size(70, 13);
			contactTitleLabel.TabIndex = 9;
			contactTitleLabel.Text = "Contact Title:";
			// 
			// countryLabel
			// 
			countryLabel.AutoSize = true;
			countryLabel.Location = new System.Drawing.Point(36, 160);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new System.Drawing.Size(46, 13);
			countryLabel.TabIndex = 11;
			countryLabel.Text = "Country:";
			// 
			// faxLabel
			// 
			faxLabel.AutoSize = true;
			faxLabel.Location = new System.Drawing.Point(36, 186);
			faxLabel.Name = "faxLabel";
			faxLabel.Size = new System.Drawing.Size(27, 13);
			faxLabel.TabIndex = 13;
			faxLabel.Text = "Fax:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(36, 212);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(41, 13);
			phoneLabel.TabIndex = 15;
			phoneLabel.Text = "Phone:";
			// 
			// postalCodeLabel
			// 
			postalCodeLabel.AutoSize = true;
			postalCodeLabel.Location = new System.Drawing.Point(36, 238);
			postalCodeLabel.Name = "postalCodeLabel";
			postalCodeLabel.Size = new System.Drawing.Size(67, 13);
			postalCodeLabel.TabIndex = 17;
			postalCodeLabel.Text = "Postal Code:";
			// 
			// regionLabel
			// 
			regionLabel.AutoSize = true;
			regionLabel.Location = new System.Drawing.Point(36, 264);
			regionLabel.Name = "regionLabel";
			regionLabel.Size = new System.Drawing.Size(44, 13);
			regionLabel.TabIndex = 19;
			regionLabel.Text = "Region:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(140, 53);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(292, 20);
			this.addressTextBox.TabIndex = 2;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataSource = typeof(CslaExtensionDemo.Library.Customer);
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(140, 79);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(292, 20);
			this.cityTextBox.TabIndex = 4;
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(140, 27);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(292, 20);
			this.companyNameTextBox.TabIndex = 6;
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ContactName", true));
			this.contactNameTextBox.Location = new System.Drawing.Point(140, 105);
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(292, 20);
			this.contactNameTextBox.TabIndex = 8;
			// 
			// contactTitleTextBox
			// 
			this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ContactTitle", true));
			this.contactTitleTextBox.Location = new System.Drawing.Point(140, 131);
			this.contactTitleTextBox.Name = "contactTitleTextBox";
			this.contactTitleTextBox.Size = new System.Drawing.Size(292, 20);
			this.contactTitleTextBox.TabIndex = 10;
			// 
			// countryTextBox
			// 
			this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Country", true));
			this.countryTextBox.Location = new System.Drawing.Point(140, 157);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(292, 20);
			this.countryTextBox.TabIndex = 12;
			// 
			// faxTextBox
			// 
			this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fax", true));
			this.faxTextBox.Location = new System.Drawing.Point(140, 183);
			this.faxTextBox.Name = "faxTextBox";
			this.faxTextBox.Size = new System.Drawing.Size(292, 20);
			this.faxTextBox.TabIndex = 14;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(140, 209);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(292, 20);
			this.phoneTextBox.TabIndex = 16;
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PostalCode", true));
			this.postalCodeTextBox.Location = new System.Drawing.Point(140, 235);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(292, 20);
			this.postalCodeTextBox.TabIndex = 18;
			// 
			// regionTextBox
			// 
			this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Region", true));
			this.regionTextBox.Location = new System.Drawing.Point(140, 261);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(292, 20);
			this.regionTextBox.TabIndex = 20;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(275, 301);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 21;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(357, 301);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			this.errorProvider1.DataSource = this.customerBindingSource;
			// 
			// CustomersEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 340);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(addressLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(cityLabel);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(companyNameLabel);
			this.Controls.Add(this.companyNameTextBox);
			this.Controls.Add(contactNameLabel);
			this.Controls.Add(this.contactNameTextBox);
			this.Controls.Add(contactTitleLabel);
			this.Controls.Add(this.contactTitleTextBox);
			this.Controls.Add(countryLabel);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(faxLabel);
			this.Controls.Add(this.faxTextBox);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(postalCodeLabel);
			this.Controls.Add(this.postalCodeTextBox);
			this.Controls.Add(regionLabel);
			this.Controls.Add(this.regionTextBox);
			this.Name = "CustomersEditForm";
			this.Text = "CustomersEditForm";
			this.Load += new System.EventHandler(this.CustomersEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource customerBindingSource;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.TextBox contactNameTextBox;
		private System.Windows.Forms.TextBox contactTitleTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox faxTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}