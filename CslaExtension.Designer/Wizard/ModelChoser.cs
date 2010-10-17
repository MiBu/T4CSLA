using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using EnvDTE;

namespace CslaExtension.Wizard
{
    public partial class ModelChoser : Form
    {
        private DTE dte;
        private List<ProjectItem> modelsList;
        private string referencePath = string.Empty;

        public string ModelFile { get; private set; }

        public ModelChoser(DTE dte)
            : this()
        {
            this.dte = dte;
            modelsList = new List<ProjectItem>();

            var activeProjects = (Array)dte.ActiveSolutionProjects;
            var project = (Project)activeProjects.GetValue(0);
            SelectedItem selectedItem = dte.SelectedItems.Item(1);

            //Iterate the project recursively to find all EDMX files
            foreach (ProjectItem pi in project.ProjectItems)
                findModels(pi);

            //Get reference path, that is, the location where the 
            //new CslaExtension.tt file is created. There are 2 possibilities:
            //
            //if _selectedItem is null, or if its ProjectItem is null, then it means 
            //the new file is getting created in the project's root folder,
            //or else in a project's subfolder
            if (selectedItem != null)
            {
                if (selectedItem.ProjectItem != null)
                    referencePath = Path.GetDirectoryName(selectedItem.ProjectItem.FileNames[0]);
            }
            else
                referencePath = Path.GetDirectoryName(project.FullName);

            //get a reference to the "active" project
            foreach (ProjectItem pi in modelsList)
                listBox.Items.Add(RelativePath(referencePath, pi.FileNames[0]));
        }

        public ModelChoser()
        {
            InitializeComponent();
        }

        #region RelativePath
        //This method has been taken from: 
        //http://mrpmorris.blogspot.com/2007/05/convert-absolute-path-to-relative-path.html
        //
        private string RelativePath(string absolutePath, string relativeTo)
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

        #endregion

        private void findModels(ProjectItem item)
        {
            foreach (ProjectItem pi in item.ProjectItems)
                findModels(pi);

            if (item.Name.ToUpper().EndsWith(".EDMX"))
                modelsList.Add(item);

        }

        private void SetButtonEnabled()
        {
            btnOk.Enabled = listBox.SelectedIndex < 0;
        }

        private void ModelChoser_Load(object sender, EventArgs e)
        {
            SetButtonEnabled();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtonEnabled();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Make sure there is an item selected
            if (listBox.SelectedIndex < 0)
                return;

            ModelFile = listBox.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog())
            {
                dlg.Filter = "Entity Framework Model (*.edmx)|*edmx";
                dlg.InitialDirectory = referencePath;

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ModelFile = RelativePath(dlg.FileName, referencePath);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }

        }

    }

}
