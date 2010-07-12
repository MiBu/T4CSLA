using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;

namespace CslaExtension.Wizard
{
    public class CslaExtensionWizard : IWizard
    {
        public void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(EnvDTE.Project project)
        {
        }

        public void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            
            DTE dte = automationObject as DTE;
            
            //Get a reference to the Item currently selected in the Solution Explorer
            SelectedItem item = dte.SelectedItems.Item(1);

            //Check if the $edmxInputFile$ token is already in the replacementDictionnary.
            //If it is, it means the file was added through the "Add Code Generation Item..." menu,
            //and we don't need to set it here. The token was actually set by the 
            //Microsoft.Data.Entity.Design.VisualStudio.ModelWizard.AddArtifactGeneratorWizard WizardExtension
            //(see the file ADONETArtifactGenerator_CslaExtension.ItemTemplate.vstemplate in the CslaExtension.ItemTemplate project)
            if (!replacementsDictionary.ContainsKey("$edmxInputFile$"))
            {
                ModelChoser frm = new ModelChoser(dte, item);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Substitute the EDMX filename within the template
                    replacementsDictionary.Add("$edmxInputFile$", frm.ModelFile);
                }
                else
                {
                    throw new WizardCancelledException("Action cancelled by user");
                }
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
