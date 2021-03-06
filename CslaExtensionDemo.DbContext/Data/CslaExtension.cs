﻿//
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
using System.Configuration;
using Csla.Properties;

// <auto-generated />
namespace NorthwindModel
{

	#region Class Products

	[Serializable]
	public partial class Products : Csla.BusinessBase<Products>, IEquatable<Products>
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
		public Products() { }
#else
		private Products() { }
#endif
		#endregion

		#region Equals Methods and Operators

        public bool Equals(Products other)
        {
            if (other == null)
				return false;								

			if (this.ProductID != other.ProductID)
				return false;

			return true;
        }
		
		public override bool Equals(object obj)
		{
			if (obj is Products)
				return this.Equals((Products)obj);
			else
				return base.Equals(obj);
		}
		
        public override int GetHashCode()
        {
            return ProductID.GetHashCode();
        }
		
		public static bool operator == (Products a, Products b)
		{
			// If both are null, or both are same instance, return true.
			if (object.ReferenceEquals(a, b))
				return true;

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
				return false;
		
			return a.Equals(b);
		}
		
		public static bool operator != (Products a, Products b)
		{
			return !(a == b);
		}
		#endregion

		#region Asynchronous Factory Methods
        public static void New(EventHandler<DataPortalResult<Products>> callback)
        {
            var dp = new DataPortal<Products>();
            dp.CreateCompleted += callback;
            dp.BeginCreate();
        }
		
		public static void Get(int productID, EventHandler<DataPortalResult<Products>> callback)
		{
			var dp = new DataPortal<Products>();
			dp.FetchCompleted += callback;
			dp.BeginFetch(new Key(productID));
		}
		#endregion // Asynchronous Factory Methods

		#region Synchronous Factory Methods
		public static Products New()
		{
			return DataPortal.Create<Products>();
		}
		
		public static Products Get(int productID)
		{
			return DataPortal.Fetch<Products>(new Key(productID));
		}
		
		public static void Delete(int productID)
		{
			DataPortal.Delete<Products>(new Key(productID));
		}

		internal static Products Get(CslaExtensionDemo.DbContext.Data.Products data)
		{
			if (data == null)
				return null;
				
			return DataPortal.Fetch<Products>(data);				
		}
		#endregion // Synchronous Factory Methods

		#region Data Access Layer
		
		#region DataEventArgs
		
		public class DataEventArgs : EventArgs
        {
            public DataEventArgs(CslaExtensionDemo.DbContext.Data.Products data)
            {
                this.Data = data;
            }

            public CslaExtensionDemo.DbContext.Data.Products Data { get; set; }
        }

		#endregion

		#region Common Data Access Methods
		/// <summary>
		/// 
		/// </summary>
		private void ReadData(CslaExtensionDemo.DbContext.Data.Products data)
		{
			// Partial Method BeforeReadData
			BeforeReadData(data);
			
			// Load Data to Properties
			LoadDataToProperties(data);
			
			// Partial Method AfterReadData
			AfterReadData(data);
		} // ReadData()
		
