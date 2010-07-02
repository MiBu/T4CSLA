using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TemplateWizard;

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
            ModelChoser frm = new ModelChoser(automationObject as EnvDTE.DTE);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                replacementsDictionary.Add("$EFModelFile$", frm.ModelFile);
            }
            else
            {
                throw new WizardCancelledException("Action cancelled by user");
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
