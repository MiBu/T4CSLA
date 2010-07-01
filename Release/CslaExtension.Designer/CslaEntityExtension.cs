using System;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.Data.Entity.Design.Extensibility;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CslaExtension
{
	/// <summary>
	/// </summary>
	public class CslaEntityExtension
	{

		private XElement _parent;
		private PropertyExtensionContext _context;

		public CslaEntityExtension(XElement parent, PropertyExtensionContext context)
		{
			_context = context;
			_parent = parent;
		}

		// This property is saved in the conceptual content of an .edmx document in the following format:
		// <EntityType>
		//  <!-- other entity properties -->
		//  <MyNewProperty xmlns="http://schemas.tempuri.com/CslaTypeProperty">True</MyNewProperty>
		// </EntityType>
		//[DisplayName("Csla classes")]
		//[Description("This property is available when a C-Side EntityType is selected in the Entity Designer canvas or the Model Browser. Its values are saved as a structured annotation in the <EntityType> in the EDMX file.")]
		//[Category(CslaTypeProperty._category)]
		//public CslaClassList CslaClasses
		//{
		//    // Read and return the property value from the structured annotation in the EntityType element.
		//    get
		//    {
		//        CslaClassList result = null;
		//        if (_parent.HasElements)
		//        {
		//            XElement lastChild = _parent.Elements().Where<XElement>(element => element != null && element.Name == CslaTypeProperty._xnMyNamespace).LastOrDefault();
		//            if (lastChild != null)
		//            {
		//                result = CslaClassList.Deserialize(lastChild.Value.ToString());
		//                // MyNewProperty element exists, so get its value.
		//            }
		//        }
		//        return result;
		//    }

		//    // Write the new property value to the structured annotation in the EntityType element.
		//    set
		//    {
		//        MessageBox.Show("Setting");
		//        string propertyValue = string.Empty;
		//        if (value != null)
		//        {
		//            propertyValue = CslaClassList.Serialize(value);
		//            MessageBox.Show(propertyValue);
		//        }
		//        // Make changes to the .edmx document in an EntityDesignerChangeScope to enable undo/redo of changes.
		//        using (EntityDesignerChangeScope scope = _context.CreateChangeScope("Set CslaTypeProperty"))
		//        {
		//            if (_parent.HasElements)
		//            {
		//                XElement lastChild = _parent.Elements().Where<XElement>(element => element != null && element.Name == CslaTypeProperty._xnMyNamespace).LastOrDefault();
		//                if (lastChild != null)
		//                {
		//                    // MyNewProperty element already exists under the EntityType element, so update its value.
		//                    lastChild.SetValue(propertyValue);
		//                    MessageBox.Show("Element exists!");
		//                }
		//                else
		//                {
		//                    // MyNewProperty element does not exist, so create a new one as the last child of the EntityType element.
		//                    _parent.Elements().Last().AddAfterSelf(new XElement(_xnMyNamespace, propertyValue));
		//                    MessageBox.Show("Element does not exist!");
		//                }
		//            }
		//            else
		//            {
		//                // The EntityType element has no child elements so create a new MyNewProperty element as its first child.
		//                _parent.Add(new XElement(_xnMyNamespace, propertyValue));
		//                MessageBox.Show("Parent does not exist!");
		//            }

		//            // Commit the changes.
		//            scope.Complete();
		//        }
		//    }
		//}

		 //This property is saved in the conceptual content of an .edmx document in the following format:
		 //<EntityType>
		 // <!-- other entity properties -->
		 // <MyNewProperty xmlns="http://schemas.tempuri.com/CslaTypeProperty">True</MyNewProperty>
		 //</EntityType>
		[DisplayName("Csla Class Template")]
		[Description("Template for generated CSLA class.")]
		[Category(Constants._category)]
		[DefaultValue(CslaClassTemplate.None)]
		public CslaClassTemplate CslaClassTemplate
		{
		    get
		    {
		        CslaClassTemplate result = CslaClassTemplate.None;
				Enum.TryParse<CslaClassTemplate>(getValue(Constants._xnCslaClassTemplate), out result);
		        return result;
		    }
		    set
		    {
				setValue(Constants._xnCslaClassTemplate, value.ToString());
		    }
		}

		[DisplayName("Csla Item Name")]
		[Description("Name of the generated CSLA class (single item).")]
		[Category(Constants._category)]
		public string CslaItemName
		{
			get { return getValue(Constants._xnCslaItemName); }
			set { setValue(Constants._xnCslaItemName, value.Trim()); }
		}

		[DisplayName("Csla Collection Name")]
		[Description("Name of the generated CSLA collection (list of items).")]
		[Category(Constants._category)]
		public string CslaListName
		{
			get { return getValue(Constants._xnCslaCollectionName); }
			set { setValue(Constants._xnCslaCollectionName, value.Trim()); }
		}

        [DisplayName("Csla Class Namespace")]
        [Description("Namespace for the generated CSLA class.")]
        [Category(Constants._category)]
        public string CslaClassNamespace
        {
            get { return getValue(Constants._xnCslaClassNamespace); }
            set { setValue(Constants._xnCslaClassNamespace, value); }
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