		partial void BeforeReadData(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterReadData(CslaExtensionDemo.DbContext.Data.Products data);


		/// <summary>
		/// 
		/// </summary>
		private void LoadDataToProperties(CslaExtensionDemo.DbContext.Data.Products data)
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
		private void WriteKeyData(CslaExtensionDemo.DbContext.Data.Products data)
		{
			BeforeWriteKeyData(data);
			
			data.ProductID = ReadProperty<int>(ProductIDProperty);

			AfterWriteKeyData(data);
		} // WriteKeyData()
		
		partial void BeforeWriteKeyData(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterWriteKeyData(CslaExtensionDemo.DbContext.Data.Products data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteNonKeyData(CslaExtensionDemo.DbContext.Data.Products data)
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
		
		partial void BeforeWriteNonKeyData(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterWriteNonKeyData(CslaExtensionDemo.DbContext.Data.Products data);

		/// <summary>
		/// 
		/// </summary>
		private void WriteData(CslaExtensionDemo.DbContext.Data.Products data)
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
		
		partial void BeforeWriteData(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterWriteData(CslaExtensionDemo.DbContext.Data.Products data);
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
			using (var ctx = DbContextManager<CslaExtensionDemo.DbContext.Data.NorthwindModelContainer>.GetManager(NorthwindModel.NorthwindModelContainerDatabase.Name))
			{
				var data = ctx.ObjectContext.Products.Single(e => e.ProductID == key.ProductID);
				DataPortal_Fetch(data);
			}		
		}

		private void DataPortal_Fetch(CslaExtensionDemo.DbContext.Data.Products data)
		{
			BeforeFetch(data);
			if (Fetching != null)
            	Fetching(this, new DataEventArgs(data));

			ReadData(data);
			AfterFetch(data);				
			if (Fetched != null)
				Fetched(this, new DataEventArgs(data));
		}			
		partial void BeforeFetch(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterFetch(CslaExtensionDemo.DbContext.Data.Products data);	
		internal event EventHandler<DataEventArgs> Fetching;
		internal event EventHandler<DataEventArgs> Fetched;
		

		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<CslaExtensionDemo.DbContext.Data.NorthwindModelContainer>.GetManager(NorthwindModel.NorthwindModelContainerDatabase.Name))            	
			{
				var data = new CslaExtensionDemo.DbContext.Data.Products();					
				BeforeInsert(data);					
				if (Inserting != null)
					Inserting(this, new DataEventArgs(data));
				WriteData(data);					
				ctx.ObjectContext.Products.Add(data);					
				ctx.ObjectContext.SaveChanges();
				LoadDataToProperties(data);					
				AfterInsert(data);			
				if (Inserted != null)
					Inserted(this, new DataEventArgs(data));
				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeInsert(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterInsert(CslaExtensionDemo.DbContext.Data.Products data);			
		internal event EventHandler<DataEventArgs> Inserting;
		internal event EventHandler<DataEventArgs> Inserted;
		
		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_Update()
		{
			using (var ctx = DbContextManager <CslaExtensionDemo.DbContext.Data.NorthwindModelContainer>.GetManager(NorthwindModel.NorthwindModelContainerDatabase.Name))            	
			{
				
				CslaExtensionDemo.DbContext.Data.Products data = ctx.ObjectContext.Products.Find(ProductID);

				if (this.IsSelfDirty)
				{	
					BeforeUpdate(data);					
					if (Updating != null)
						Updating(this, new DataEventArgs(data));
					WriteNonKeyData(data);
					ctx.ObjectContext.SaveChanges();
					
					LoadDataToProperties(data);
					AfterUpdate(data);
					if (Updated != null)
						Updated(this, new DataEventArgs(data));

				}

				FieldManager.UpdateChildren();
			}//using
		}
		partial void BeforeUpdate(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterUpdate(CslaExtensionDemo.DbContext.Data.Products data);
		internal event EventHandler<DataEventArgs> Updating;
		internal event EventHandler<DataEventArgs> Updated;
		
		[Transactional(TransactionalTypes.TransactionScope)]
		override protected void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new Key(ReadProperty<int>(ProductIDProperty)));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(Key key)
		{
			using (var ctx = DbContextManager<CslaExtensionDemo.DbContext.Data.NorthwindModelContainer>.GetManager(NorthwindModel.NorthwindModelContainerDatabase.Name))
			{
				var data = ctx.ObjectContext.Products.Find(ProductID);
			
				BeforeDelete(data);
				ctx.ObjectContext.Products.Remove(data);
				ctx.ObjectContext.SaveChanges();
				AfterDelete(data);
			}		
		}
		partial void BeforeDelete(CslaExtensionDemo.DbContext.Data.Products data);
		partial void AfterDelete(CslaExtensionDemo.DbContext.Data.Products data);		
		#endregion // Data Portal Methods

		#endregion // Data Access Layer
	} // end of class Products
	#endregion // Class Products
} // end of namespace NorthwindModel
// <auto-generated />
namespace NorthwindModel
{

	#region Class NorthwindModelContainerDatabase
    public sealed class NorthwindModelContainerDatabase
    {
        public static string Name = "NorthwindModelContainer";
    }
	#endregion // Class NorthwindModelContainerDatabase


	#region DbContextManager

    public class DbContextManager<C> : IDisposable where C : System.Data.Entity.DbContext
    {
        private static object _lock = new object();
        private C _context;
        private string _connectionString;
        private string _label;

        /// <summary>
        /// Gets the DbContextManager object for the 
        /// specified database.
        /// </summary>
        /// <param name="database">
        /// Database name as shown in the config file.
        /// </param>
        public static DbContextManager<C> GetManager(string database)
        {
            return GetManager(database, true);
        }

        /// <summary>
        /// Gets the DbContextManager object for the 
        /// specified database.
        /// </summary>
        /// <param name="database">
        /// Database name as shown in the config file.
        /// </param>
        /// <param name="label">Label for this context.</param>
        public static DbContextManager<C> GetManager(string database, string label)
        {
            return GetManager(database, true, label);
        }

        /// <summary>
        /// Gets the DbContextManager object for the 
        /// specified database.
        /// </summary>
        /// <param name="database">
        /// The database name or connection string.
        /// </param>
        /// <param name="isDatabaseName">
        /// True to indicate that the connection string
        /// should be retrieved from the config file. If
        /// False, the database parameter is directly 
        /// used as a connection string.
        /// </param>
        /// <returns>ContextManager object for the name.</returns>
        public static DbContextManager<C> GetManager(string database, bool isDatabaseName)
        {
            return GetManager(database, isDatabaseName, "default");
        }

        /// <summary>
        /// Gets the DbContextManager object for the 
        /// specified database.
        /// </summary>
        /// <param name="database">
        /// The database name or connection string.
        /// </param>
        /// <param name="isDatabaseName">
        /// True to indicate that the connection string
        /// should be retrieved from the config file. If
        /// False, the database parameter is directly 
        /// used as a connection string.
        /// </param>
        /// <param name="label">Label for this context.</param>
        /// <returns>ContextManager object for the name.</returns>
        public static DbContextManager<C> GetManager(string database, bool isDatabaseName, string label)
        {
            if (isDatabaseName)
            {
                var connection = ConfigurationManager.ConnectionStrings[database];
                if (connection == null)
                    throw new ConfigurationErrorsException(String.Format(Resources.DatabaseNameNotFound, database));
                var conn = ConfigurationManager.ConnectionStrings[database].ConnectionString;
                if (string.IsNullOrEmpty(conn))
                    throw new ConfigurationErrorsException(String.Format(Resources.DatabaseNameNotFound, database));
                database = conn;
            }

            lock (_lock)
            {
                var contextLabel = GetContextName(database, label);
                DbContextManager<C> mgr = null;
                if (ApplicationContext.LocalContext.Contains(contextLabel))
                {
                    mgr = (DbContextManager<C>)(ApplicationContext.LocalContext[contextLabel]);

                }
                else
                {
                    mgr = new DbContextManager<C>(database, label);
                    ApplicationContext.LocalContext[contextLabel] = mgr;
                }
                mgr.AddRef();
                return mgr;
            }
        }

        private DbContextManager(string connectionString, string label)
        {
            _label = label;
            _connectionString = connectionString;

            _context = (C)(Activator.CreateInstance(typeof(C)));//TODO:, connectionString));
            _context.Database.Connection.Open();
        }

        private static string GetContextName(string connectionString, string label)
        {
            return "__octx:" + label + "-" + connectionString;
        }


        /// <summary>
        /// Gets the EF object context object.
        /// </summary>
        public C ObjectContext
        {
            get
            {
                return _context;
            }
        }

        #region  Reference counting

        private int _refCount;

        /// <summary>
        /// Gets the current reference count for this
        /// object.
        /// </summary>
        public int RefCount
        {
            get { return _refCount; }
        }

        private void AddRef()
        {
            _refCount += 1;
        }

        private void DeRef()
        {

            lock (_lock)
            {
                _refCount -= 1;
                if (_refCount == 0)
                {
                    _context.Database.Connection.Close();
                    _context.Dispose();
                    ApplicationContext.LocalContext.Remove(GetContextName(_connectionString, _label));
                }
            }

        }

        #endregion

        #region  IDisposable

        /// <summary>
        /// Dispose object, dereferencing or
        /// disposing the context it is
        /// managing.
        /// </summary>
        public void Dispose()
        {
            DeRef();
        }

        #endregion

    }

	#endregion

} // end of namespace NorthwindModel
