//
// This is auto-generated file. Do not change manually this code.
// If you want to extend or override functionality please write
// appropriate partial methods.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Serialization;


namespace CslaExtension.Template.Business
{

	#region Class Order_Detail

	[Serializable]
	public partial class Order_Detail : Csla.BusinessBase<Order_Detail>, IEquatable<Order_Detail>
	{
		#region Key
		internal class Key
		{
			public int OrderID;
			public int ProductID;
			internal Key(int orderID, int productID)
			{
				this.OrderID = orderID;
				this.ProductID = productID;
			}
		}
		#endregion

		#region Properties

		protected static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
		public int OrderID
		{
			 get { return GetProperty<int>(OrderIDProperty); }
			 set { SetProperty<int>(OrderIDProperty, value); }
			}

		protected static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
		public int ProductID
		{
			 get { return GetProperty<int>(ProductIDProperty); }
			 set { SetProperty<int>(ProductIDProperty, value); }
			}

		protected static PropertyInfo<decimal> UnitPriceProperty = RegisterProperty<decimal>(c => c.UnitPrice);
		public decimal UnitPrice
		{
			 get { return GetProperty<decimal>(UnitPriceProperty); }
			 set { SetProperty<decimal>(UnitPriceProperty, value); }
			}

		protected static PropertyInfo<short> QuantityProperty = RegisterProperty<short>(c => c.Quantity);
		public short Quantity
		{
			 get { return GetProperty<short>(QuantityProperty); }
			 set { SetProperty<short>(QuantityProperty, value); }
			}

		protected static PropertyInfo<float> DiscountProperty = RegisterProperty<float>(c => c.Discount);
		public float Discount
		{
			 get { return GetProperty<float>(DiscountProperty); }
			 set { SetProperty<float>(DiscountProperty, value); }
			}
		#endregion // Properties

		#region Navigation Properties
		
		protected static PropertyInfo<Order> OrderProperty = RegisterProperty<Order>(c => c.Order);
		public Order Order
		{
			 get { return GetProperty<Order>(OrderProperty); }
			 set 
			{
				SetProperty<Order>(OrderProperty, value);			
				SetProperty<int>(OrderIDProperty, value.OrderID);
			}
		}
		#endregion // Navigation Properties

		#region Business Rules
		protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
			
