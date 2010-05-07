using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CslaExtensionDemo.Library
{
	public partial class OrderDetail
	{
		partial void BeforeInsert(Data.OrderDetail data)
		{
			var list = (OrderDetailList)this.Parent;
			var order = (Order)list.Parent;
			this.OrderID = order.OrderID;
		}
	}
}
