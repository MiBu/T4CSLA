using System;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.Data.Entity.Design.Extensibility;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CslaExtension
{
	class CslaDesignerExtension
	{
		internal const string _category = "Csla";

		private XElement _parent;
		private PropertyExtensionContext _context;

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

		[DisplayName("Csla Generate Relations")]
		[Description("If relation properties will be generated.")]
		[Category(Constants._category)]
		[DefaultValue(false)]
		public bool CslaGenerateRelations
		{
			get
			{
				bool result = false;
				bool.TryParse(getValue(Constants._xnCslaDesignerGenerateRelationsNamespace), out result);
				return result;
			}
			set { setValue(Constants._xnCslaDesignerGenerateRelationsNamespace, value.ToString()); }
		}

		private string getValue(XName xName)
		{
			return PropertyManager.GetValue(_parent, xName);
		}

		private void setValue(XName xName, string value)
		{
			PropertyManager.SetValue(_parent, _context, xName, value);
		}

	}
}
