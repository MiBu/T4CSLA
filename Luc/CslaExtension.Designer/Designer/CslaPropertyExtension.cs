using System;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.Data.Entity.Design.Extensibility;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CslaExtension.Designer
{
	/// <summary>
	/// </summary>
	public class CslaPropertyExtension : CslaExtensionBase
	{

		public CslaPropertyExtension(XElement parent, PropertyExtensionContext context)
		{
			_context = context;
			_parent = parent;
		}

		[DisplayName("Csla Getter")]
		[Description("Getter modifier for the generated CSLA class.")]
		[Category(Constants._category)]
		[DefaultValue(CslaModifier.Default)]
		public CslaModifier CslaGetter
		{
			get
			{
				CslaModifier result;
				if (Enum.TryParse<CslaModifier>(getValue(Constants._xnPropertyGetter), out result))
					return result;
				return CslaModifier.Default;
			}
			set
			{
				setValue(Constants._xnPropertyGetter, value.ToString());
			}
		}

		[DisplayName("Csla Setter")]
		[Description("Setter modifier for the generated CSLA class.")]
		[Category(Constants._category)]
		[DefaultValue(CslaModifier.Default)]
		public CslaModifier CslaSetter
		{
			get
			{
				CslaModifier result;
				if (Enum.TryParse<CslaModifier>(getValue(Constants._xnPropertySetter), out result))
					return result;
				return CslaModifier.Default;
			}
			set
			{
				setValue(Constants._xnPropertySetter, value.ToString());
			}
		}

		[DisplayName("Csla Required")]
		[Description("Generates busines rule. If default, rule depends on database nullable property")]
		[Category(Constants._categoryBusinessRules)]
		[DefaultValue(YesNoDefault.Default)]
		public YesNoDefault CslaRequired
		{
			get
			{
				YesNoDefault result = YesNoDefault.Default;
				Enum.TryParse<YesNoDefault>(getValue(Constants._xnRequired), out result);
				return result;
			}
			set
			{
				setValue(Constants._xnRequired, value.ToString());
			}
		}

		[DisplayName("Csla Nullable")]
		[Description("If nullable type will be used for CSLA generated property.")]
		[Category(Constants._categoryBusinessRules)]
		[DefaultValue(YesNoDefault.Default)]
		public YesNoDefault CslaNullable
		{
			get
			{
				YesNoDefault result = YesNoDefault.Default;
				Enum.TryParse<YesNoDefault>(getValue(Constants._xnPropertyNullable), out result);
				return result;
			}
			set
			{
				setValue(Constants._xnPropertyNullable, value.ToString());
			}
		}


		[DisplayName("Csla Friendly Name")]
		[Description("Property user friendly name.")]
		[Category(Constants._category)]
		public string CslaFriendlyName
		{
			get
			{
				return getValue(Constants._xnFriendlyname);
			}
			set
			{
				setValue(Constants._xnFriendlyname, value.Trim());
			}
		}

	}
}