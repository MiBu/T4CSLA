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
            SelectedItem item = dte.SelectedItems.Item(1);

            ModelChoser frm = new ModelChoser(dte, item);
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
