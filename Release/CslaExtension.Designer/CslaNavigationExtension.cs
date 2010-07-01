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
	public class CslaNavigationExtension
	{

		private XElement _parent;
		private PropertyExtensionContext _context;

		public CslaNavigationExtension(XElement parent, PropertyExtensionContext context)
		{
			_context = context;
			_parent = parent;
		}


		[DisplayName("Csla Getter")]
		[Description("Getter modifier for the generated CSLA class.")]
		[Category(Constants._category)]
		[DefaultValue(CslaModifier.None)]
		public CslaModifier CslaGetter
		{
			get
			{
				CslaModifier result;
				if (Enum.TryParse<CslaModifier>(getValue(Constants._xnNavigationGetter), out result))
					return result;
				return CslaModifier.None;
			}
			set
			{
				setValue(Constants._xnNavigationGetter, value.ToString());
			}
		}

		[DisplayName("Csla Setter")]
		[Description("Setter modifier for the generated CSLA class.")]
		[Category(Constants._category)]
		[DefaultValue(CslaModifier.None)]
		public CslaModifier CslaSetter
		{
			get
			{
				CslaModifier result;
				if (Enum.TryParse<CslaModifier>(getValue(Constants._xnNavigationSetter), out result))
					return result;
				return CslaModifier.None;
			}
			set
			{
				setValue(Constants._xnNavigationSetter, value.ToString());
			}
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