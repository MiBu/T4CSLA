//
// This is auto-generated file. Do not change manually this code.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Data;

namespace CslaExtensionDemo.Library
{

	[Serializable]
	public partial class Customer : Csla.BusinessBase<Customer>
	{
			#region Key
			internal class Key
			{
				public string CustomerID;
				internal Key(string customerID)
				{
					this.CustomerID = customerID;
				}
			}
			#endregion
			
			#region Properties

			protected static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
			internal string CustomerID
			{
				 get { return GetProperty<string>(CustomerIDProperty); }
				private set { SetProperty<string>(CustomerIDProperty, value); }
			}

			protected static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
			public string CompanyName
			{
				 get { return GetProperty<string>(CompanyNameProperty); }
				 set { SetProperty<string>(CompanyNameProperty, value); }
			}

			protected static PropertyInfo<string> ContactNameProperty = RegisterProperty<string>(c => c.ContactName);
			public string ContactName
			{
				 get { return GetProperty<string>(ContactNameProperty); }
				 set { SetProperty<string>(ContactNameProperty, value); }
			}

			protected static PropertyInfo<string> ContactTitleProperty = RegisterProperty<string>(c => c.ContactTitle);
			public string ContactTitle
			{
				 get { return GetProperty<string>(ContactTitleProperty); }
				 set { SetProperty<string>(ContactTitleProperty, value); }
			}

			protected static PropertyInfo<string> AddressProperty = RegisterProperty<string>(c => c.Address);
			public string Address
			{
				 get { return GetProperty<string>(AddressProperty); }
				 set { SetProperty<string>(AddressProperty, value); }
			}

			protected static PropertyInfo<string> CityProperty = RegisterProperty<string>(c => c.City);
			public string City
			{
				 get { return GetProperty<string>(CityProperty); }
				 set { SetProperty<string>(CityProperty, value); }
			}

			protected static PropertyInfo<string> RegionProperty = RegisterProperty<string>(c => c.Region);
			public string Region
			{
				 get { return GetProperty<string>(RegionProperty); }
				 set { SetProperty<string>(RegionProperty, value); }
			}

			protected static PropertyInfo<string> PostalCodeProperty = RegisterProperty<string>(c => c.PostalCode);
			public string PostalCode
			{
				 get { return GetProperty<string>(PostalCodeProperty); }
				 set { SetProperty<string>(PostalCodeProperty, value); }
			}

			protected static PropertyInfo<string> CountryProperty = RegisterProperty<string>(c => c.Country);
			public string Country
			{
				 get { return GetProperty<string>(CountryProperty); }
				 set { SetProperty<string>(CountryProperty, value); }
			}

			protected static PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
			public string Phone
			{
				 get { return GetProperty<string>(PhoneProperty); }
				 set { SetProperty<string>(PhoneProperty, value); }
			}

