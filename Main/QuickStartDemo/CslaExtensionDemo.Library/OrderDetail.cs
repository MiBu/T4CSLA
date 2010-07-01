using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaExtensionDemo.Library
{
	public partial class OrderDetail
	{
		/// <summary>
		/// Order detail total ammount. 
		/// Warning: Discount not implemented
		/// </summary>
		public decimal Total
		{
			get
			{
				return this.Quantity * this.UnitPrice;
			}
		}

		/// <summary>
		/// Implement BeforeInsert to populate
		/// autoincrement foreign key
		/// </summary>
		/// <param name="data"></param>
		partial void BeforeInsert(Data.OrderDetail data)
		{
			var list = (OrderDetailList)this.Parent;
			var order = (Order)list.Parent;
			this.OrderID = order.OrderID;
		}
	}
}