			// Partial Method BeforeAddBusinessRules
			BeforeAddBusinessRules();
			
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(OrderIDProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ProductIDProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(UnitPriceProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(QuantityProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(DiscountProperty));

			// Partial Method AfterAddBusinessRules
			AfterAddBusinessRules();
		}
		
		///
		/// Partial methods for adding additional business rules
		///
        partial void BeforeAddBusinessRules();
        partial void AfterAddBusinessRules();
		
		#endregion Business Rules

		#region Equals Methods and Operators

        public bool Equals(Order_Detail other)
        {
            if (other == null)
				return false;								

			if (this.OrderID != other.OrderID)
				return false;

			if (this.ProductID != other.ProductID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Order_Detail)
				return this.Equals((Order_Detail)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return OrderID.GetHashCode() ^ ProductID.GetHashCode();
        }
		
		public static bool operator == (Order_Detail a, Order_Detail b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Order_Detail a, Order_Detail b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
		internal static Order_Detail New()
		{
			return DataPortal.CreateChild<Order_Detail>();
		}			

		internal static Order_Detail Get(CslaExtension.Template.Data.Order_Detail data)
		{
			if (data == null)
				return null;
				
			return DataPortal.FetchChild<Order_Detail>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtension.Template.Data.Order_Detail data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Load Data to Navigation Properties
			LoadProperty<Order>(OrderProperty, Order.Get(data.Order));
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterReadData(CslaExtension.Template.Data.Order_Detail data);

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtension.Template.Data.Order_Detail data)
		{
			LoadProperty(OrderIDProperty, data.OrderID);
			LoadProperty(ProductIDProperty, data.ProductID);
			LoadProperty(UnitPriceProperty, data.UnitPrice);
			LoadProperty(QuantityProperty, data.Quantity);
			LoadProperty(DiscountProperty, data.Discount);
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteData(CslaExtension.Template.Data.Order_Detail data)
		{
			BeforeWriteData(data);
			
			data.OrderID = ReadProperty<int>(OrderIDProperty);
			data.ProductID = ReadProperty<int>(ProductIDProperty);
			data.UnitPrice = ReadProperty<decimal>(UnitPriceProperty);
			data.Quantity = ReadProperty<short>(QuantityProperty);
			data.Discount = ReadProperty<float>(DiscountProperty);

			AfterWriteData(data);
		} // WriteData()
		
		partial void BeforeWriteData(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterWriteData(CslaExtension.Template.Data.Order_Detail data);
		#endregion // Common Data Access Methods

		#region Data Portal Methods
        protected override void Child_Create()
        {
            base.DataPortal_Create();				
			BeforeCreate();				
			//ValidationRules.CheckRules();				
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void Child_Fetch(CslaExtension.Template.Data.Order_Detail data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}			
		partial void BeforeFetch(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterFetch(CslaExtension.Template.Data.Order_Detail data);			
		
		//Insert
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				var data = new CslaExtension.Template.Data.Order_Detail();					
				BeforeInsert(data);					
				WriteData(data);					
				ctx.ObjectContext.Order_Details.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadDataToProperties(data);					
				AfterInsert(data);					
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterInsert(CslaExtension.Template.Data.Order_Detail data);			
		
		//Update
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				if (this.IsSelfDirty)
				{
					var data = ctx.ObjectContext.Order_Details.Single(e => e.OrderID == this.OrderID && e.ProductID == this.ProductID);
					BeforeUpdate(data);					
					WriteData(data);
					ctx.ObjectContext.SaveChanges();
					LoadDataToProperties(data);
					AfterUpdate(data);
				}
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterUpdate(CslaExtension.Template.Data.Order_Detail data);
		#endregion // Data Portal Methods
		#endregion // Data Access Layer
	} // end of class Order_Detail
	#endregion // Class Order_Detail

	#region Class Order_DetailList

	[Serializable]
	public partial class Order_DetailList : Csla.BusinessListBase<Order_DetailList, Order_Detail>
	{

		#region Synchronous Factory Methods
		internal static Order_DetailList New()
		{
			return DataPortal.CreateChild<Order_DetailList>();
		}			

		internal static Order_DetailList Get(IEnumerable<CslaExtension.Template.Data.Order_Detail> data)
		{
			if (data == null)
				return null;
			return DataPortal.FetchChild<Order_DetailList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtension.Template.Data.Order_Detail> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			foreach (var item in data)
			{
				this.Add(Order_Detail.Get(item));
			}
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);
		partial void AfterReadData(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);
		#endregion

		#region Data Portal Methods
        protected override void Child_Create()
        {
            base.DataPortal_Create();			
			BeforeDataPortal_Create();			
			//ValidationRules.CheckRules();			
			AfterDataPortal_Create();
		}
		partial void BeforeDataPortal_Create();
		partial void AfterDataPortal_Create();
			

		private void Child_Fetch(IEnumerable<CslaExtension.Template.Data.Order_Detail> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);
		partial void AfterFetch(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class Order_DetailList

	#region Class Order

	[Serializable]
	public partial class Order : Csla.BusinessBase<Order>, IEquatable<Order>
	{
		#region Key
		internal class Key
		{
			public int OrderID;
			internal Key(int orderID)
			{
				this.OrderID = orderID;
			}
		}
		#endregion

		#region Properties

		protected static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
		public int OrderID
		{
			 get { return GetProperty<int>(OrderIDProperty); }
			 set { SetProperty<int>(OrderIDProperty, value); }
			}

		protected static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
		public string CustomerID
		{
			 get { return GetProperty<string>(CustomerIDProperty); }
			 set { SetProperty<string>(CustomerIDProperty, value); }
			}

		protected static PropertyInfo<int> EmployeeIDProperty = RegisterProperty<int>(c => c.EmployeeID);
		public int EmployeeID
		{
			 get { return GetProperty<int>(EmployeeIDProperty); }
			 set { SetProperty<int>(EmployeeIDProperty, value); }
			}

		protected static PropertyInfo<System.DateTime> OrderDateProperty = RegisterProperty<System.DateTime>(c => c.OrderDate);
		public System.DateTime OrderDate
		{
			 get { return GetProperty<System.DateTime>(OrderDateProperty); }
			 set { SetProperty<System.DateTime>(OrderDateProperty, value); }
			}

		protected static PropertyInfo<System.DateTime> RequiredDateProperty = RegisterProperty<System.DateTime>(c => c.RequiredDate);
		public System.DateTime RequiredDate
		{
			 get { return GetProperty<System.DateTime>(RequiredDateProperty); }
			 set { SetProperty<System.DateTime>(RequiredDateProperty, value); }
			}

		protected static PropertyInfo<System.DateTime> ShippedDateProperty = RegisterProperty<System.DateTime>(c => c.ShippedDate);
		public System.DateTime ShippedDate
		{
			 get { return GetProperty<System.DateTime>(ShippedDateProperty); }
			 set { SetProperty<System.DateTime>(ShippedDateProperty, value); }
			}

		protected static PropertyInfo<int> ShipViaProperty = RegisterProperty<int>(c => c.ShipVia);
		public int ShipVia
		{
			 get { return GetProperty<int>(ShipViaProperty); }
			 set { SetProperty<int>(ShipViaProperty, value); }
			}

		protected static PropertyInfo<decimal> FreightProperty = RegisterProperty<decimal>(c => c.Freight);
		public decimal Freight
		{
			 get { return GetProperty<decimal>(FreightProperty); }
			 set { SetProperty<decimal>(FreightProperty, value); }
			}

		protected static PropertyInfo<string> ShipNameProperty = RegisterProperty<string>(c => c.ShipName);
		public string ShipName
		{
			 get { return GetProperty<string>(ShipNameProperty); }
			 set { SetProperty<string>(ShipNameProperty, value); }
			}

		protected static PropertyInfo<string> ShipAddressProperty = RegisterProperty<string>(c => c.ShipAddress);
		public string ShipAddress
		{
			 get { return GetProperty<string>(ShipAddressProperty); }
			 set { SetProperty<string>(ShipAddressProperty, value); }
			}

		protected static PropertyInfo<string> ShipCityProperty = RegisterProperty<string>(c => c.ShipCity);
		public string ShipCity
		{
			 get { return GetProperty<string>(ShipCityProperty); }
			 set { SetProperty<string>(ShipCityProperty, value); }
			}

		protected static PropertyInfo<string> ShipRegionProperty = RegisterProperty<string>(c => c.ShipRegion);
		public string ShipRegion
		{
			 get { return GetProperty<string>(ShipRegionProperty); }
			 set { SetProperty<string>(ShipRegionProperty, value); }
			}

		protected static PropertyInfo<string> ShipPostalCodeProperty = RegisterProperty<string>(c => c.ShipPostalCode);
		public string ShipPostalCode
		{
			 get { return GetProperty<string>(ShipPostalCodeProperty); }
			 set { SetProperty<string>(ShipPostalCodeProperty, value); }
			}

		protected static PropertyInfo<string> ShipCountryProperty = RegisterProperty<string>(c => c.ShipCountry);
		public string ShipCountry
		{
			 get { return GetProperty<string>(ShipCountryProperty); }
			 set { SetProperty<string>(ShipCountryProperty, value); }
			}
		#endregion // Properties

		#region Navigation Properties
		#endregion // Navigation Properties

		#region Business Rules
		protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
			
			// Partial Method BeforeAddBusinessRules
			BeforeAddBusinessRules();
			
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(OrderIDProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CustomerIDProperty, 5));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(EmployeeIDProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(OrderDateProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(RequiredDateProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ShippedDateProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ShipViaProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(FreightProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipNameProperty, 40));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipAddressProperty, 60));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipCityProperty, 15));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipRegionProperty, 15));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipPostalCodeProperty, 10));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ShipCountryProperty, 15));

