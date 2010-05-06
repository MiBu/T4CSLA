using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaExtensionDemo.Library
{
	public partial class Order
	{
		partial void AfterCreate()
		{
			this.EmployeeID = 1;
			this.OrderDate = DateTime.Now;
			this.RequiredDate = DateTime.Now;
			this.ShippedDate = DateTime.Now;
			this.Order_Details = OrderDetailList.New();
		}
		partial void AfterInsert(Data.Order data)
		{
			foreach (var item in this.Order_Details)
				item.OrderID = data.OrderID;
		}
	}
}
