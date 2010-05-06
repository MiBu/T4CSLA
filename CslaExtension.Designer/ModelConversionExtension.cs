using System;
using System.Xml.Linq;
using System.ComponentModel.Composition;
using Microsoft.Data.Entity.Design.Extensibility;

namespace CslaExtension
{
  [Export(typeof(IModelConversionExtension))]
  [PartCreationPolicy(CreationPolicy.Shared)]
  [ModelFileExtension(".foo")]
  public class ModelConversionExtension : IModelConversionExtension
  {
    /// <summary>
    /// Called after the contents of a custom file have been loaded, but before the contents are converted
    /// to an .edmx document for display in the Entity Designer.
    /// </summary>
    /// <param name="context"></param>
    public void OnAfterFileLoaded(ModelConversionExtensionContext context)
    {
      // context.OriginalDocument = Contents of the custom file as a string.
      //                            This is for reference only and cannot be modified.
      //
      // context.CurrentDocument = Contents of the converted file as an XDocument.
      //                           This should be a valid .edmx document.
    }

    /// <summary>
    /// Called right before the file will be saved to disk.
    /// </summary>
    /// <param name="context"></param>
    public void OnBeforeFileSaved(ModelConversionExtensionContext context)
    {
      // context.CurrentDocument = The .edmx content (as an XDocument) created by the Entity Designer.
      //                           This is for reference and cannot be modified.
      //
      // context.OriginalDocument = The .edmx (as a string) after it has been converted to a custom file format.
    }
  }
}