			// Partial Method AfterAddBusinessRules
			AfterAddBusinessRules();
		}
		
		///
		/// Partial methods for adding additional business rules
		///
        partial void BeforeAddBusinessRules();
        partial void AfterAddBusinessRules();
		
		#endregion Business Rules

		#region Equals Methods and Operators

        public bool Equals(Order other)
        {
            if (other == null)
				return false;								

			if (this.OrderID != other.OrderID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Order)
				return this.Equals((Order)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return OrderID.GetHashCode();
        }
		
		public static bool operator == (Order a, Order b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Order a, Order b)
		{
			return !(a == b);
		}
		#endregion

		#region Asynchronous Factory Methods
		public static void Get(int orderID, EventHandler<DataPortalResult<Order>> callback)
		{
			var dp = new DataPortal<Order>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Key(orderID));
		}
		#endregion // Asynchronous Factory Methods

		#region Synchronous Factory Methods
		public static Order New()
		{
			return DataPortal.Create<Order>();
		}			
		
		public static Order Get(int orderID)
		{
			return DataPortal.Fetch<Order>(new Key(orderID));
		}

		internal static Order Get(CslaExtension.Template.Data.Order data)
		{
			if (data == null)
				return null;
				
			return DataPortal.Fetch<Order>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtension.Template.Data.Order data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtension.Template.Data.Order data);
		partial void AfterReadData(CslaExtension.Template.Data.Order data);

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtension.Template.Data.Order data)
		{
			LoadProperty(OrderIDProperty, data.OrderID);
			LoadProperty(CustomerIDProperty, data.CustomerID);
			LoadProperty(EmployeeIDProperty, data.EmployeeID);
			LoadProperty(OrderDateProperty, data.OrderDate);
			LoadProperty(RequiredDateProperty, data.RequiredDate);
			LoadProperty(ShippedDateProperty, data.ShippedDate);
			LoadProperty(ShipViaProperty, data.ShipVia);
			LoadProperty(FreightProperty, data.Freight);
			LoadProperty(ShipNameProperty, data.ShipName);
			LoadProperty(ShipAddressProperty, data.ShipAddress);
			LoadProperty(ShipCityProperty, data.ShipCity);
			LoadProperty(ShipRegionProperty, data.ShipRegion);
			LoadProperty(ShipPostalCodeProperty, data.ShipPostalCode);
			LoadProperty(ShipCountryProperty, data.ShipCountry);
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteData(CslaExtension.Template.Data.Order data)
		{
			BeforeWriteData(data);
			
			data.OrderID = ReadProperty<int>(OrderIDProperty);
			data.CustomerID = ReadProperty<string>(CustomerIDProperty);
			data.EmployeeID = ReadProperty<int>(EmployeeIDProperty);
			data.OrderDate = ReadProperty<System.DateTime>(OrderDateProperty);
			data.RequiredDate = ReadProperty<System.DateTime>(RequiredDateProperty);
			data.ShippedDate = ReadProperty<System.DateTime>(ShippedDateProperty);
			data.ShipVia = ReadProperty<int>(ShipViaProperty);
			data.Freight = ReadProperty<decimal>(FreightProperty);
			data.ShipName = ReadProperty<string>(ShipNameProperty);
			data.ShipAddress = ReadProperty<string>(ShipAddressProperty);
			data.ShipCity = ReadProperty<string>(ShipCityProperty);
			data.ShipRegion = ReadProperty<string>(ShipRegionProperty);
			data.ShipPostalCode = ReadProperty<string>(ShipPostalCodeProperty);
			data.ShipCountry = ReadProperty<string>(ShipCountryProperty);

			AfterWriteData(data);
		} // WriteData()
		
		partial void BeforeWriteData(CslaExtension.Template.Data.Order data);
		partial void AfterWriteData(CslaExtension.Template.Data.Order data);
		#endregion // Common Data Access Methods

		#region Data Portal Methods
        protected override void DataPortal_Create()
        {
            base.DataPortal_Create();				
			BeforeCreate();				
			//ValidationRules.CheckRules();				
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			
		private void DataPortal_Fetch(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
			{
				var data = ctx.ObjectContext.Orders.Single(e => e.OrderID == key.OrderID);
				DataPortal_Fetch(data);
			}		
		}

		private void DataPortal_Fetch(CslaExtension.Template.Data.Order data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}			
		partial void BeforeFetch(CslaExtension.Template.Data.Order data);
		partial void AfterFetch(CslaExtension.Template.Data.Order data);			
		
		//Insert
		override protected void DataPortal_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				var data = new CslaExtension.Template.Data.Order();					
				BeforeInsert(data);					
				WriteData(data);					
				ctx.ObjectContext.Orders.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadDataToProperties(data);					
				AfterInsert(data);					
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtension.Template.Data.Order data);
		partial void AfterInsert(CslaExtension.Template.Data.Order data);			
		
		//Update
		override protected void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				if (this.IsSelfDirty)
				{
					var data = ctx.ObjectContext.Orders.Single(e => e.OrderID == this.OrderID);
					BeforeUpdate(data);					
					WriteData(data);
					ctx.ObjectContext.SaveChanges();
					LoadDataToProperties(data);
					AfterUpdate(data);
				}
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtension.Template.Data.Order data);
		partial void AfterUpdate(CslaExtension.Template.Data.Order data);
		#endregion // Data Portal Methods
		#endregion // Data Access Layer
	} // end of class Order
	#endregion // Class Order
} // end of namespace CslaExtension.Template.Business
