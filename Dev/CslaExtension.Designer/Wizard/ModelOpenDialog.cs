using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvDTE;
using System.IO;

namespace CslaExtension.Wizard
{
    class ModelOpenDialog
    {
        public static string GetModelFileName(DTE dte)
        {
            SelectedItem selectedItem = dte.SelectedItems.Item(1);
            //get a reference to the "active" project
            Project project = null;
            var activeProjects = (Array)dte.ActiveSolutionProjects;
            if (activeProjects.Length > 0)
                project = (Project)activeProjects.GetValue(0);

            //Get reference path, that is, the location where the 
            //new CslaExtension.tt file is created. There are 2 possibilities:
            //
            //if _selectedItem is null, or if its ProjectItem is null, then it means 
            //the new file is getting created in the project's root folder,
            //or else in a project's subfolder
            string referencePath = string.Empty;
            if (selectedItem != null)
            {
                if (selectedItem.ProjectItem != null)
                    referencePath = Path.GetDirectoryName(selectedItem.ProjectItem.FileNames[0]);
            }

            if (referencePath == string.Empty)
                referencePath = Path.GetDirectoryName(project.FullName);


            using (System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog())
            {
                dlg.Filter = "Entity Framework Model (*.edmx)|*edmx";
                dlg.InitialDirectory = referencePath;

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return RelativePath(referencePath, dlg.FileName);
            }
            return string.Empty;
        }

        //This method has been taken from: 
        //http://mrpmorris.blogspot.com/2007/05/convert-absolute-path-to-relative-path.html
        //
        private static string RelativePath(string absolutePath, string relativeTo)
        {
            string[] absoluteDirectories = absolutePath.Split('\\');
            string[] relativeDirectories = relativeTo.Split('\\');

            //Get the shortest of the two paths            
            int length = absoluteDirectories.Length < relativeDirectories.Length ? absoluteDirectories.Length : relativeDirectories.Length;

            //Use to determine where in the loop we exited            
            int lastCommonRoot = -1;
            int index;

            //Find common root            
            for (index = 0; index < length; index++)
                if (absoluteDirectories[index] == relativeDirectories[index])
                    lastCommonRoot = index;
                else
                    break;

            //If we didn't find a common prefix then throw            
            if (lastCommonRoot == -1)
                throw new ArgumentException("Paths do not have a common base");

            //Build up the relative path            
            StringBuilder relativePath = new StringBuilder();

            //Add on the ..            
            for (index = lastCommonRoot + 1; index < absoluteDirectories.Length; index++)
                if (absoluteDirectories[index].Length > 0)
                    relativePath.Append("..\\");

            //Add on the folders            
            for (index = lastCommonRoot + 1; index < relativeDirectories.Length - 1; index++)
                relativePath.Append(relativeDirectories[index] + "\\");
            relativePath.Append(relativeDirectories[relativeDirectories.Length - 1]);

            return relativePath.ToString();
        }


    }
}
