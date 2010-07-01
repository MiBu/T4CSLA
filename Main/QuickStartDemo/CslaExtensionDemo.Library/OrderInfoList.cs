using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Serialization;


namespace CslaExtensionDemo.Library
{
	public partial class OrderInfoList //: Csla.ReadOnlyListBase<OrderInfoList, OrderInfo>
	{
		#region Criteria
		/// <summary>
		/// Filter criteria
		/// </summary>
		class Criteria
		{
			internal Criteria(DateTime? orderFrom, DateTime? orderTo, string customer)
			{
				this.OrderFrom = orderFrom;
				this.OrderTo = orderTo;
				this.Customer = customer;
			}

			public DateTime? OrderFrom { get; private set; }
			public DateTime? OrderTo { get; private set; }
			public string Customer { get; private set; }
		}
		#endregion

		#region Factory Methods
		public static OrderInfoList Get(DateTime? orderFrom, DateTime? orderTo, string customer)
		{
			Criteria c = new Criteria(orderFrom, orderTo, customer);
			return DataPortal.Fetch<OrderInfoList>(c);
		}
		#endregion

		#region DataPortal methods
		private void DataPortal_Fetch(Criteria c)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager("NorthwindEntities2"))
			{
				var data = from o in ctx.ObjectContext.OrderInfos
						   select o;

				if (c.OrderFrom.HasValue)
					data = data.Where(o => o.OrderDate >= c.OrderFrom.Value);
				if (c.OrderTo.HasValue)
					data = data.Where(o => o.OrderDate <= c.OrderTo.Value);
				if (!string.IsNullOrEmpty(c.Customer))
					data = data.Where(o => o.CompanyName.Contains(c.Customer));

				ReadData(data);
			}
		}
		#endregion
	}
}
