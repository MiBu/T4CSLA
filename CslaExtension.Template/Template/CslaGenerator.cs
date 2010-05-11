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

	#region Class Employee

	[Serializable]
	public partial class Employee : Csla.BusinessBase<Employee>, IEquatable<Employee>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			protected static PropertyInfo<int> EmployeeIDProperty = RegisterProperty<int>(c => c.EmployeeID);
			public int EmployeeID
			{
				get { return ReadProperty<int>(EmployeeIDProperty); }
				set { LoadProperty<int>(EmployeeIDProperty, value); }
			}

			public Key() { }
			public Key(int employeeID)
			{
				this.EmployeeID = employeeID;
			}
		}
		#endregion

		#region Properties

		protected static PropertyInfo<int> EmployeeIDProperty = RegisterProperty<int>(c => c.EmployeeID);
		public int EmployeeID
		{
			 get { return GetProperty<int>(EmployeeIDProperty); }
			 set { SetProperty<int>(EmployeeIDProperty, value); }
		}

		protected static PropertyInfo<string> LastNameProperty = RegisterProperty<string>(c => c.LastName);
		public string LastName
		{
			 get { return GetProperty<string>(LastNameProperty); }
			 set { SetProperty<string>(LastNameProperty, value); }
		}

		protected static PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(c => c.FirstName);
		public string FirstName
		{
			 get { return GetProperty<string>(FirstNameProperty); }
			 set { SetProperty<string>(FirstNameProperty, value); }
		}

		protected static PropertyInfo<string> TitleProperty = RegisterProperty<string>(c => c.Title);
		public string Title
		{
			 get { return GetProperty<string>(TitleProperty); }
			 set { SetProperty<string>(TitleProperty, value); }
		}

		protected static PropertyInfo<string> TitleOfCourtesyProperty = RegisterProperty<string>(c => c.TitleOfCourtesy);
		public string TitleOfCourtesy
		{
			 get { return GetProperty<string>(TitleOfCourtesyProperty); }
			 set { SetProperty<string>(TitleOfCourtesyProperty, value); }
		}

		protected static PropertyInfo<System.DateTime?> BirthDateProperty = RegisterProperty<System.DateTime?>(c => c.BirthDate);
		public System.DateTime? BirthDate
		{
			 get { return GetProperty<System.DateTime?>(BirthDateProperty); }
			 set { SetProperty<System.DateTime?>(BirthDateProperty, value); }
		}

		protected static PropertyInfo<System.DateTime?> HireDateProperty = RegisterProperty<System.DateTime?>(c => c.HireDate);
		public System.DateTime? HireDate
		{
			 get { return GetProperty<System.DateTime?>(HireDateProperty); }
			 set { SetProperty<System.DateTime?>(HireDateProperty, value); }
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

		protected static PropertyInfo<string> HomePhoneProperty = RegisterProperty<string>(c => c.HomePhone);
		public string HomePhone
		{
			 get { return GetProperty<string>(HomePhoneProperty); }
			 set { SetProperty<string>(HomePhoneProperty, value); }
		}

		protected static PropertyInfo<string> ExtensionProperty = RegisterProperty<string>(c => c.Extension);
		public string Extension
		{
			 get { return GetProperty<string>(ExtensionProperty); }
			 set { SetProperty<string>(ExtensionProperty, value); }
		}

		protected static PropertyInfo<byte[]> PhotoProperty = RegisterProperty<byte[]>(c => c.Photo);
		public byte[] Photo
		{
			 get { return GetProperty<byte[]>(PhotoProperty); }
			 set { SetProperty<byte[]>(PhotoProperty, value); }
		}

		protected static PropertyInfo<string> NotesProperty = RegisterProperty<string>(c => c.Notes);
		public string Notes
		{
			 get { return GetProperty<string>(NotesProperty); }
			 set { SetProperty<string>(NotesProperty, value); }
		}

		protected static PropertyInfo<int?> ReportsToProperty = RegisterProperty<int?>(c => c.ReportsTo);
		public int? ReportsTo
		{
			 get { return GetProperty<int?>(ReportsToProperty); }
			 set { SetProperty<int?>(ReportsToProperty, value); }
		}

		protected static PropertyInfo<string> PhotoPathProperty = RegisterProperty<string>(c => c.PhotoPath);
		public string PhotoPath
		{
			 get { return GetProperty<string>(PhotoPathProperty); }
			 set { SetProperty<string>(PhotoPathProperty, value); }
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
			
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(EmployeeIDProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(LastNameProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(LastNameProperty, 20));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(FirstNameProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(FirstNameProperty, 10));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(TitleProperty, 30));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(TitleOfCourtesyProperty, 25));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(AddressProperty, 60));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CityProperty, 15));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(RegionProperty, 15));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(PostalCodeProperty, 10));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CountryProperty, 15));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(HomePhoneProperty, 24));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(ExtensionProperty, 4));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(PhotoPathProperty, 255));

			// Partial Method AfterAddBusinessRules
			AfterAddBusinessRules();
		}
		
		///
		/// Partial methods for adding additional business rules
		///
        partial void BeforeAddBusinessRules();
        partial void AfterAddBusinessRules();
		
		#endregion Business Rules

		#region Default Constructor
		private Employee() { }
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Employee other)
        {
            if (other == null)
				return false;								

			if (this.EmployeeID != other.EmployeeID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Employee)
				return this.Equals((Employee)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return EmployeeID.GetHashCode();
        }
		
		public static bool operator == (Employee a, Employee b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Employee a, Employee b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
		internal static Employee New()
		{
			return DataPortal.CreateChild<Employee>();
		}			

		internal static Employee Get(CslaExtension.Template.Data.Employee data)
		{
			if (data == null)
				return null;
				
			return DataPortal.FetchChild<Employee>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtension.Template.Data.Employee data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtension.Template.Data.Employee data);
		partial void AfterReadData(CslaExtension.Template.Data.Employee data);

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtension.Template.Data.Employee data)
		{
			LoadProperty(EmployeeIDProperty, data.EmployeeID);
			LoadProperty(LastNameProperty, data.LastName);
			LoadProperty(FirstNameProperty, data.FirstName);
			LoadProperty(TitleProperty, data.Title);
			LoadProperty(TitleOfCourtesyProperty, data.TitleOfCourtesy);
			LoadProperty(BirthDateProperty, data.BirthDate);
			LoadProperty(HireDateProperty, data.HireDate);
			LoadProperty(AddressProperty, data.Address);
			LoadProperty(CityProperty, data.City);
			LoadProperty(RegionProperty, data.Region);
			LoadProperty(PostalCodeProperty, data.PostalCode);
			LoadProperty(CountryProperty, data.Country);
			LoadProperty(HomePhoneProperty, data.HomePhone);
			LoadProperty(ExtensionProperty, data.Extension);
			LoadProperty(PhotoProperty, data.Photo);
			LoadProperty(NotesProperty, data.Notes);
			LoadProperty(ReportsToProperty, data.ReportsTo);
			LoadProperty(PhotoPathProperty, data.PhotoPath);
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteData(CslaExtension.Template.Data.Employee data)
		{
			BeforeWriteData(data);
			
			data.EmployeeID = ReadProperty<int>(EmployeeIDProperty);
			data.LastName = ReadProperty<string>(LastNameProperty);
			data.FirstName = ReadProperty<string>(FirstNameProperty);
			data.Title = ReadProperty<string>(TitleProperty);
			data.TitleOfCourtesy = ReadProperty<string>(TitleOfCourtesyProperty);
			data.BirthDate = ReadProperty<System.DateTime?>(BirthDateProperty);
			data.HireDate = ReadProperty<System.DateTime?>(HireDateProperty);
			data.Address = ReadProperty<string>(AddressProperty);
			data.City = ReadProperty<string>(CityProperty);
			data.Region = ReadProperty<string>(RegionProperty);
			data.PostalCode = ReadProperty<string>(PostalCodeProperty);
			data.Country = ReadProperty<string>(CountryProperty);
			data.HomePhone = ReadProperty<string>(HomePhoneProperty);
			data.Extension = ReadProperty<string>(ExtensionProperty);
			data.Photo = ReadProperty<byte[]>(PhotoProperty);
			data.Notes = ReadProperty<string>(NotesProperty);
			data.ReportsTo = ReadProperty<int?>(ReportsToProperty);
			data.PhotoPath = ReadProperty<string>(PhotoPathProperty);

			AfterWriteData(data);
		} // WriteData()
		
		partial void BeforeWriteData(CslaExtension.Template.Data.Employee data);
		partial void AfterWriteData(CslaExtension.Template.Data.Employee data);
		#endregion // Common Data Access Methods

		#region Data Portal Methods
        protected override void Child_Create()
        {
            base.DataPortal_Create();				
			BeforeCreate();
			BusinessRules.CheckRules();
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void Child_Fetch(CslaExtension.Template.Data.Employee data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}			
		partial void BeforeFetch(CslaExtension.Template.Data.Employee data);
		partial void AfterFetch(CslaExtension.Template.Data.Employee data);			
		
		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				var data = new CslaExtension.Template.Data.Employee();					
				BeforeInsert(data);					
				WriteData(data);					
				ctx.ObjectContext.Employees.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadDataToProperties(data);					
				AfterInsert(data);					
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtension.Template.Data.Employee data);
		partial void AfterInsert(CslaExtension.Template.Data.Employee data);			
		
		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
			{
				if (this.IsSelfDirty)
				{
					var data = ctx.ObjectContext.Employees.Single(e => e.EmployeeID == this.EmployeeID);
					BeforeUpdate(data);					
					WriteData(data);
					ctx.ObjectContext.SaveChanges();
					LoadDataToProperties(data);
					AfterUpdate(data);
				}
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtension.Template.Data.Employee data);
		partial void AfterUpdate(CslaExtension.Template.Data.Employee data);
		
		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<int>(EmployeeIDProperty)));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
			{
				var data = ctx.ObjectContext.Employees.Single(e => e.EmployeeID == key.EmployeeID);
				BeforeDelete(data);
				ctx.ObjectContext.Employees.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtension.Template.Data.Employee data);
		partial void AfterDelete(CslaExtension.Template.Data.Employee data);		
		#endregion // Data Portal Methods
		#endregion // Data Access Layer
	} // end of class Employee
	#endregion // Class Employee

	#region Class EmployeeList

	[Serializable]
	public partial class EmployeeList : Csla.BusinessListBase<EmployeeList, Employee>
	{

		#region Default Constructor
		private EmployeeList() { }
		#endregion

		#region Asynchronous Factory Methods
		public static void Get(int employeeID, EventHandler<DataPortalResult<EmployeeList>> callback)
		{
			var dp = new DataPortal<EmployeeList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Employee.Key(employeeID));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<EmployeeList>> callback)
		{
			var dp = new DataPortal<EmployeeList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
		public static EmployeeList New()
		{
			return DataPortal.Create<EmployeeList>();
		}			
			
		public static Employee Get(int employeeID)
		{
			EmployeeList result = DataPortal.Fetch<EmployeeList>(new Employee.Key(employeeID));
			return result.FirstOrDefault();
		}
		
		public static EmployeeList GetAll()
		{
			return DataPortal.Fetch<EmployeeList>();
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtension.Template.Data.Employee> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;

			foreach (var item in data)
				this.Add(Employee.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtension.Template.Data.Employee> data);
		partial void AfterReadData(IEnumerable<CslaExtension.Template.Data.Employee> data);
		#endregion

		#region Data Portal Methods
        protected override void DataPortal_Create()
        {
            base.DataPortal_Create();			
			BeforeCreate();			
			//BusinessRules.CheckRules();			
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void DataPortal_Fetch()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))            	
				ReadData(ctx.ObjectContext.Employees);
		}

		private void DataPortal_Fetch(Employee.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
        	{
				var data = ctx.ObjectContext.Employees.Where(e => e.EmployeeID == key.EmployeeID);
				ReadData(data);
			}
		}

		protected override void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
			{
				Child_Update();
			}
		}
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class EmployeeList

	#region Class Order_Detail

	[Serializable]
	public partial class Order_Detail : Csla.BusinessBase<Order_Detail>, IEquatable<Order_Detail>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			protected static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
			public int OrderID
			{
				get { return ReadProperty<int>(OrderIDProperty); }
				set { LoadProperty<int>(OrderIDProperty, value); }
			}

			protected static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
			public int ProductID
			{
				get { return ReadProperty<int>(ProductIDProperty); }
				set { LoadProperty<int>(ProductIDProperty, value); }
			}

			public Key() { }
			public Key(int orderID, int productID)
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

		#region Default Constructor
		private Order_Detail() { }
		#endregion

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
			BusinessRules.CheckRules();
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<int>(OrderIDProperty), ReadProperty<int>(ProductIDProperty)));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
			{
				var data = ctx.ObjectContext.Order_Details.Single(e => e.OrderID == key.OrderID && e.ProductID == key.ProductID);
				BeforeDelete(data);
				ctx.ObjectContext.Order_Details.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtension.Template.Data.Order_Detail data);
		partial void AfterDelete(CslaExtension.Template.Data.Order_Detail data);		
		#endregion // Data Portal Methods
		#endregion // Data Access Layer
	} // end of class Order_Detail
	#endregion // Class Order_Detail

	#region Class Order_DetailList

	[Serializable]
	public partial class Order_DetailList : Csla.BusinessListBase<Order_DetailList, Order_Detail>
	{

		#region Default Constructor
		private Order_DetailList() { }
		#endregion

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
				this.Add(Order_Detail.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);
		partial void AfterReadData(IEnumerable<CslaExtension.Template.Data.Order_Detail> data);
		#endregion

		#region Data Portal Methods
        protected override void Child_Create()
        {
            base.Child_Create();			
			BeforeCreate();			
			//BusinessRules.CheckRules();			
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

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
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			protected static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
			public int OrderID
			{
				get { return ReadProperty<int>(OrderIDProperty); }
				set { LoadProperty<int>(OrderIDProperty, value); }
			}

			public Key() { }
			public Key(int orderID)
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

		protected static PropertyInfo<System.DateTime> ShippedDateProperty = RegisterProperty<System.DateTime>(c => c.ShippedDate);
		public System.DateTime ShippedDate
		{
			 get { return GetProperty<System.DateTime>(ShippedDateProperty); }
			 set { SetProperty<System.DateTime>(ShippedDateProperty, value); }
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
		#endregion // Navigation Properties

		#region Business Rules
		protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
			
			// Partial Method BeforeAddBusinessRules
			BeforeAddBusinessRules();
			
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(OrderIDProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CustomerIDProperty, 5));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(ShippedDateProperty));
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

		#region Default Constructor
		private Order() { }
		#endregion

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
		
		public static void Delete(int orderID)
		{
			DataPortal.Delete<Order>(new Key(orderID));
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
			data.EmployeeID = ReadProperty<int?>(EmployeeIDProperty);
			data.OrderDate = ReadProperty<System.DateTime?>(OrderDateProperty);
			data.RequiredDate = ReadProperty<System.DateTime?>(RequiredDateProperty);
			data.ShippedDate = ReadProperty<System.DateTime>(ShippedDateProperty);
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
		
		partial void BeforeWriteData(CslaExtension.Template.Data.Order data);
		partial void AfterWriteData(CslaExtension.Template.Data.Order data);
		#endregion // Common Data Access Methods

		#region Data Portal Methods
        protected override void DataPortal_Create()
        {
            base.DataPortal_Create();				
			BeforeCreate();
			BusinessRules.CheckRules();
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
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
		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new Key(ReadProperty<int>(OrderIDProperty)));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtension.Template.Data.Entities>.GetManager("Entities"))
			{
				var data = ctx.ObjectContext.Orders.Single(e => e.OrderID == key.OrderID);
				BeforeDelete(data);
				ctx.ObjectContext.Orders.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtension.Template.Data.Order data);
		partial void AfterDelete(CslaExtension.Template.Data.Order data);		
		#endregion // Data Portal Methods
		#endregion // Data Access Layer
	} // end of class Order
	#endregion // Class Order
} // end of namespace CslaExtension.Template.Business
