using System;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.Data.Entity.Design.Extensibility;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CslaExtension.Designer
{
	class CslaDesignerExtension : CslaExtensionBase
	{

		public CslaDesignerExtension(XElement parent, PropertyExtensionContext context)
		{
			_context = context;
			_parent = parent;
		}


		[DisplayName("Csla BL Namespace")]
		[Description("Business Layer Namespace (namespace of CSLA generated classes).")]
		[Category(Constants._category)]
		public string CslaNamespace
		{
			get { return getValue(Constants._xnCslaNamespace); }
			set { setValue(Constants._xnCslaNamespace, value); }
		}

        [DisplayName("Csla DAL Namespace")]
        [Description("Data Access Layer Namespace (namespace of generated entity classes).")]
        [Category(Constants._category)]
        public string CslaEntitiesNamespace
        {
            get { return getValue(Constants._xnCslaEntitiesNamespace); }
            set { setValue(Constants._xnCslaEntitiesNamespace, value); }
        }
        
        [DisplayName("Csla Use Nullable Types")]
		[Description("Use nullable types in generated classes.")]
		[Category(Constants._category)]
		[DefaultValue(false)]
		public bool CslaNullableTypes
		{
			get 
			{
				bool result = false;
				bool.TryParse(getValue(Constants._xnCslaNullableTypesNamespace), out result);
				return result;
			}
			set { setValue(Constants._xnCslaNullableTypesNamespace, value.ToString()); }
		}

		[DisplayName("Csla Multiple Files Output")]
		[Description("Generate classes in multiple output files.")]
		[Category(Constants._category)]
        [DefaultValue(CslaMultipleFilesOutput.AllClassesInSingleFile)]
		public CslaMultipleFilesOutput CslaMultipleFiles
		{
			get
			{
                CslaMultipleFilesOutput result = CslaMultipleFilesOutput.AllClassesInSingleFile;
                Enum.TryParse<CslaMultipleFilesOutput>(getValue(Constants._xnCslaMultipleFilesNamespace), out result);
				return result;
			}
            set { setValue(Constants._xnCslaMultipleFilesNamespace, value.ToString()); }
		}

        [DisplayName("Csla Transaction Type")]
        [Description("Transaction type for insert, update and delete operations in Data Portal.")]
        [Category(Constants._category)]
        [DefaultValue(CslaTransactionalTypes.TransactionScope)]
        public CslaTransactionalTypes CslaTransactionType
        {
            get
            {
                CslaTransactionalTypes result = CslaTransactionalTypes.TransactionScope;
                Enum.TryParse<CslaTransactionalTypes>(getValue(Constants._xnCslaTransactionType), out result);
                return result;
            }
            set { setValue(Constants._xnCslaTransactionType, value.ToString()); }
        }

        [DisplayName("Csla Generate Equals")]
        [Description("If IEquatable will be implemeted")]
        [Category(Constants._category)]
        [DefaultValue(YesNoDefault.Default)]
        public YesNoDefault CslaEquals
        {
            get
            {
                YesNoDefault result = YesNoDefault.Default;
                Enum.TryParse<YesNoDefault>(getValue(Constants._xnCslaDesignerEquals), out result);
                return result;
            }
            set { setValue(Constants._xnCslaDesignerEquals, value.ToString()); }
        }

	}
}
