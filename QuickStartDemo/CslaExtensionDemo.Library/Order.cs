using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaExtensionDemo.Library
{
	public partial class Order
	{
		/// <summary>
		/// Copy data from Customer to ShipTo
		/// </summary>
		public void ShipToCustomer()
		{
			if (Customer != null)
			{
				this.ShipName = Customer.CompanyName;
				this.ShipAddress = Customer.Address;
				this.ShipCity = Customer.City;
				this.ShipCountry = Customer.Country;
				this.ShipPostalCode = Customer.PostalCode;
				this.ShipRegion = Customer.Region;
			}
		}

		/// <summary>
		/// Implement AfterCreate to populate not-null fields
		/// </summary>
		partial void AfterCreate()
		{
			this.EmployeeID = 1;
			this.OrderDate = DateTime.Now;
			this.RequiredDate = DateTime.Now;
			this.ShippedDate = DateTime.Now;
			this.Order_Details = OrderDetailList.New();
		}
	}
}
