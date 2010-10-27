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


namespace CslaExtensionDemo.Library
{

	#region Class Categories

	[Serializable]
	public partial class Categories : Csla.BusinessBase<Categories>, IEquatable<Categories>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> CategoryIDProperty = RegisterProperty<int>(c => c.CategoryID);
			public int CategoryID
			{
				get { return ReadProperty<int>(CategoryIDProperty); }
				set { LoadProperty<int>(CategoryIDProperty, value); }
			}

			public Key() { }
			public Key(int categoryID)
			{
				this.CategoryID = categoryID;
			}
		}
		#endregion

		#region Properties
			
		public static PropertyInfo<byte[]> EntityKeyProperty = RegisterProperty<byte []>(c => c.EntityKey);
		public byte[] EntityKey
		{
			get { return GetProperty<byte[]>(EntityKeyProperty); }
			set { SetProperty<byte[]>(EntityKeyProperty, value); }
		}
  
		public static PropertyInfo<int> CategoryIDProperty = RegisterProperty<int>(c => c.CategoryID);
		public int CategoryID
		{
			get { return GetProperty<int>(CategoryIDProperty); }
			set { SetProperty<int>(CategoryIDProperty, value); }
		}

		public static PropertyInfo<string> CategoryNameProperty = RegisterProperty<string>(c => c.CategoryName);
		public string CategoryName
		{
			get { return GetProperty<string>(CategoryNameProperty); }
			set { SetProperty<string>(CategoryNameProperty, value); }
		}

		public static PropertyInfo<string> DescriptionProperty = RegisterProperty<string>(c => c.Description);
		public string Description
		{
			get { return GetProperty<string>(DescriptionProperty); }
			set { SetProperty<string>(DescriptionProperty, value); }
		}

		public static PropertyInfo<byte[]> PictureProperty = RegisterProperty<byte[]>(c => c.Picture);
		public byte[] Picture
		{
			get { return GetProperty<byte[]>(PictureProperty); }
			set { SetProperty<byte[]>(PictureProperty, value); }
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
			
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(CategoryIDProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(CategoryNameProperty));
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CategoryNameProperty, 15));

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
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public Categories() { }
#else
		private Categories() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Categories other)
        {
            if (other == null)
				return false;								

			if (this.CategoryID != other.CategoryID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Categories)
				return this.Equals((Categories)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return CategoryID.GetHashCode();
        }
		
		public static bool operator == (Categories a, Categories b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Categories a, Categories b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
		internal static Categories New()
		{
			return DataPortal.CreateChild<Categories>();
		}
		

		internal static Categories Get(CslaExtensionDemo.Library.Data.Categories data)
		{
			if (data == null)
				return null;
				
			return DataPortal.FetchChild<Categories>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.Categories data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.Categories Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.Categories data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.Categories data);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        System.Data.EntityKey GetEntityKey()
        {
            using (var buffer = new System.IO.MemoryStream(ReadProperty<byte[]>(EntityKeyProperty)))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return formatter.Deserialize(buffer) as System.Data.EntityKey;
            }
        }
		
		/// <summary>
		///
		/// </summary>
		private void LoadEntityKey(CslaExtensionDemo.Library.Data.Categories data)
		{
			//Load EntityKey
			using (var buffer = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(buffer, data.EntityKey);
                LoadProperty(EntityKeyProperty, buffer.ToArray());
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.Categories data)
		{
			LoadProperty(CategoryIDProperty, data.CategoryID);
			LoadProperty(CategoryNameProperty, data.CategoryName);
			LoadProperty(DescriptionProperty, data.Description);
			LoadProperty(PictureProperty, data.Picture);
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteKeyData(CslaExtensionDemo.Library.Data.Categories data)
		{
			BeforeWriteKeyData(data);
			
			data.CategoryID = ReadProperty<int>(CategoryIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterWriteKeyData(CslaExtensionDemo.Library.Data.Categories data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.Library.Data.Categories data)
		{
			BeforeWriteNonKeyData(data);
			
			data.CategoryName = ReadProperty<string>(CategoryNameProperty);
			data.Description = ReadProperty<string>(DescriptionProperty);
			data.Picture = ReadProperty<byte[]>(PictureProperty);

			AfterWriteNonKeyData(data);
		} // WriteNonKeyData()
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.Library.Data.Categories data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteData(CslaExtensionDemo.Library.Data.Categories data)
		{
			BeforeWriteData(data);
			
			data.CategoryID = ReadProperty<int>(CategoryIDProperty);
			data.CategoryName = ReadProperty<string>(CategoryNameProperty);
			data.Description = ReadProperty<string>(DescriptionProperty);
			data.Picture = ReadProperty<byte[]>(PictureProperty);

			AfterWriteData(data);
		} // WriteData()
		
		partial void BeforeWriteData(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterWriteData(CslaExtensionDemo.Library.Data.Categories data);
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
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.Categories data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			LoadEntityKey(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.Categories data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
				var data = new CslaExtensionDemo.Library.Data.Categories();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Categories.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadEntityKey(data);
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterInsert(CslaExtensionDemo.Library.Data.Categories data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
                var objectStateManager = ctx.ObjectContext.ObjectStateManager;
                System.Data.Objects.ObjectStateEntry stateEntry = null;
                System.Data.EntityKey entityKey = GetEntityKey();
                CslaExtensionDemo.Library.Data.Categories data = null;

                if (objectStateManager.TryGetObjectStateEntry(entityKey, out stateEntry))
                    data = ctx.ObjectContext.Categories.Single(e => e.CategoryID == this.CategoryID);

				if (this.IsSelfDirty)
				{	
                    if (data == null)
                    {
						data = ctx.ObjectContext.Categories.CreateObject();
						WriteKeyData(data);
						data.EntityKey = entityKey;
						ctx.ObjectContext.Attach(data);
                    }					
					
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					LoadEntityKey(data);
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterUpdate(CslaExtensionDemo.Library.Data.Categories data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<int>(CategoryIDProperty)));
		}

		
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Categories.Single(e => e.CategoryID == key.CategoryID);
				BeforeDelete(data);
				ctx.ObjectContext.Categories.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.Library.Data.Categories data);
		partial void AfterDelete(CslaExtensionDemo.Library.Data.Categories data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Categories
	#endregion // Class Categories

	#region Class CategoriesList

	[Serializable]
	public partial class CategoriesList : Csla.BusinessListBase<CategoriesList, Categories>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public CategoriesList() { }
#else
		private CategoriesList() { }
#endif
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<CategoriesList>> callback)
        {
            var dp = new DataPortal<CategoriesList>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }

		public static void Get(int categoryID, EventHandler<DataPortalResult<CategoriesList>> callback)
		{
			var dp = new DataPortal<CategoriesList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Categories.Key(categoryID));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<CategoriesList>> callback)
		{
			var dp = new DataPortal<CategoriesList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
		public static CategoriesList New()
		{
			return DataPortal.Create<CategoriesList>();
		}			
			
		public static Categories Get(int categoryID)
		{
			CategoriesList result = DataPortal.Fetch<CategoriesList>(new Categories.Key(categoryID));
			return result.FirstOrDefault();
		}
		
		public static CategoriesList GetAll()
		{
			return DataPortal.Fetch<CategoriesList>();
		}
		internal static CategoriesList Get(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data)
		{
			if (data == null)
				return null;
			return DataPortal.Fetch<CategoriesList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;

			foreach (var item in data)
				this.Add(Categories.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data);
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
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
				ReadData(ctx.ObjectContext.Categories);
		}

		private void DataPortal_Fetch(Categories.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
        	{
				var data = ctx.ObjectContext.Categories.Where(e => e.CategoryID == key.CategoryID);
				ReadData(data);
			}
		}

		protected override void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				Child_Update();
			}
		}

		private void DataPortal_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.Categories> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class CategoriesList

	#region Class Customer

	[Serializable]
	public partial class Customer : Csla.BusinessBase<Customer>, IEquatable<Customer>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
			public string CustomerID
			{
				get { return ReadProperty<string>(CustomerIDProperty); }
				set { LoadProperty<string>(CustomerIDProperty, value); }
			}

			public Key() { }
			public Key(string customerID)
			{
				this.CustomerID = customerID;
			}
		}
		#endregion

		#region Properties
			
		public static PropertyInfo<byte[]> EntityKeyProperty = RegisterProperty<byte []>(c => c.EntityKey);
		public byte[] EntityKey
		{
			get { return GetProperty<byte[]>(EntityKeyProperty); }
			set { SetProperty<byte[]>(EntityKeyProperty, value); }
		}
  
		public static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
		internal string CustomerID
		{
			get { return GetProperty<string>(CustomerIDProperty); }
			private set { SetProperty<string>(CustomerIDProperty, value); }
		}

		public static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
		public string CompanyName
		{
			get { return GetProperty<string>(CompanyNameProperty); }
			set { SetProperty<string>(CompanyNameProperty, value); }
		}

		public static PropertyInfo<string> ContactNameProperty = RegisterProperty<string>(c => c.ContactName);
		public string ContactName
		{
			get { return GetProperty<string>(ContactNameProperty); }
			set { SetProperty<string>(ContactNameProperty, value); }
		}

		public static PropertyInfo<string> ContactTitleProperty = RegisterProperty<string>(c => c.ContactTitle);
		public string ContactTitle
		{
			get { return GetProperty<string>(ContactTitleProperty); }
			set { SetProperty<string>(ContactTitleProperty, value); }
		}

		public static PropertyInfo<string> AddressProperty = RegisterProperty<string>(c => c.Address);
		public string Address
		{
			get { return GetProperty<string>(AddressProperty); }
			set { SetProperty<string>(AddressProperty, value); }
		}

		public static PropertyInfo<string> CityProperty = RegisterProperty<string>(c => c.City);
		public string City
		{
			get { return GetProperty<string>(CityProperty); }
			set { SetProperty<string>(CityProperty, value); }
		}

		public static PropertyInfo<string> RegionProperty = RegisterProperty<string>(c => c.Region);
		public string Region
		{
			get { return GetProperty<string>(RegionProperty); }
			set { SetProperty<string>(RegionProperty, value); }
		}

		public static PropertyInfo<string> PostalCodeProperty = RegisterProperty<string>(c => c.PostalCode);
		public string PostalCode
		{
			get { return GetProperty<string>(PostalCodeProperty); }
			set { SetProperty<string>(PostalCodeProperty, value); }
		}

		public static PropertyInfo<string> CountryProperty = RegisterProperty<string>(c => c.Country);
		public string Country
		{
			get { return GetProperty<string>(CountryProperty); }
			set { SetProperty<string>(CountryProperty, value); }
		}

		public static PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
		public string Phone
		{
			get { return GetProperty<string>(PhoneProperty); }
			set { SetProperty<string>(PhoneProperty, value); }
		}

		public static PropertyInfo<string> FaxProperty = RegisterProperty<string>(c => c.Fax);
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

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public Customer() { }
#else
		private Customer() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Customer other)
        {
            if (other == null)
				return false;								

			if (this.CustomerID != other.CustomerID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Customer)
				return this.Equals((Customer)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return CustomerID.GetHashCode();
        }
		
		public static bool operator == (Customer a, Customer b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Customer a, Customer b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
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
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.Customer data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.Customer Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.Customer data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.Customer data);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        System.Data.EntityKey GetEntityKey()
        {
            using (var buffer = new System.IO.MemoryStream(ReadProperty<byte[]>(EntityKeyProperty)))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return formatter.Deserialize(buffer) as System.Data.EntityKey;
            }
        }
		
		/// <summary>
		///
		/// </summary>
		private void LoadEntityKey(CslaExtensionDemo.Library.Data.Customer data)
		{
			//Load EntityKey
			using (var buffer = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(buffer, data.EntityKey);
                LoadProperty(EntityKeyProperty, buffer.ToArray());
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.Customer data)
		{
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
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteKeyData(CslaExtensionDemo.Library.Data.Customer data)
		{
			BeforeWriteKeyData(data);
			
			data.CustomerID = ReadProperty<string>(CustomerIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterWriteKeyData(CslaExtensionDemo.Library.Data.Customer data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.Library.Data.Customer data)
		{
			BeforeWriteNonKeyData(data);
			
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

			AfterWriteNonKeyData(data);
		} // WriteNonKeyData()
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.Library.Data.Customer data);

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
			BeforeCreate();
			BusinessRules.CheckRules();
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.Customer data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			LoadEntityKey(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.Customer data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
				var data = new CslaExtensionDemo.Library.Data.Customer();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Customers.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadEntityKey(data);
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterInsert(CslaExtensionDemo.Library.Data.Customer data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
                var objectStateManager = ctx.ObjectContext.ObjectStateManager;
                System.Data.Objects.ObjectStateEntry stateEntry = null;
                System.Data.EntityKey entityKey = GetEntityKey();
                CslaExtensionDemo.Library.Data.Customer data = null;

                if (objectStateManager.TryGetObjectStateEntry(entityKey, out stateEntry))
                    data = ctx.ObjectContext.Customers.Single(e => e.CustomerID == this.CustomerID);

				if (this.IsSelfDirty)
				{	
                    if (data == null)
                    {
						data = ctx.ObjectContext.Customers.CreateObject();
						WriteKeyData(data);
						data.EntityKey = entityKey;
						ctx.ObjectContext.Attach(data);
                    }					
					
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					LoadEntityKey(data);
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterUpdate(CslaExtensionDemo.Library.Data.Customer data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<string>(CustomerIDProperty)));
		}

		
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Customers.Single(e => e.CustomerID == key.CustomerID);
				BeforeDelete(data);
				ctx.ObjectContext.Customers.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.Library.Data.Customer data);
		partial void AfterDelete(CslaExtensionDemo.Library.Data.Customer data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Customer
	#endregion // Class Customer

	#region Class CustomerList

	[Serializable]
	public partial class CustomerList : Csla.BusinessListBase<CustomerList, Customer>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public CustomerList() { }
#else
		private CustomerList() { }
#endif
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<CustomerList>> callback)
        {
            var dp = new DataPortal<CustomerList>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }

		public static void Get(string customerID, EventHandler<DataPortalResult<CustomerList>> callback)
		{
			var dp = new DataPortal<CustomerList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Customer.Key(customerID));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<CustomerList>> callback)
		{
			var dp = new DataPortal<CustomerList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
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
		internal static CustomerList Get(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data)
		{
			if (data == null)
				return null;
			return DataPortal.Fetch<CustomerList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;

			foreach (var item in data)
				this.Add(Customer.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);
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
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
				ReadData(ctx.ObjectContext.Customers);
		}

		private void DataPortal_Fetch(Customer.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
        	{
				var data = ctx.ObjectContext.Customers.Where(e => e.CustomerID == key.CustomerID);
				ReadData(data);
			}
		}

		protected override void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				Child_Update();
			}
		}

		private void DataPortal_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.Customer> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class CustomerList

	#region Class OrderDetail

	[Serializable]
	public partial class OrderDetail : Csla.BusinessBase<OrderDetail>, IEquatable<OrderDetail>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
			public int OrderID
			{
				get { return ReadProperty<int>(OrderIDProperty); }
				set { LoadProperty<int>(OrderIDProperty, value); }
			}

			public static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
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
			
		public static PropertyInfo<byte[]> EntityKeyProperty = RegisterProperty<byte []>(c => c.EntityKey);
		public byte[] EntityKey
		{
			get { return GetProperty<byte[]>(EntityKeyProperty); }
			set { SetProperty<byte[]>(EntityKeyProperty, value); }
		}
  
		public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
		public int OrderID
		{
			get { return GetProperty<int>(OrderIDProperty); }
			set { SetProperty<int>(OrderIDProperty, value); }
		}

		public static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
		public int ProductID
		{
			get { return GetProperty<int>(ProductIDProperty); }
			set { SetProperty<int>(ProductIDProperty, value); }
		}

		public static PropertyInfo<decimal> UnitPriceProperty = RegisterProperty<decimal>(c => c.UnitPrice);
		public decimal UnitPrice
		{
			get { return GetProperty<decimal>(UnitPriceProperty); }
			set { SetProperty<decimal>(UnitPriceProperty, value); }
		}

		public static PropertyInfo<short> QuantityProperty = RegisterProperty<short>(c => c.Quantity);
		public short Quantity
		{
			get { return GetProperty<short>(QuantityProperty); }
			set { SetProperty<short>(QuantityProperty, value); }
		}

		public static PropertyInfo<float> DiscountProperty = RegisterProperty<float>(c => c.Discount);
		public float Discount
		{
			get { return GetProperty<float>(DiscountProperty); }
			set { SetProperty<float>(DiscountProperty, value); }
		}
		#endregion // Properties

		#region Navigation Properties
		
		public static PropertyInfo<Product> ProductProperty = RegisterProperty<Product>(c => c.Product);
		public Product Product
		{
			get { return GetProperty<Product>(ProductProperty); }
			set 
			{
				SetProperty<Product>(ProductProperty, value);			
				if (value != null)
					SetProperty<int>(ProductIDProperty, value.ProductID);
				else
					SetProperty<int>(ProductIDProperty, default(int));
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
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public OrderDetail() { }
#else
		private OrderDetail() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(OrderDetail other)
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
			if (obj is OrderDetail)
				return this.Equals((OrderDetail)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return OrderID.GetHashCode() ^ ProductID.GetHashCode();
        }
		
		public static bool operator == (OrderDetail a, OrderDetail b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (OrderDetail a, OrderDetail b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
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
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.OrderDetail data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.OrderDetail Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.OrderDetail data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
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
        /// <returns></returns>
        System.Data.EntityKey GetEntityKey()
        {
            using (var buffer = new System.IO.MemoryStream(ReadProperty<byte[]>(EntityKeyProperty)))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return formatter.Deserialize(buffer) as System.Data.EntityKey;
            }
        }
		
		/// <summary>
		///
		/// </summary>
		private void LoadEntityKey(CslaExtensionDemo.Library.Data.OrderDetail data)
		{
			//Load EntityKey
			using (var buffer = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(buffer, data.EntityKey);
                LoadProperty(EntityKeyProperty, buffer.ToArray());
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.OrderDetail data)
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
		private void WriteKeyData(CslaExtensionDemo.Library.Data.OrderDetail data)
		{
			BeforeWriteKeyData(data);
			
			data.OrderID = ReadProperty<int>(OrderIDProperty);
			data.ProductID = ReadProperty<int>(ProductIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterWriteKeyData(CslaExtensionDemo.Library.Data.OrderDetail data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.Library.Data.OrderDetail data)
		{
			BeforeWriteNonKeyData(data);
			
			data.UnitPrice = ReadProperty<decimal>(UnitPriceProperty);
			data.Quantity = ReadProperty<short>(QuantityProperty);
			data.Discount = ReadProperty<float>(DiscountProperty);

			AfterWriteNonKeyData(data);
		} // WriteNonKeyData()
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.Library.Data.OrderDetail data);

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
			BeforeCreate();
			BusinessRules.CheckRules();
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.OrderDetail data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			LoadEntityKey(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.OrderDetail data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
				var data = new CslaExtensionDemo.Library.Data.OrderDetail();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Order_Details.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadEntityKey(data);
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterInsert(CslaExtensionDemo.Library.Data.OrderDetail data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
                var objectStateManager = ctx.ObjectContext.ObjectStateManager;
                System.Data.Objects.ObjectStateEntry stateEntry = null;
                System.Data.EntityKey entityKey = GetEntityKey();
                CslaExtensionDemo.Library.Data.OrderDetail data = null;

                if (objectStateManager.TryGetObjectStateEntry(entityKey, out stateEntry))
                    data = ctx.ObjectContext.Order_Details.Single(e => e.OrderID == this.OrderID && e.ProductID == this.ProductID);

				if (this.IsSelfDirty)
				{	
                    if (data == null)
                    {
						data = ctx.ObjectContext.Order_Details.CreateObject();
						WriteKeyData(data);
						data.EntityKey = entityKey;
						ctx.ObjectContext.Attach(data);
                    }					
					
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					LoadEntityKey(data);
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterUpdate(CslaExtensionDemo.Library.Data.OrderDetail data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<int>(OrderIDProperty), ReadProperty<int>(ProductIDProperty)));
		}

		
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Order_Details.Single(e => e.OrderID == key.OrderID && e.ProductID == key.ProductID);
				BeforeDelete(data);
				ctx.ObjectContext.Order_Details.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.Library.Data.OrderDetail data);
		partial void AfterDelete(CslaExtensionDemo.Library.Data.OrderDetail data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class OrderDetail
	#endregion // Class OrderDetail

	#region Class OrderDetailList

	[Serializable]
	public partial class OrderDetailList : Csla.BusinessListBase<OrderDetailList, OrderDetail>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public OrderDetailList() { }
#else
		private OrderDetailList() { }
#endif
		#endregion

		#region Synchronous Factory Methods
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
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;

			foreach (var item in data)
				this.Add(OrderDetail.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderDetail> data);
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
	#endregion // Class OrderDetailList

	#region Class OrderInfo

	[Serializable]
	public partial class OrderInfo : Csla.ReadOnlyBase<OrderInfo>, IEquatable<OrderInfo>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
			public int OrderID
			{
				get { return ReadProperty<int>(OrderIDProperty); }
				set { LoadProperty<int>(OrderIDProperty, value); }
			}

			public static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
			public string CompanyName
			{
				get { return ReadProperty<string>(CompanyNameProperty); }
				set { LoadProperty<string>(CompanyNameProperty, value); }
			}

			public Key() { }
			public Key(int orderID, string companyName)
			{
				this.OrderID = orderID;
				this.CompanyName = companyName;
			}
		}
		#endregion

		#region Properties
 
		public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
		public int OrderID
		{
			get { return GetProperty<int>(OrderIDProperty); }
		}

		public static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
		public string CustomerID
		{
			get { return GetProperty<string>(CustomerIDProperty); }
		}

		public static PropertyInfo<int?> EmployeeIDProperty = RegisterProperty<int?>(c => c.EmployeeID);
		public int? EmployeeID
		{
			get { return GetProperty<int?>(EmployeeIDProperty); }
		}

		public static PropertyInfo<System.DateTime?> OrderDateProperty = RegisterProperty<System.DateTime?>(c => c.OrderDate);
		public System.DateTime? OrderDate
		{
			get { return GetProperty<System.DateTime?>(OrderDateProperty); }
		}

		public static PropertyInfo<System.DateTime?> RequiredDateProperty = RegisterProperty<System.DateTime?>(c => c.RequiredDate);
		public System.DateTime? RequiredDate
		{
			get { return GetProperty<System.DateTime?>(RequiredDateProperty); }
		}

		public static PropertyInfo<System.DateTime?> ShippedDateProperty = RegisterProperty<System.DateTime?>(c => c.ShippedDate);
		public System.DateTime? ShippedDate
		{
			get { return GetProperty<System.DateTime?>(ShippedDateProperty); }
		}

		public static PropertyInfo<int?> ShipViaProperty = RegisterProperty<int?>(c => c.ShipVia);
		public int? ShipVia
		{
			get { return GetProperty<int?>(ShipViaProperty); }
		}

		public static PropertyInfo<decimal?> FreightProperty = RegisterProperty<decimal?>(c => c.Freight);
		public decimal? Freight
		{
			get { return GetProperty<decimal?>(FreightProperty); }
		}

		public static PropertyInfo<string> ShipNameProperty = RegisterProperty<string>(c => c.ShipName);
		public string ShipName
		{
			get { return GetProperty<string>(ShipNameProperty); }
		}

		public static PropertyInfo<string> ShipAddressProperty = RegisterProperty<string>(c => c.ShipAddress);
		public string ShipAddress
		{
			get { return GetProperty<string>(ShipAddressProperty); }
		}

		public static PropertyInfo<string> ShipCityProperty = RegisterProperty<string>(c => c.ShipCity);
		public string ShipCity
		{
			get { return GetProperty<string>(ShipCityProperty); }
		}

		public static PropertyInfo<string> ShipRegionProperty = RegisterProperty<string>(c => c.ShipRegion);
		public string ShipRegion
		{
			get { return GetProperty<string>(ShipRegionProperty); }
		}

		public static PropertyInfo<string> ShipPostalCodeProperty = RegisterProperty<string>(c => c.ShipPostalCode);
		public string ShipPostalCode
		{
			get { return GetProperty<string>(ShipPostalCodeProperty); }
		}

		public static PropertyInfo<string> ShipCountryProperty = RegisterProperty<string>(c => c.ShipCountry);
		public string ShipCountry
		{
			get { return GetProperty<string>(ShipCountryProperty); }
		}

		public static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
		public string CompanyName
		{
			get { return GetProperty<string>(CompanyNameProperty); }
		}

		public static PropertyInfo<string> AddressProperty = RegisterProperty<string>(c => c.Address);
		public string Address
		{
			get { return GetProperty<string>(AddressProperty); }
		}

		public static PropertyInfo<string> CityProperty = RegisterProperty<string>(c => c.City);
		public string City
		{
			get { return GetProperty<string>(CityProperty); }
		}

		public static PropertyInfo<string> RegionProperty = RegisterProperty<string>(c => c.Region);
		public string Region
		{
			get { return GetProperty<string>(RegionProperty); }
		}

		public static PropertyInfo<string> PostalCodeProperty = RegisterProperty<string>(c => c.PostalCode);
		public string PostalCode
		{
			get { return GetProperty<string>(PostalCodeProperty); }
		}

		public static PropertyInfo<string> CountryProperty = RegisterProperty<string>(c => c.Country);
		public string Country
		{
			get { return GetProperty<string>(CountryProperty); }
		}
		#endregion // Properties

		#region Navigation Properties
		#endregion // Navigation Properties

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public OrderInfo() { }
#else
		private OrderInfo() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(OrderInfo other)
        {
            if (other == null)
				return false;								

			if (this.OrderID != other.OrderID)
				return false;

			if (this.CompanyName != other.CompanyName)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is OrderInfo)
				return this.Equals((OrderInfo)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return OrderID.GetHashCode() ^ CompanyName.GetHashCode();
        }
		
		public static bool operator == (OrderInfo a, OrderInfo b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (OrderInfo a, OrderInfo b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods

		internal static OrderInfo Get(CslaExtensionDemo.Library.Data.OrderInfo data)
		{
			if (data == null)
				return null;
				
			return DataPortal.FetchChild<OrderInfo>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.OrderInfo data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.OrderInfo Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.OrderInfo data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.OrderInfo data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.OrderInfo data);


		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.OrderInfo data)
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
			LoadProperty(CompanyNameProperty, data.CompanyName);
			LoadProperty(AddressProperty, data.Address);
			LoadProperty(CityProperty, data.City);
			LoadProperty(RegionProperty, data.Region);
			LoadProperty(PostalCodeProperty, data.PostalCode);
			LoadProperty(CountryProperty, data.Country);
		}
		#endregion // Common Data Access Methods

		#region Data Portal Methods
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.OrderInfo data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.OrderInfo data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.OrderInfo data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class OrderInfo
	#endregion // Class OrderInfo

	#region Class OrderInfoList

	[Serializable]
	public partial class OrderInfoList : Csla.ReadOnlyListBase<OrderInfoList, OrderInfo>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public OrderInfoList() { }
#else
		private OrderInfoList() { }
#endif
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<OrderInfoList>> callback)
        {
            var dp = new DataPortal<OrderInfoList>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }

		public static void Get(int orderID, string companyName, EventHandler<DataPortalResult<OrderInfoList>> callback)
		{
			var dp = new DataPortal<OrderInfoList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new OrderInfo.Key(orderID, companyName));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<OrderInfoList>> callback)
		{
			var dp = new DataPortal<OrderInfoList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
			
		public static OrderInfo Get(int orderID, string companyName)
		{
			OrderInfoList result = DataPortal.Fetch<OrderInfoList>(new OrderInfo.Key(orderID, companyName));
			return result.FirstOrDefault();
		}
		
		public static OrderInfoList GetAll()
		{
			return DataPortal.Fetch<OrderInfoList>();
		}
		internal static OrderInfoList Get(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data)
		{
			if (data == null)
				return null;
			return DataPortal.Fetch<OrderInfoList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			foreach (var item in data)
				this.Add(OrderInfo.Get(item));
			IsReadOnly = true;
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);
		#endregion

		#region Data Portal Methods
			

		private void DataPortal_Fetch()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
				ReadData(ctx.ObjectContext.OrderInfos);
		}

		private void DataPortal_Fetch(OrderInfo.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
        	{
				var data = ctx.ObjectContext.OrderInfos.Where(e => e.OrderID == key.OrderID && e.CompanyName == key.CompanyName);
				ReadData(data);
			}
		}

		private void DataPortal_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.OrderInfo> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class OrderInfoList

	#region Class Order

	[Serializable]
	public partial class Order : Csla.BusinessBase<Order>, IEquatable<Order>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
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
			
		public static PropertyInfo<byte[]> EntityKeyProperty = RegisterProperty<byte []>(c => c.EntityKey);
		public byte[] EntityKey
		{
			get { return GetProperty<byte[]>(EntityKeyProperty); }
			set { SetProperty<byte[]>(EntityKeyProperty, value); }
		}
  
		public static PropertyInfo<int> OrderIDProperty = RegisterProperty<int>(c => c.OrderID);
		internal int OrderID
		{
			get { return GetProperty<int>(OrderIDProperty); }
			private set { SetProperty<int>(OrderIDProperty, value); }
		}

		public static PropertyInfo<string> CustomerIDProperty = RegisterProperty<string>(c => c.CustomerID);
		private string CustomerID
		{
			get { return GetProperty<string>(CustomerIDProperty); }
			set { SetProperty<string>(CustomerIDProperty, value); }
		}

		public static PropertyInfo<int?> EmployeeIDProperty = RegisterProperty<int?>(c => c.EmployeeID);
		public int? EmployeeID
		{
			get { return GetProperty<int?>(EmployeeIDProperty); }
			set { SetProperty<int?>(EmployeeIDProperty, value); }
		}

		public static PropertyInfo<System.DateTime?> OrderDateProperty = RegisterProperty<System.DateTime?>(c => c.OrderDate);
		public System.DateTime? OrderDate
		{
			get { return GetProperty<System.DateTime?>(OrderDateProperty); }
			set { SetProperty<System.DateTime?>(OrderDateProperty, value); }
		}

		public static PropertyInfo<System.DateTime?> RequiredDateProperty = RegisterProperty<System.DateTime?>(c => c.RequiredDate);
		public System.DateTime? RequiredDate
		{
			get { return GetProperty<System.DateTime?>(RequiredDateProperty); }
			set { SetProperty<System.DateTime?>(RequiredDateProperty, value); }
		}

		public static PropertyInfo<System.DateTime?> ShippedDateProperty = RegisterProperty<System.DateTime?>(c => c.ShippedDate);
		public System.DateTime? ShippedDate
		{
			get { return GetProperty<System.DateTime?>(ShippedDateProperty); }
			set { SetProperty<System.DateTime?>(ShippedDateProperty, value); }
		}

		public static PropertyInfo<int?> ShipViaProperty = RegisterProperty<int?>(c => c.ShipVia);
		public int? ShipVia
		{
			get { return GetProperty<int?>(ShipViaProperty); }
			set { SetProperty<int?>(ShipViaProperty, value); }
		}

		public static PropertyInfo<decimal?> FreightProperty = RegisterProperty<decimal?>(c => c.Freight);
		public decimal? Freight
		{
			get { return GetProperty<decimal?>(FreightProperty); }
			set { SetProperty<decimal?>(FreightProperty, value); }
		}

		public static PropertyInfo<string> ShipNameProperty = RegisterProperty<string>(c => c.ShipName);
		public string ShipName
		{
			get { return GetProperty<string>(ShipNameProperty); }
			set { SetProperty<string>(ShipNameProperty, value); }
		}

		public static PropertyInfo<string> ShipAddressProperty = RegisterProperty<string>(c => c.ShipAddress);
		public string ShipAddress
		{
			get { return GetProperty<string>(ShipAddressProperty); }
			set { SetProperty<string>(ShipAddressProperty, value); }
		}

		public static PropertyInfo<string> ShipCityProperty = RegisterProperty<string>(c => c.ShipCity);
		public string ShipCity
		{
			get { return GetProperty<string>(ShipCityProperty); }
			set { SetProperty<string>(ShipCityProperty, value); }
		}

		public static PropertyInfo<string> ShipRegionProperty = RegisterProperty<string>(c => c.ShipRegion);
		public string ShipRegion
		{
			get { return GetProperty<string>(ShipRegionProperty); }
			set { SetProperty<string>(ShipRegionProperty, value); }
		}

		public static PropertyInfo<string> ShipPostalCodeProperty = RegisterProperty<string>(c => c.ShipPostalCode);
		public string ShipPostalCode
		{
			get { return GetProperty<string>(ShipPostalCodeProperty); }
			set { SetProperty<string>(ShipPostalCodeProperty, value); }
		}

		public static PropertyInfo<string> ShipCountryProperty = RegisterProperty<string>(c => c.ShipCountry);
		public string ShipCountry
		{
			get { return GetProperty<string>(ShipCountryProperty); }
			set { SetProperty<string>(ShipCountryProperty, value); }
		}
		#endregion // Properties

		#region Navigation Properties
		
		public static PropertyInfo<Customer> CustomerProperty = RegisterProperty<Customer>(c => c.Customer);
		public Customer Customer
		{
			get { return GetProperty<Customer>(CustomerProperty); }
			set 
			{
				SetProperty<Customer>(CustomerProperty, value);			
				if (value != null)
					SetProperty<string>(CustomerIDProperty, value.CustomerID);
				else
					SetProperty<string>(CustomerIDProperty, default(string));
			}
		}
		
		public static PropertyInfo<OrderDetailList> Order_DetailsProperty = RegisterProperty<OrderDetailList>(c => c.Order_Details);
		public OrderDetailList Order_Details
		{
			get { return GetProperty<OrderDetailList>(Order_DetailsProperty); }
			private set 
			{
				SetProperty<OrderDetailList>(Order_DetailsProperty, value);			
			}
		}
		
		public static PropertyInfo<Shippers> ShipperProperty = RegisterProperty<Shippers>(c => c.Shipper);
		public Shippers Shipper
		{
			get { return GetProperty<Shippers>(ShipperProperty); }
			set 
			{
				SetProperty<Shippers>(ShipperProperty, value);			
				if (value != null)
					SetProperty<int?>(ShipViaProperty, value.ShipperID);
				else
					SetProperty<int?>(ShipViaProperty, default(int?));
			}
		}
		#endregion // Navigation Properties

		#region Business Rules
		protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
			
			// Partial Method BeforeAddBusinessRules
			BeforeAddBusinessRules();
			
			BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(CustomerIDProperty, 5));
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

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public Order() { }
#else
		private Order() { }
#endif
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
        public static void New(EventHandler<DataPortalResult<Order>> callback)
        {
            var dp = new DataPortal<Order>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }
		
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

		internal static Order Get(CslaExtensionDemo.Library.Data.Order data)
		{
			if (data == null)
				return null;
				
			return DataPortal.Fetch<Order>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.Order data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.Order Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.Order data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Load Data to Navigation Properties
			LoadProperty<Customer>(CustomerProperty, Customer.Get(data.Customer));
			LoadProperty<OrderDetailList>(Order_DetailsProperty, OrderDetailList.Get(data.Order_Details));
			LoadProperty<Shippers>(ShipperProperty, Shippers.Get(data.Shipper));
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.Order data);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        System.Data.EntityKey GetEntityKey()
        {
            using (var buffer = new System.IO.MemoryStream(ReadProperty<byte[]>(EntityKeyProperty)))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return formatter.Deserialize(buffer) as System.Data.EntityKey;
            }
        }
		
		/// <summary>
		///
		/// </summary>
		private void LoadEntityKey(CslaExtensionDemo.Library.Data.Order data)
		{
			//Load EntityKey
			using (var buffer = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(buffer, data.EntityKey);
                LoadProperty(EntityKeyProperty, buffer.ToArray());
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.Order data)
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
		private void WriteKeyData(CslaExtensionDemo.Library.Data.Order data)
		{
			BeforeWriteKeyData(data);
			
			data.OrderID = ReadProperty<int>(OrderIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterWriteKeyData(CslaExtensionDemo.Library.Data.Order data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.Library.Data.Order data)
		{
			BeforeWriteNonKeyData(data);
			
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

			AfterWriteNonKeyData(data);
		} // WriteNonKeyData()
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.Library.Data.Order data);

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
			BeforeCreate();
			BusinessRules.CheckRules();
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			
		private void DataPortal_Fetch(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Orders.Single(e => e.OrderID == key.OrderID);
				DataPortal_Fetch(data);
			}		
		}

		private void DataPortal_Fetch(CslaExtensionDemo.Library.Data.Order data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			LoadEntityKey(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.Order data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
				var data = new CslaExtensionDemo.Library.Data.Order();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Orders.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadEntityKey(data);
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterInsert(CslaExtensionDemo.Library.Data.Order data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
                var objectStateManager = ctx.ObjectContext.ObjectStateManager;
                System.Data.Objects.ObjectStateEntry stateEntry = null;
                System.Data.EntityKey entityKey = GetEntityKey();
                CslaExtensionDemo.Library.Data.Order data = null;

                if (objectStateManager.TryGetObjectStateEntry(entityKey, out stateEntry))
                    data = ctx.ObjectContext.Orders.Single(e => e.OrderID == this.OrderID);

				if (this.IsSelfDirty)
				{	
                    if (data == null)
                    {
						data = ctx.ObjectContext.Orders.CreateObject();
						WriteKeyData(data);
						data.EntityKey = entityKey;
						ctx.ObjectContext.Attach(data);
                    }					
					
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					LoadEntityKey(data);
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterUpdate(CslaExtensionDemo.Library.Data.Order data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new Key(ReadProperty<int>(OrderIDProperty)));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Orders.Single(e => e.OrderID == key.OrderID);
				BeforeDelete(data);
				ctx.ObjectContext.Orders.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.Library.Data.Order data);
		partial void AfterDelete(CslaExtensionDemo.Library.Data.Order data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Order
	#endregion // Class Order

	#region Class Product

	[Serializable]
	public partial class Product : Csla.BusinessBase<Product>, IEquatable<Product>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
			public int ProductID
			{
				get { return ReadProperty<int>(ProductIDProperty); }
				set { LoadProperty<int>(ProductIDProperty, value); }
			}

			public Key() { }
			public Key(int productID)
			{
				this.ProductID = productID;
			}
		}
		#endregion

		#region Properties
			
		public static PropertyInfo<byte[]> EntityKeyProperty = RegisterProperty<byte []>(c => c.EntityKey);
		public byte[] EntityKey
		{
			get { return GetProperty<byte[]>(EntityKeyProperty); }
			set { SetProperty<byte[]>(EntityKeyProperty, value); }
		}
  
		public static PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
		public int ProductID
		{
			get { return GetProperty<int>(ProductIDProperty); }
			set { SetProperty<int>(ProductIDProperty, value); }
		}

		public static PropertyInfo<string> ProductNameProperty = RegisterProperty<string>(c => c.ProductName);
		public string ProductName
		{
			get { return GetProperty<string>(ProductNameProperty); }
			set { SetProperty<string>(ProductNameProperty, value); }
		}

		public static PropertyInfo<int?> SupplierIDProperty = RegisterProperty<int?>(c => c.SupplierID);
		public int? SupplierID
		{
			get { return GetProperty<int?>(SupplierIDProperty); }
			set { SetProperty<int?>(SupplierIDProperty, value); }
		}

		public static PropertyInfo<int?> CategoryIDProperty = RegisterProperty<int?>(c => c.CategoryID);
		public int? CategoryID
		{
			get { return GetProperty<int?>(CategoryIDProperty); }
			set { SetProperty<int?>(CategoryIDProperty, value); }
		}

		public static PropertyInfo<string> QuantityPerUnitProperty = RegisterProperty<string>(c => c.QuantityPerUnit);
		public string QuantityPerUnit
		{
			get { return GetProperty<string>(QuantityPerUnitProperty); }
			set { SetProperty<string>(QuantityPerUnitProperty, value); }
		}

		public static PropertyInfo<decimal?> UnitPriceProperty = RegisterProperty<decimal?>(c => c.UnitPrice);
		public decimal? UnitPrice
		{
			get { return GetProperty<decimal?>(UnitPriceProperty); }
			set { SetProperty<decimal?>(UnitPriceProperty, value); }
		}

		public static PropertyInfo<short?> UnitsInStockProperty = RegisterProperty<short?>(c => c.UnitsInStock);
		public short? UnitsInStock
		{
			get { return GetProperty<short?>(UnitsInStockProperty); }
			set { SetProperty<short?>(UnitsInStockProperty, value); }
		}

		public static PropertyInfo<short?> UnitsOnOrderProperty = RegisterProperty<short?>(c => c.UnitsOnOrder);
		public short? UnitsOnOrder
		{
			get { return GetProperty<short?>(UnitsOnOrderProperty); }
			set { SetProperty<short?>(UnitsOnOrderProperty, value); }
		}

		public static PropertyInfo<short?> ReorderLevelProperty = RegisterProperty<short?>(c => c.ReorderLevel);
		public short? ReorderLevel
		{
			get { return GetProperty<short?>(ReorderLevelProperty); }
			set { SetProperty<short?>(ReorderLevelProperty, value); }
		}

		public static PropertyInfo<bool> DiscontinuedProperty = RegisterProperty<bool>(c => c.Discontinued);
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

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public Product() { }
#else
		private Product() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Product other)
        {
            if (other == null)
				return false;								

			if (this.ProductID != other.ProductID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Product)
				return this.Equals((Product)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return ProductID.GetHashCode();
        }
		
		public static bool operator == (Product a, Product b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Product a, Product b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods
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
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.Product data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.Product Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.Product data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.Product data);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        System.Data.EntityKey GetEntityKey()
        {
            using (var buffer = new System.IO.MemoryStream(ReadProperty<byte[]>(EntityKeyProperty)))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return formatter.Deserialize(buffer) as System.Data.EntityKey;
            }
        }
		
		/// <summary>
		///
		/// </summary>
		private void LoadEntityKey(CslaExtensionDemo.Library.Data.Product data)
		{
			//Load EntityKey
			using (var buffer = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(buffer, data.EntityKey);
                LoadProperty(EntityKeyProperty, buffer.ToArray());
            }
		}

		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.Product data)
		{
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
		}

		/// <summary>
		/// 
		/// </summary>
		private void WriteKeyData(CslaExtensionDemo.Library.Data.Product data)
		{
			BeforeWriteKeyData(data);
			
			data.ProductID = ReadProperty<int>(ProductIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterWriteKeyData(CslaExtensionDemo.Library.Data.Product data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.Library.Data.Product data)
		{
			BeforeWriteNonKeyData(data);
			
			data.ProductName = ReadProperty<string>(ProductNameProperty);
			data.SupplierID = ReadProperty<int?>(SupplierIDProperty);
			data.CategoryID = ReadProperty<int?>(CategoryIDProperty);
			data.QuantityPerUnit = ReadProperty<string>(QuantityPerUnitProperty);
			data.UnitPrice = ReadProperty<decimal?>(UnitPriceProperty);
			data.UnitsInStock = ReadProperty<short?>(UnitsInStockProperty);
			data.UnitsOnOrder = ReadProperty<short?>(UnitsOnOrderProperty);
			data.ReorderLevel = ReadProperty<short?>(ReorderLevelProperty);
			data.Discontinued = ReadProperty<bool>(DiscontinuedProperty);

			AfterWriteNonKeyData(data);
		} // WriteNonKeyData()
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.Library.Data.Product data);

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
			BeforeCreate();
			BusinessRules.CheckRules();
			AfterCreate();
		}
		partial void BeforeCreate();
		partial void AfterCreate();
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.Product data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			LoadEntityKey(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.Product data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		
		private void Child_Insert()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
				var data = new CslaExtensionDemo.Library.Data.Product();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Products.AddObject(data);					
				ctx.ObjectContext.SaveChanges();					
				LoadEntityKey(data);
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterInsert(CslaExtensionDemo.Library.Data.Product data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		
		private void Child_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
			{
                var objectStateManager = ctx.ObjectContext.ObjectStateManager;
                System.Data.Objects.ObjectStateEntry stateEntry = null;
                System.Data.EntityKey entityKey = GetEntityKey();
                CslaExtensionDemo.Library.Data.Product data = null;

                if (objectStateManager.TryGetObjectStateEntry(entityKey, out stateEntry))
                    data = ctx.ObjectContext.Products.Single(e => e.ProductID == this.ProductID);

				if (this.IsSelfDirty)
				{	
                    if (data == null)
                    {
						data = ctx.ObjectContext.Products.CreateObject();
						WriteKeyData(data);
						data.EntityKey = entityKey;
						ctx.ObjectContext.Attach(data);
                    }					
					
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					LoadEntityKey(data);
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterUpdate(CslaExtensionDemo.Library.Data.Product data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		
		private void Child_DeleteSelf()
		{
			Child_Delete(new Key(ReadProperty<int>(ProductIDProperty)));
		}

		
		private void Child_Delete(Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				var data = ctx.ObjectContext.Products.Single(e => e.ProductID == key.ProductID);
				BeforeDelete(data);
				ctx.ObjectContext.Products.DeleteObject(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.Library.Data.Product data);
		partial void AfterDelete(CslaExtensionDemo.Library.Data.Product data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Product
	#endregion // Class Product

	#region Class ProductList

	[Serializable]
	public partial class ProductList : Csla.BusinessListBase<ProductList, Product>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public ProductList() { }
#else
		private ProductList() { }
#endif
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<ProductList>> callback)
        {
            var dp = new DataPortal<ProductList>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }

		public static void Get(int productID, EventHandler<DataPortalResult<ProductList>> callback)
		{
			var dp = new DataPortal<ProductList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Product.Key(productID));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<ProductList>> callback)
		{
			var dp = new DataPortal<ProductList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
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
		internal static ProductList Get(IEnumerable<CslaExtensionDemo.Library.Data.Product> data)
		{
			if (data == null)
				return null;
			return DataPortal.Fetch<ProductList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;

			foreach (var item in data)
				this.Add(Product.Get(item));
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);
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
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
				ReadData(ctx.ObjectContext.Products);
		}

		private void DataPortal_Fetch(Product.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
        	{
				var data = ctx.ObjectContext.Products.Where(e => e.ProductID == key.ProductID);
				ReadData(data);
			}
		}

		protected override void DataPortal_Update()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
			{
				Child_Update();
			}
		}

		private void DataPortal_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.Product> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.Product> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class ProductList

	#region Class Shippers

	[Serializable]
	public partial class Shippers : Csla.ReadOnlyBase<Shippers>, IEquatable<Shippers>
	{
		#region Key
		[Serializable]
		public class Key : CriteriaBase<Key>
		{
			public static PropertyInfo<int> ShipperIDProperty = RegisterProperty<int>(c => c.ShipperID);
			public int ShipperID
			{
				get { return ReadProperty<int>(ShipperIDProperty); }
				set { LoadProperty<int>(ShipperIDProperty, value); }
			}

			public Key() { }
			public Key(int shipperID)
			{
				this.ShipperID = shipperID;
			}
		}
		#endregion

		#region Properties
 
		public static PropertyInfo<int> ShipperIDProperty = RegisterProperty<int>(c => c.ShipperID);
		public int ShipperID
		{
			get { return GetProperty<int>(ShipperIDProperty); }
		}

		public static PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
		public string CompanyName
		{
			get { return GetProperty<string>(CompanyNameProperty); }
		}

		public static PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
		public string Phone
		{
			get { return GetProperty<string>(PhoneProperty); }
		}
		#endregion // Properties

		#region Navigation Properties
		#endregion // Navigation Properties

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public Shippers() { }
#else
		private Shippers() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Shippers other)
        {
            if (other == null)
				return false;								

			if (this.ShipperID != other.ShipperID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Shippers)
				return this.Equals((Shippers)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return ShipperID.GetHashCode();
        }
		
		public static bool operator == (Shippers a, Shippers b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Shippers a, Shippers b)
		{
			return !(a == b);
		}
		#endregion

		#region Synchronous Factory Methods

		internal static Shippers Get(CslaExtensionDemo.Library.Data.Shippers data)
		{
			if (data == null)
				return null;
				
			return DataPortal.FetchChild<Shippers>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.Library.Data.Shippers data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.Library.Data.Shippers Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.Library.Data.Shippers data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.Library.Data.Shippers data);
		partial void AfterReadData(CslaExtensionDemo.Library.Data.Shippers data);


		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.Library.Data.Shippers data)
		{
			LoadProperty(ShipperIDProperty, data.ShipperID);
			LoadProperty(CompanyNameProperty, data.CompanyName);
			LoadProperty(PhoneProperty, data.Phone);
		}
		#endregion // Common Data Access Methods

		#region Data Portal Methods
			

		private void Child_Fetch(CslaExtensionDemo.Library.Data.Shippers data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.Library.Data.Shippers data);
		partial void AfterFetch(CslaExtensionDemo.Library.Data.Shippers data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Shippers
	#endregion // Class Shippers

	#region Class ShippersList

	[Serializable]
	public partial class ShippersList : Csla.ReadOnlyListBase<ShippersList, Shippers>
	{

		#region Default Constructor
// Rockford Lhotka: The MobileFormatter requires a parameterless ctor. 
// On the Silverlight side it must be public (due to reflection limitations) 
// and on the .NET side it can be non-public - but either way it must be there.
#if SILVERLIGHT
		public ShippersList() { }
#else
		private ShippersList() { }
#endif
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<ShippersList>> callback)
        {
            var dp = new DataPortal<ShippersList>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }

		public static void Get(int shipperID, EventHandler<DataPortalResult<ShippersList>> callback)
		{
			var dp = new DataPortal<ShippersList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Shippers.Key(shipperID));
		}
		
		public static void GetAll(EventHandler<DataPortalResult<ShippersList>> callback)
		{
			var dp = new DataPortal<ShippersList>();
			dp.FetchCompleted += callback;
			dp.BeginFetch();
		}
		#endregion // Asynchronous Factory Methods		

		#region Synchronous Factory Methods
			
		public static Shippers Get(int shipperID)
		{
			ShippersList result = DataPortal.Fetch<ShippersList>(new Shippers.Key(shipperID));
			return result.FirstOrDefault();
		}
		
		public static ShippersList GetAll()
		{
			return DataPortal.Fetch<ShippersList>();
		}
		internal static ShippersList Get(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data)
		{
			if (data == null)
				return null;
			return DataPortal.Fetch<ShippersList>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		#region Common Data Access Methods
		private void ReadData(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			foreach (var item in data)
				this.Add(Shippers.Get(item));
			IsReadOnly = true;
			RaiseListChangedEvents = true;

			AfterReadData(data);
		} // ReadData()				
		partial void BeforeReadData(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data);
		partial void AfterReadData(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data);
		#endregion

		#region Data Portal Methods
			

		private void DataPortal_Fetch()
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))            	
				ReadData(ctx.ObjectContext.Shippers);
		}

		private void DataPortal_Fetch(Shippers.Key key)
		{
			using (var ctx = Csla.Data.ObjectContextManager<CslaExtensionDemo.Library.Data.NorthwindEntities2>.GetManager(CslaExtensionDemo.Library.Data.NorthwindEntities2Database.Name))
        	{
				var data = ctx.ObjectContext.Shippers.Where(e => e.ShipperID == key.ShipperID);
				ReadData(data);
			}
		}

		private void DataPortal_Fetch(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data)
		{
			BeforeFetch(data);
			ReadData(data);
			AfterFetch(data);				
		}
		partial void BeforeFetch(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data);
		partial void AfterFetch(IEnumerable<CslaExtensionDemo.Library.Data.Shippers> data);			
		
		#endregion // Data Portal Methods		
		#endregion // Data Access Layer
	}
	#endregion // Class ShippersList
} // end of namespace CslaExtensionDemo.Library

namespace CslaExtensionDemo.Library.Data
{

	#region Class NorthwindEntities2Database
    public sealed class NorthwindEntities2Database
    {
        public static string Name = "NorthwindEntities2";
    }
	#endregion // Class NorthwindEntities2Database
} // end of namespace CslaExtensionDemo.Library.Data
