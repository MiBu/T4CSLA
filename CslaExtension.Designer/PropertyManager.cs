using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Data.Entity.Design.Extensibility;

namespace CslaExtension
{
	class PropertyManager
	{
		public static string GetValue(XElement _parent, XName xName)
		{
			string result = string.Empty;
			if (_parent.HasElements)
			{
				XElement lastChild = _parent.Elements().Where<XElement>(element => element != null && element.Name == xName).LastOrDefault();
				if (lastChild != null)
					result = lastChild.Value.ToString();
			}
			return result;
		}

		public static void SetValue(XElement _parent, PropertyExtensionContext _context,  XName xName, string value)
		{
			string propertyValue = string.Empty;
			if (value != null)
				propertyValue = value.Trim();
			using (EntityDesignerChangeScope scope = _context.CreateChangeScope("Set CslaEntityProperties"))
			{
				if (_parent.HasElements)
				{
					XElement lastChild = _parent.Elements().Where<XElement>(element => element != null && element.Name == xName).LastOrDefault();
					if (lastChild != null)
					{
						lastChild.SetValue(propertyValue);
					}
					else
					{
						// MyNewProperty element does not exist, so create a new one as the last child of the EntityType element.
						_parent.Elements().Last().AddAfterSelf(new XElement(xName, propertyValue));
					}
				}
				else
				{
					// The EntityType element has no child elements so create a new MyNewProperty element as its first child.
					_parent.Add(new XElement(xName, propertyValue));
				}

				// Commit the changes.
				scope.Complete();
			}
		}
	}
}
