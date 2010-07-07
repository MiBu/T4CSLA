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
        private DTE _dte;
        private SelectedItem _selectedItem;
        private List<ProjectItem> _allModels;

        public string ModelFile { get; private set; }

        public ModelChoser(DTE dte, SelectedItem item)
            : this()
        {
            _dte = dte;
            _selectedItem = item;
            _allModels = new List<ProjectItem>();
        }

        public ModelChoser()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillListBox();
            SetButtonEnabled();
        }

        private void SetButtonEnabled()
        {
            if (listBox1.SelectedIndex < 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void FillListBox()
        {
            Project project = _dte.ActiveDocument.ProjectItem.ContainingProject;

            //Get reference path, that is, the location where the 
            //new CslaExtension.tt file is created. There are 2 possibilities:
            //
            //if _selectedItem is null, or if its ProjectItem is null, then it means 
            //the new file is getting created in the project's root folder,
            //or else in a project's subfolder
            string referencePath = string.Empty;
            if (_selectedItem != null)
            {
                if (_selectedItem.ProjectItem != null)
                    referencePath = Path.GetDirectoryName(_selectedItem.ProjectItem.FileNames[0]);
            }

            if (referencePath == string.Empty)
                referencePath = Path.GetDirectoryName(project.FullName);

            //Iterate the project recursively to find all EDMX files
            foreach (ProjectItem pi in project.ProjectItems)
                Recurse(pi);

            //Fill the ListBox with the name of all EF Models
            //Found in the project
            foreach (ProjectItem pi in _allModels)
                listBox1.Items.Add(RelativePath(referencePath, pi.FileNames[0]));

        }

        private void Recurse(ProjectItem item)
        {
            foreach (ProjectItem pi in item.ProjectItems)
                Recurse(pi);

            if (item.Name.ToUpper().EndsWith(".EDMX"))
                _allModels.Add(item);

        }


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


        //user interaction handlers
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Make sure there is an item selected
            if (listBox1.SelectedIndex < 0)
                return;

            ModelFile = listBox1.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelFile = listBox1.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtonEnabled();
        }
    }

}
