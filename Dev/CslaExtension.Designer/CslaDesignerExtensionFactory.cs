using System.Xml.Linq;
using System.ComponentModel.Composition;
using Microsoft.Data.Entity.Design.Extensibility;

namespace CslaExtension
{
	[PartCreationPolicy(CreationPolicy.Shared)]
	[Export(typeof(IEntityDesignerExtendedProperty))]
	[EntityDesignerExtendedProperty(EntityDesignerSelection.DesignerSurface)]
	class CslaDesignerExtensionFactory : IEntityDesignerExtendedProperty
	{
		public object CreateProperty(XElement element, PropertyExtensionContext context)
		{
			return new CslaDesignerExtension(element, context);
		}
	}
}