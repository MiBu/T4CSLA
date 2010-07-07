using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Data.Entity.Design.Extensibility;

namespace CslaExtension.Designer
{
    public class CslaExtensionBase
    {
        protected XElement _parent;
        protected PropertyExtensionContext _context;

        protected string getValue(XName xName)
        {
            return PropertyManager.GetValue(_parent, xName);
        }

        protected void setValue(XName xName, string value)
        {
            PropertyManager.SetValue(_parent, _context, xName, value);
        }
    }
}
