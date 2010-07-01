using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CslaExtension
{
	class Constants
	{
		internal const string _category = "Csla";
		internal const string _categoryBusinessRules = "Csla Business Rules";

		//Designer extensions
		internal static readonly string _designerExtensionsNamespace = "http://schemas.tempuri.com/CslaDesignerExtension";
		internal static XName _xnCslaNamespace = XName.Get("CslaNamespace", _designerExtensionsNamespace);
        internal static XName _xnCslaEntitiesNamespace = XName.Get("CslaEntitiesNamespace", _designerExtensionsNamespace);		
        internal static XName _xnCslaNullableTypesNamespace = XName.Get("CslaUseNullableTypes", _designerExtensionsNamespace);
		internal static XName _xnCslaMultipleFilesNamespace = XName.Get("CslaMultipleFiles", _designerExtensionsNamespace);
		internal static XName _xnCslaDesignerGenerateRelationsNamespace = XName.Get("CslaGenerateRelations", _designerExtensionsNamespace);

        //Entity extensions
        internal static readonly string _entityExtensionNamespace = "http://schemas.tempuri.com/CslaEntityExtension";
        internal static XName _xnCslaClassTemplate = XName.Get("CslaClassTemplate", _entityExtensionNamespace);
        internal static XName _xnCslaItemName = XName.Get("CslaItemName", _entityExtensionNamespace);
        internal static XName _xnCslaCollectionName = XName.Get("CslaCollectionName", _entityExtensionNamespace);
        internal static XName _xnCslaClassNamespace = XName.Get("CslaClassNamespace", _entityExtensionNamespace);

		//Property extensions
		internal static readonly string _propertyExtensionsNamespace = "http://schemas.tempuri.com/CslaPropertyExtension";
		internal static XName _xnPropertyGetter = XName.Get("CslaGetter", _propertyExtensionsNamespace);
		internal static XName _xnPropertySetter = XName.Get("CslaSetter", _propertyExtensionsNamespace);
		internal static XName _xnRequired = XName.Get("CslaRequired", _propertyExtensionsNamespace);
		internal static XName _xnFriendlyname = XName.Get("CslaFriendlyName", _propertyExtensionsNamespace);
		internal static XName _xnPropertyNullable = XName.Get("CslaNullable", _propertyExtensionsNamespace);

		//Navigation extensions
		internal static readonly string _navigationExtensionsNamespace = "http://schemas.tempuri.com/CslaNavigationExtension";
		internal static XName _xnNavigationGetter = XName.Get("CslaGetter", _navigationExtensionsNamespace);
		internal static XName _xnNavigationSetter = XName.Get("CslaSetter", _navigationExtensionsNamespace);

	}
}