			protected static PropertyInfo<string> FaxProperty = RegisterProperty<string>(c => c.Fax);
			public string Fax
			{
				 get { return GetProperty<string>(FaxProperty); }
				 set { SetProperty<string>(FaxProperty, value); }
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
				
                BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(CustomerIDProperty));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CustomerIDProperty, 5));
                BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(CompanyNameProperty));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CompanyNameProperty, 40));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ContactNameProperty, 30));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ContactTitleProperty, 30));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(AddressProperty, 60));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CityProperty, 15));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(RegionProperty, 15));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(PostalCodeProperty, 10));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CountryProperty, 15));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(PhoneProperty, 24));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(FaxProperty, 24));

				// Partial Method AfterAddBusinessRules
				AfterAddBusinessRules();
			}
			
			///
			/// Partial methods for adding additional business rules
			///
            partial void BeforeAddBusinessRules();
            partial void AfterAddBusinessRules();
			
			#endregion Business Rules

			#region Factory Methods
			internal static Customer New()
			{
				return DataPortal.CreateChild<Customer>();
			}			

			internal static Customer Get(CslaExtensionDemo.Library.Data.Customer data)
			{
				if (data == null)
					return null;
					
				return DataPortal.FetchChild<Customer>(data);				
			}
			#endregion // Factory Methods

			#region Data Access Layer
			#region Common Data Access Methods
			/// <summary>
			/// 
			/// </summary>
			private void ReadData(CslaExtensionDemo.Library.Data.Customer data)
			{
				// Partial Method BeforeReadData
				BeforeReadData(data);
				
				// Load Data to Properties
				LoadProperty(CustomerIDProperty, data.CustomerID);
				LoadProperty(CompanyNameProperty, data.CompanyName);
				LoadProperty(ContactNameProperty, data.ContactName);
				LoadProperty(ContactTitleProperty, data.ContactTitle);
				LoadProperty(AddressProperty, data.Address);
				LoadProperty(CityProperty, data.City);
				LoadProperty(RegionProperty, data.Region);
				LoadProperty(PostalCodeProperty, data.PostalCode);
				LoadProperty(CountryProperty, data.Country);
				LoadProperty(PhoneProperty, data.Phone);
				LoadProperty(FaxProperty, data.Fax);
				
				// Load Data to Navigation Properties
				
				// Partial Method AfterReadData
				AfterReadData(data);
			} // ReadData()
			
			partial void BeforeReadData(CslaExtensionDemo.Library.Data.Customer data);
			partial void AfterReadData(CslaExtensionDemo.Library.Data.Customer data);

			/// <summary>
			/// 
			/// </summary>
			private void WriteData(CslaExtensionDemo.Library.Data.Customer data)
			{
				BeforeWriteData(data);
				
				data.CustomerID = ReadProperty<string>(CustomerIDProperty);
				data.CompanyName = ReadProperty<string>(CompanyNameProperty);
				data.ContactName = ReadProperty<string>(ContactNameProperty);
				data.ContactTitle = ReadProperty<string>(ContactTitleProperty);
				data.Address = ReadProperty<string>(AddressProperty);
				data.City = ReadProperty<string>(CityProperty);
				data.Region = ReadProperty<string>(RegionProperty);
				data.PostalCode = ReadProperty<string>(PostalCodeProperty);
				data.Country = ReadProperty<string>(CountryProperty);
				data.Phone = ReadProperty<string>(PhoneProperty);
				data.Fax = ReadProperty<string>(FaxProperty);

				AfterWriteData(data);
			} // WriteData()
			
			partial void BeforeWriteData(CslaExtensionDemo.Library.Data.Customer data);
			partial void AfterWriteData(CslaExtensionDemo.Library.Data.Customer data);
			#endregion // Common Data Access Methods

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
			

			private void Child_Fetch(CslaExtensionDemo.Library.Data.Customer data)
			{
				BeforeFetch(data);
				ReadData(data);
				AfterFetch(data);				
			}
			partial void BeforeFetch(CslaExtensionDemo.Library.Data.Customer data);
			partial void AfterFetch(CslaExtensionDemo.Library.Data.Customer data);			
			
			//Insert
			private void Child_Insert()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = new CslaExtensionDemo.Library.Data.Customer();
					BeforeInsert(data);
					WriteData(data);
					entities.Customers.AddObject(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterInsert(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeInsert(CslaExtensionDemo.Library.Data.Customer data);
			partial void AfterInsert(CslaExtensionDemo.Library.Data.Customer data);			
			
			//Update
			private void Child_Update()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = entities.Customers.Single(e => e.CustomerID == this.CustomerID);
					BeforeUpdate(data);
					WriteData(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterUpdate(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Customer data);
			partial void AfterUpdate(CslaExtensionDemo.Library.Data.Customer data);			

			
			#endregion // Data Portal Methods
			#endregion // Data Access Layer
	} // class Customer

	[Serializable]
	public partial class CustomerList : Csla.BusinessListBase<CustomerList, Customer>
	{
		#region Factory Methods
		public static CustomerList New()
		{
			return DataPortal.Create<CustomerList>();
		}			
			
		public static Customer Get(string customerID)
		{
			CustomerList result = DataPortal.Fetch<CustomerList>(new Customer.Key(customerID));
			return result.FirstOrDefault();
		}
		
		public static CustomerList GetAll()
		{
			return DataPortal.Fetch<CustomerList>();
		}

		#endregion // Factory Methods

		#region Data Access Layer

		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			foreach (var item in data)
			{
				this.Add(Customer.Get(item));
			}
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()
				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);

		#region Data Portal Methods
        protected override void DataPortal_Create()
        {
            base.DataPortal_Create();
			
			BeforeDataPortal_Create();
			
			//ValidationRules.CheckRules();
			
			AfterDataPortal_Create();
		}

		partial void BeforeDataPortal_Create();
		partial void AfterDataPortal_Create();
			
		private void DataPortal_Fetch()
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				ReadData(entities.Customers);
		}
		private void DataPortal_Fetch(Customer.Key key)
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
        	{
				var data = entities.Customers.Where(e => e.CustomerID == key.CustomerID);
				ReadData(data);
			}			
		}
		
		#endregion // Data Portal Methods
		
		#endregion // Data Access Layer
	}

	[Serializable]
	public partial class OrderDetail : Csla.BusinessBase<OrderDetail>
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
			// True, True
			protected static PropertyInfo<Product> ProductProperty = RegisterProperty<Product>(c => c.Product);
			public Product Product
			{
				 get { return GetProperty<Product>(ProductProperty); }
				 set 
				{
					SetProperty<Product>(ProductProperty, value);			
					SetProperty<int>(ProductIDProperty, value.ProductID);
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

			#region Factory Methods
			internal static OrderDetail New()
			{
				return DataPortal.CreateChild<OrderDetail>();
			}			

			internal static OrderDetail Get(CslaExtensionDemo.Library.Data.OrderDetail data)
			{
				if (data == null)
					return null;
					
				return DataPortal.FetchChild<OrderDetail>(data);				
			}
			#endregion // Factory Methods

			#region Data Access Layer
			#region Common Data Access Methods
			/// <summary>
			/// 
			/// </summary>
			private void ReadData(CslaExtensionDemo.Library.Data.OrderDetail data)
			{
				// Partial Method BeforeReadData
				BeforeReadData(data);
				
				// Load Data to Properties
				LoadProperty(OrderIDProperty, data.OrderID);
				LoadProperty(ProductIDProperty, data.ProductID);
				LoadProperty(UnitPriceProperty, data.UnitPrice);
				LoadProperty(QuantityProperty, data.Quantity);
				LoadProperty(DiscountProperty, data.Discount);
				
				// Load Data to Navigation Properties
				LoadProperty<Product>(ProductProperty, Product.Get(data.Product));
				
				// Partial Method AfterReadData
				AfterReadData(data);
			} // ReadData()
			
			partial void BeforeReadData(CslaExtensionDemo.Library.Data.OrderDetail data);
			partial void AfterReadData(CslaExtensionDemo.Library.Data.OrderDetail data);

			/// <summary>
			/// 
			/// </summary>
			private void WriteData(CslaExtensionDemo.Library.Data.OrderDetail data)
			{
				BeforeWriteData(data);
				
				data.OrderID = ReadProperty<int>(OrderIDProperty);
				data.ProductID = ReadProperty<int>(ProductIDProperty);
				data.UnitPrice = ReadProperty<decimal>(UnitPriceProperty);
				data.Quantity = ReadProperty<short>(QuantityProperty);
				data.Discount = ReadProperty<float>(DiscountProperty);

				AfterWriteData(data);
			} // WriteData()
			
			partial void BeforeWriteData(CslaExtensionDemo.Library.Data.OrderDetail data);
			partial void AfterWriteData(CslaExtensionDemo.Library.Data.OrderDetail data);
			#endregion // Common Data Access Methods

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
			

			private void Child_Fetch(CslaExtensionDemo.Library.Data.OrderDetail data)
			{
				BeforeFetch(data);
				ReadData(data);
				AfterFetch(data);				
			}
			partial void BeforeFetch(CslaExtensionDemo.Library.Data.OrderDetail data);
			partial void AfterFetch(CslaExtensionDemo.Library.Data.OrderDetail data);			
			
			//Insert
			private void Child_Insert()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = new CslaExtensionDemo.Library.Data.OrderDetail();
					BeforeInsert(data);
					WriteData(data);
					entities.Order_Details.AddObject(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterInsert(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeInsert(CslaExtensionDemo.Library.Data.OrderDetail data);
			partial void AfterInsert(CslaExtensionDemo.Library.Data.OrderDetail data);			
			
			//Update
			private void Child_Update()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = entities.Order_Details.Single(e => e.OrderID == this.OrderID && e.ProductID == this.ProductID);
					BeforeUpdate(data);
					WriteData(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterUpdate(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeUpdate(CslaExtensionDemo.Library.Data.OrderDetail data);
			partial void AfterUpdate(CslaExtensionDemo.Library.Data.OrderDetail data);			

			
			#endregion // Data Portal Methods
			#endregion // Data Access Layer
	} // class OrderDetail

	[Serializable]
	public partial class OrderDetailList : Csla.BusinessListBase<OrderDetailList, OrderDetail>
	{
		#region Factory Methods
		internal static OrderDetailList New()
		{
			return DataPortal.CreateChild<OrderDetailList>();
		}			
		internal static OrderDetailList Get(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data)
		{
			if (data == null)
				return null;
			return DataPortal.FetchChild<OrderDetailList>(data);				
		}

		#endregion // Factory Methods

		#region Data Access Layer

		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			foreach (var item in data)
			{
				this.Add(OrderDetail.Get(item));
			}
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()
				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);

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
			

		private void Child_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);			
				
		#endregion // Data Portal Methods
		
		#endregion // Data Access Layer
	}

	[Serializable]
	public partial class OrderInfo : Csla.ReadOnlyBase<OrderInfo>
	{
			#region Key
			internal class Key
			{
				public int OrderID;
				public string CompanyName;
				internal Key(int orderID, string companyName)
				{
					this.OrderID = orderID;
					this.CompanyName = companyName;
				}
			}
			#endregion
			
			#region Properties

			protected static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
			public int OrderID
			{
				 get { return GetProperty<int>(OrderIDProperty); }
			}

			protected static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
			public string CustomerID
			{
				 get { return GetProperty<string>(CustomerIDProperty); }
			}

			protected static PropertyInfo<int?> EmployeeIDProperty = RegisterProperty<int?>(c => c.EmployeeID);
			public int? EmployeeID
			{
				 get { return GetProperty<int?>(EmployeeIDProperty); }
			}

			protected static PropertyInfo<System.DateTime?> OrderDateProperty = RegisterProperty<System.DateTime?>(c => c.OrderDate);
			public System.DateTime? OrderDate
			{
				 get { return GetProperty<System.DateTime?>(OrderDateProperty); }
			}

			protected static PropertyInfo<System.DateTime?> RequiredDateProperty = RegisterProperty<System.DateTime?>(c => c.RequiredDate);
			public System.DateTime? RequiredDate
			{
				 get { return GetProperty<System.DateTime?>(RequiredDateProperty); }
			}

			protected static PropertyInfo<System.DateTime?> ShippedDateProperty = RegisterProperty<System.DateTime?>(c => c.ShippedDate);
			public System.DateTime? ShippedDate
			{
				 get { return GetProperty<System.DateTime?>(ShippedDateProperty); }
			}

			protected static PropertyInfo<int?> ShipViaProperty = RegisterProperty<int?>(c => c.ShipVia);
			public int? ShipVia
			{
				 get { return GetProperty<int?>(ShipViaProperty); }
			}

			protected static PropertyInfo<decimal?> FreightProperty = RegisterProperty<decimal?>(c => c.Freight);
			public decimal? Freight
			{
				 get { return GetProperty<decimal?>(FreightProperty); }
			}

			protected static PropertyInfo<string> ShipNameProperty = RegisterProperty<string>(c => c.ShipName);
			public string ShipName
			{
				 get { return GetProperty<string>(ShipNameProperty); }
			}

			protected static PropertyInfo<string> ShipAddressProperty = RegisterProperty<string>(c => c.ShipAddress);
			public string ShipAddress
			{
				 get { return GetProperty<string>(ShipAddressProperty); }
			}

			protected static PropertyInfo<string> ShipCityProperty = RegisterProperty<string>(c => c.ShipCity);
			public string ShipCity
			{
				 get { return GetProperty<string>(ShipCityProperty); }
			}

			protected static PropertyInfo<string> ShipRegionProperty = RegisterProperty<string>(c => c.ShipRegion);
			public string ShipRegion
			{
				 get { return GetProperty<string>(ShipRegionProperty); }
			}

			protected static PropertyInfo<string> ShipPostalCodeProperty = RegisterProperty<string>(c => c.ShipPostalCode);
			public string ShipPostalCode
			{
				 get { return GetProperty<string>(ShipPostalCodeProperty); }
			}

			protected static PropertyInfo<string> ShipCountryProperty = RegisterProperty<string>(c => c.ShipCountry);
			public string ShipCountry
			{
				 get { return GetProperty<string>(ShipCountryProperty); }
			}

			protected static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
			public string CompanyName
			{
				 get { return GetProperty<string>(CompanyNameProperty); }
			}

			protected static PropertyInfo<string> AddressProperty = RegisterProperty<string>(c => c.Address);
			public string Address
			{
				 get { return GetProperty<string>(AddressProperty); }
			}

			protected static PropertyInfo<string> CityProperty = RegisterProperty<string>(c => c.City);
			public string City
			{
				 get { return GetProperty<string>(CityProperty); }
			}

			protected static PropertyInfo<string> RegionProperty = RegisterProperty<string>(c => c.Region);
			public string Region
			{
				 get { return GetProperty<string>(RegionProperty); }
			}

			protected static PropertyInfo<string> PostalCodeProperty = RegisterProperty<string>(c => c.PostalCode);
			public string PostalCode
			{
				 get { return GetProperty<string>(PostalCodeProperty); }
			}

			protected static PropertyInfo<string> CountryProperty = RegisterProperty<string>(c => c.Country);
			public string Country
			{
				 get { return GetProperty<string>(CountryProperty); }
			}
			#endregion // Properties

			#region Navigation Properties
			#endregion // Navigation Properties

			#region Factory Methods
			internal static OrderInfo New()
			{
				return DataPortal.CreateChild<OrderInfo>();
			}			

			internal static OrderInfo Get(CslaExtensionDemo.Library.Data.OrderInfo data)
			{
				if (data == null)
					return null;
					
				return DataPortal.FetchChild<OrderInfo>(data);				
			}
			#endregion // Factory Methods

			#region Data Access Layer
			#region Common Data Access Methods
			/// <summary>
			/// 
			/// </summary>
			private void ReadData(CslaExtensionDemo.Library.Data.OrderInfo data)
			{
				// Partial Method BeforeReadData
				BeforeReadData(data);
				
				// Load Data to Properties
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
				LoadProperty(CompanyNameProperty, data.CompanyName);
				LoadProperty(AddressProperty, data.Address);
				LoadProperty(CityProperty, data.City);
				LoadProperty(RegionProperty, data.Region);
				LoadProperty(PostalCodeProperty, data.PostalCode);
				LoadProperty(CountryProperty, data.Country);
				
				// Load Data to Navigation Properties
				
				// Partial Method AfterReadData
				AfterReadData(data);
			} // ReadData()
			
			partial void BeforeReadData(CslaExtensionDemo.Library.Data.OrderInfo data);
			partial void AfterReadData(CslaExtensionDemo.Library.Data.OrderInfo data);
			#endregion // Common Data Access Methods

			#region Data Portal Methods
			

			private void Child_Fetch(CslaExtensionDemo.Library.Data.OrderInfo data)
			{
				BeforeFetch(data);
				ReadData(data);
				AfterFetch(data);				
			}
			partial void BeforeFetch(CslaExtensionDemo.Library.Data.OrderInfo data);
			partial void AfterFetch(CslaExtensionDemo.Library.Data.OrderInfo data);			
			
			
			#endregion // Data Portal Methods
			#endregion // Data Access Layer
	} // class OrderInfo

	[Serializable]
	public partial class OrderInfoList : Csla.ReadOnlyListBase<OrderInfoList, OrderInfo>
	{
		#region Factory Methods
			
		public static OrderInfo Get(int orderID, string companyName)
		{
			OrderInfoList result = DataPortal.Fetch<OrderInfoList>(new OrderInfo.Key(orderID, companyName));
			return result.FirstOrDefault();
		}
		
		public static OrderInfoList GetAll()
		{
			return DataPortal.Fetch<OrderInfoList>();
		}

		#endregion // Factory Methods

		#region Data Access Layer

		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			foreach (var item in data)
			{
				this.Add(OrderInfo.Get(item));
			}
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()
				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);

		#region Data Portal Methods
			
		private void DataPortal_Fetch()
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				ReadData(entities.OrderInfos);
		}
		private void DataPortal_Fetch(OrderInfo.Key key)
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
        	{
				var data = entities.OrderInfos.Where(e => e.OrderID == key.OrderID && e.CompanyName == key.CompanyName);
				ReadData(data);
			}			
		}
		
		#endregion // Data Portal Methods
		
		#endregion // Data Access Layer
	}

	[Serializable]
	public partial class Order : Csla.BusinessBase<Order>
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
			internal int OrderID
			{
				 get { return GetProperty<int>(OrderIDProperty); }
				private set { SetProperty<int>(OrderIDProperty, value); }
			}

			protected static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
			private string CustomerID
			{
				 get { return GetProperty<string>(CustomerIDProperty); }
				 set { SetProperty<string>(CustomerIDProperty, value); }
			}

			protected static PropertyInfo<int?> EmployeeIDProperty = RegisterProperty<int?>(c => c.EmployeeID);
			public int? EmployeeID
			{
				 get { return GetProperty<int?>(EmployeeIDProperty); }
				 set { SetProperty<int?>(EmployeeIDProperty, value); }
			}

			protected static PropertyInfo<System.DateTime?> OrderDateProperty = RegisterProperty<System.DateTime?>(c => c.OrderDate);
			public System.DateTime? OrderDate
			{
				 get { return GetProperty<System.DateTime?>(OrderDateProperty); }
				 set { SetProperty<System.DateTime?>(OrderDateProperty, value); }
			}

			protected static PropertyInfo<System.DateTime?> RequiredDateProperty = RegisterProperty<System.DateTime?>(c => c.RequiredDate);
			public System.DateTime? RequiredDate
			{
				 get { return GetProperty<System.DateTime?>(RequiredDateProperty); }
				 set { SetProperty<System.DateTime?>(RequiredDateProperty, value); }
			}

			protected static PropertyInfo<System.DateTime?> ShippedDateProperty = RegisterProperty<System.DateTime?>(c => c.ShippedDate);
			public System.DateTime? ShippedDate
			{
				 get { return GetProperty<System.DateTime?>(ShippedDateProperty); }
				 set { SetProperty<System.DateTime?>(ShippedDateProperty, value); }
			}

			protected static PropertyInfo<int?> ShipViaProperty = RegisterProperty<int?>(c => c.ShipVia);
			public int? ShipVia
			{
				 get { return GetProperty<int?>(ShipViaProperty); }
				 set { SetProperty<int?>(ShipViaProperty, value); }
			}

			protected static PropertyInfo<decimal?> FreightProperty = RegisterProperty<decimal?>(c => c.Freight);
			public decimal? Freight
			{
				 get { return GetProperty<decimal?>(FreightProperty); }
				 set { SetProperty<decimal?>(FreightProperty, value); }
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
			// True, True
			protected static PropertyInfo<Customer> CustomerProperty = RegisterProperty<Customer>(c => c.Customer);
			public Customer Customer
			{
				 get { return GetProperty<Customer>(CustomerProperty); }
				 set 
				{
					SetProperty<Customer>(CustomerProperty, value);			
					SetProperty<string>(CustomerIDProperty, value.CustomerID);
				}
			}
			// True, True
			protected static PropertyInfo<OrderDetailList> Order_DetailsProperty = RegisterProperty<OrderDetailList>(c => c.Order_Details);
			public OrderDetailList Order_Details
			{
				 get { return GetProperty<OrderDetailList>(Order_DetailsProperty); }
				private set 
				{
					SetProperty<OrderDetailList>(Order_DetailsProperty, value);			
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
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CustomerIDProperty, 5));
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

			#region Factory Methods
			public static Order New()
			{
				return DataPortal.Create<Order>();
			}			
			
			public static Order Get(int orderID)
			{
				return DataPortal.Fetch<Order>(new Key(orderID));
			}

			internal static Order Get(CslaExtensionDemo.Library.Data.Order data)
			{
				if (data == null)
					return null;
					
				return DataPortal.Fetch<Order>(data);				
			}
			#endregion // Factory Methods

			#region Data Access Layer
			#region Common Data Access Methods
			/// <summary>
			/// 
			/// </summary>
			private void ReadData(CslaExtensionDemo.Library.Data.Order data)
			{
				// Partial Method BeforeReadData
				BeforeReadData(data);
				
				// Load Data to Properties
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
				
				// Load Data to Navigation Properties
				LoadProperty<Customer>(CustomerProperty, Customer.Get(data.Customer));
				LoadProperty<OrderDetailList>(Order_DetailsProperty, OrderDetailList.Get(data.Order_Details));
				
				// Partial Method AfterReadData
				AfterReadData(data);
			} // ReadData()
			
			partial void BeforeReadData(CslaExtensionDemo.Library.Data.Order data);
			partial void AfterReadData(CslaExtensionDemo.Library.Data.Order data);

			/// <summary>
			/// 
			/// </summary>
			private void WriteData(CslaExtensionDemo.Library.Data.Order data)
			{
				BeforeWriteData(data);
				
				data.OrderID = ReadProperty<int>(OrderIDProperty);
				data.CustomerID = ReadProperty<string>(CustomerIDProperty);
				data.EmployeeID = ReadProperty<int?>(EmployeeIDProperty);
				data.OrderDate = ReadProperty<System.DateTime?>(OrderDateProperty);
				data.RequiredDate = ReadProperty<System.DateTime?>(RequiredDateProperty);
				data.ShippedDate = ReadProperty<System.DateTime?>(ShippedDateProperty);
				data.ShipVia = ReadProperty<int?>(ShipViaProperty);
				data.Freight = ReadProperty<decimal?>(FreightProperty);
				data.ShipName = ReadProperty<string>(ShipNameProperty);
				data.ShipAddress = ReadProperty<string>(ShipAddressProperty);
				data.ShipCity = ReadProperty<string>(ShipCityProperty);
				data.ShipRegion = ReadProperty<string>(ShipRegionProperty);
				data.ShipPostalCode = ReadProperty<string>(ShipPostalCodeProperty);
				data.ShipCountry = ReadProperty<string>(ShipCountryProperty);

				AfterWriteData(data);
			} // WriteData()
			
			partial void BeforeWriteData(CslaExtensionDemo.Library.Data.Order data);
			partial void AfterWriteData(CslaExtensionDemo.Library.Data.Order data);
			#endregion // Common Data Access Methods

			#region Data Portal Methods
            protected override void DataPortal_Create()
            {
                base.DataPortal_Create();
				
				BeforeDataPortal_Create();
				
				//ValidationRules.CheckRules();
				
				AfterDataPortal_Create();
			}

			partial void BeforeDataPortal_Create();
			partial void AfterDataPortal_Create();
			
			private void DataPortal_Fetch(Key key)
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
            	{
					var data = entities.Orders.Single(e => e.OrderID == key.OrderID);
					DataPortal_Fetch(data);
				}			
			}

			private void DataPortal_Fetch(CslaExtensionDemo.Library.Data.Order data)
			{
				BeforeFetch(data);
				ReadData(data);
				AfterFetch(data);				
			}
			partial void BeforeFetch(CslaExtensionDemo.Library.Data.Order data);
			partial void AfterFetch(CslaExtensionDemo.Library.Data.Order data);			
			
			//Insert
			private void DataPortal_Insert()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = new CslaExtensionDemo.Library.Data.Order();
					BeforeInsert(data);
					WriteData(data);
					entities.Orders.AddObject(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterInsert(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeInsert(CslaExtensionDemo.Library.Data.Order data);
			partial void AfterInsert(CslaExtensionDemo.Library.Data.Order data);			
			
			//Update
			private void DataPortal_Update()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = entities.Orders.Single(e => e.OrderID == this.OrderID);
					BeforeUpdate(data);
					WriteData(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterUpdate(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Order data);
			partial void AfterUpdate(CslaExtensionDemo.Library.Data.Order data);			

			
			#endregion // Data Portal Methods
			#endregion // Data Access Layer
	} // class Order

	[Serializable]
	public partial class Product : Csla.BusinessBase<Product>
	{
			#region Key
			internal class Key
			{
				public int ProductID;
				internal Key(int productID)
				{
					this.ProductID = productID;
				}
			}
			#endregion
			
			#region Properties

			protected static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
			public int ProductID
			{
				 get { return GetProperty<int>(ProductIDProperty); }
				 set { SetProperty<int>(ProductIDProperty, value); }
			}

			protected static PropertyInfo<string> ProductNameProperty = RegisterProperty<string>(c => c.ProductName);
			public string ProductName
			{
				 get { return GetProperty<string>(ProductNameProperty); }
				 set { SetProperty<string>(ProductNameProperty, value); }
			}

			protected static PropertyInfo<int?> SupplierIDProperty = RegisterProperty<int?>(c => c.SupplierID);
			public int? SupplierID
			{
				 get { return GetProperty<int?>(SupplierIDProperty); }
				 set { SetProperty<int?>(SupplierIDProperty, value); }
			}

			protected static PropertyInfo<int?> CategoryIDProperty = RegisterProperty<int?>(c => c.CategoryID);
			public int? CategoryID
			{
				 get { return GetProperty<int?>(CategoryIDProperty); }
				 set { SetProperty<int?>(CategoryIDProperty, value); }
			}

			protected static PropertyInfo<string> QuantityPerUnitProperty = RegisterProperty<string>(c => c.QuantityPerUnit);
			public string QuantityPerUnit
			{
				 get { return GetProperty<string>(QuantityPerUnitProperty); }
				 set { SetProperty<string>(QuantityPerUnitProperty, value); }
			}

			protected static PropertyInfo<decimal?> UnitPriceProperty = RegisterProperty<decimal?>(c => c.UnitPrice);
			public decimal? UnitPrice
			{
				 get { return GetProperty<decimal?>(UnitPriceProperty); }
				 set { SetProperty<decimal?>(UnitPriceProperty, value); }
			}

			protected static PropertyInfo<short?> UnitsInStockProperty = RegisterProperty<short?>(c => c.UnitsInStock);
			public short? UnitsInStock
			{
				 get { return GetProperty<short?>(UnitsInStockProperty); }
				 set { SetProperty<short?>(UnitsInStockProperty, value); }
			}

			protected static PropertyInfo<short?> UnitsOnOrderProperty = RegisterProperty<short?>(c => c.UnitsOnOrder);
			public short? UnitsOnOrder
			{
				 get { return GetProperty<short?>(UnitsOnOrderProperty); }
				 set { SetProperty<short?>(UnitsOnOrderProperty, value); }
			}

			protected static PropertyInfo<short?> ReorderLevelProperty = RegisterProperty<short?>(c => c.ReorderLevel);
			public short? ReorderLevel
			{
				 get { return GetProperty<short?>(ReorderLevelProperty); }
				 set { SetProperty<short?>(ReorderLevelProperty, value); }
			}

			protected static PropertyInfo<bool> DiscontinuedProperty = RegisterProperty<bool>(c => c.Discontinued);
			public bool Discontinued
			{
				 get { return GetProperty<bool>(DiscontinuedProperty); }
				 set { SetProperty<bool>(DiscontinuedProperty, value); }
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
				
                BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ProductIDProperty));
                BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ProductNameProperty));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ProductNameProperty, 40));
				BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(QuantityPerUnitProperty, 20));
                BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(DiscontinuedProperty));

				// Partial Method AfterAddBusinessRules
				AfterAddBusinessRules();
			}
			
			///
			/// Partial methods for adding additional business rules
			///
            partial void BeforeAddBusinessRules();
            partial void AfterAddBusinessRules();
			
			#endregion Business Rules

			#region Factory Methods
			internal static Product New()
			{
				return DataPortal.CreateChild<Product>();
			}			

			internal static Product Get(CslaExtensionDemo.Library.Data.Product data)
			{
				if (data == null)
					return null;
					
				return DataPortal.FetchChild<Product>(data);				
			}
			#endregion // Factory Methods

			#region Data Access Layer
			#region Common Data Access Methods
			/// <summary>
			/// 
			/// </summary>
			private void ReadData(CslaExtensionDemo.Library.Data.Product data)
			{
				// Partial Method BeforeReadData
				BeforeReadData(data);
				
				// Load Data to Properties
				LoadProperty(ProductIDProperty, data.ProductID);
				LoadProperty(ProductNameProperty, data.ProductName);
				LoadProperty(SupplierIDProperty, data.SupplierID);
				LoadProperty(CategoryIDProperty, data.CategoryID);
				LoadProperty(QuantityPerUnitProperty, data.QuantityPerUnit);
				LoadProperty(UnitPriceProperty, data.UnitPrice);
				LoadProperty(UnitsInStockProperty, data.UnitsInStock);
				LoadProperty(UnitsOnOrderProperty, data.UnitsOnOrder);
				LoadProperty(ReorderLevelProperty, data.ReorderLevel);
				LoadProperty(DiscontinuedProperty, data.Discontinued);
				
				// Load Data to Navigation Properties
				
				// Partial Method AfterReadData
				AfterReadData(data);
			} // ReadData()
			
			partial void BeforeReadData(CslaExtensionDemo.Library.Data.Product data);
			partial void AfterReadData(CslaExtensionDemo.Library.Data.Product data);

			/// <summary>
			/// 
			/// </summary>
			private void WriteData(CslaExtensionDemo.Library.Data.Product data)
			{
				BeforeWriteData(data);
				
				data.ProductID = ReadProperty<int>(ProductIDProperty);
				data.ProductName = ReadProperty<string>(ProductNameProperty);
				data.SupplierID = ReadProperty<int?>(SupplierIDProperty);
				data.CategoryID = ReadProperty<int?>(CategoryIDProperty);
				data.QuantityPerUnit = ReadProperty<string>(QuantityPerUnitProperty);
				data.UnitPrice = ReadProperty<decimal?>(UnitPriceProperty);
				data.UnitsInStock = ReadProperty<short?>(UnitsInStockProperty);
				data.UnitsOnOrder = ReadProperty<short?>(UnitsOnOrderProperty);
				data.ReorderLevel = ReadProperty<short?>(ReorderLevelProperty);
				data.Discontinued = ReadProperty<bool>(DiscontinuedProperty);

				AfterWriteData(data);
			} // WriteData()
			
			partial void BeforeWriteData(CslaExtensionDemo.Library.Data.Product data);
			partial void AfterWriteData(CslaExtensionDemo.Library.Data.Product data);
			#endregion // Common Data Access Methods

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
			

			private void Child_Fetch(CslaExtensionDemo.Library.Data.Product data)
			{
				BeforeFetch(data);
				ReadData(data);
				AfterFetch(data);				
			}
			partial void BeforeFetch(CslaExtensionDemo.Library.Data.Product data);
			partial void AfterFetch(CslaExtensionDemo.Library.Data.Product data);			
			
			//Insert
			private void Child_Insert()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = new CslaExtensionDemo.Library.Data.Product();
					BeforeInsert(data);
					WriteData(data);
					entities.Products.AddObject(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterInsert(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeInsert(CslaExtensionDemo.Library.Data.Product data);
			partial void AfterInsert(CslaExtensionDemo.Library.Data.Product data);			
			
			//Update
			private void Child_Update()
			{
            	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				{
					var data = entities.Products.Single(e => e.ProductID == this.ProductID);
					BeforeUpdate(data);
					WriteData(data);
					entities.SaveChanges();
					//TODO: Update database generated fields
					AfterUpdate(data);
					FieldManager.UpdateChildren();
				}//using
			}
			partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Product data);
			partial void AfterUpdate(CslaExtensionDemo.Library.Data.Product data);			

			
			#endregion // Data Portal Methods
			#endregion // Data Access Layer
	} // class Product

	[Serializable]
	public partial class ProductList : Csla.BusinessListBase<ProductList, Product>
	{
		#region Factory Methods
		public static ProductList New()
		{
			return DataPortal.Create<ProductList>();
		}			
			
		public static Product Get(int productID)
		{
			ProductList result = DataPortal.Fetch<ProductList>(new Product.Key(productID));
			return result.FirstOrDefault();
		}
		
		public static ProductList GetAll()
		{
			return DataPortal.Fetch<ProductList>();
		}

		#endregion // Factory Methods

		#region Data Access Layer

		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			foreach (var item in data)
			{
				this.Add(Product.Get(item));
			}
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()
				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);

		#region Data Portal Methods
        protected override void DataPortal_Create()
        {
            base.DataPortal_Create();
			
			BeforeDataPortal_Create();
			
			//ValidationRules.CheckRules();
			
			AfterDataPortal_Create();
		}

		partial void BeforeDataPortal_Create();
		partial void AfterDataPortal_Create();
			
		private void DataPortal_Fetch()
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
				ReadData(entities.Products);
		}
		private void DataPortal_Fetch(Product.Key key)
		{
        	using (var entities = new CslaExtensionDemo.Library.Data.NorthwindEntities2())
        	{
				var data = entities.Products.Where(e => e.ProductID == key.ProductID);
				ReadData(data);
			}			
		}
		
		#endregion // Data Portal Methods
		
		#endregion // Data Access Layer
	}
} // namespace CslaExtensionDemo.Library
