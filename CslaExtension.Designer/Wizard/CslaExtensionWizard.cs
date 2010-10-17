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
            
            //Check if the $edmxInputFile$ token is already in the replacementDictionnary.
            //If it is, it means the file was added through the "Add Code Generation Item..." menu,
            //and we don't need to set it here. The token was actually set by the 
            //Microsoft.Data.Entity.Design.VisualStudio.ModelWizard.AddArtifactGeneratorWizard WizardExtension
            //(see the file ADONETArtifactGenerator_CslaExtension.ItemTemplate.vstemplate in the CslaExtension.ItemTemplate project)
            if (!replacementsDictionary.ContainsKey("$edmxInputFile$"))
            {
                string modelFileName = ModelOpenDialog.GetModelFileName(dte);
                if (modelFileName != string.Empty)
                    replacementsDictionary.Add("$edmxInputFile$", modelFileName);
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }


    }
}
