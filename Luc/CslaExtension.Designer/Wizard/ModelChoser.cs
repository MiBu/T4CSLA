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
        private List<ProjectItem> _allModels;

        public string ModelFile { get; private set; }

        public ModelChoser(DTE dte)
            : this()
        {
            _dte = dte;
            _allModels = new List<ProjectItem>();
        }

        public ModelChoser()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Fill the ListBox with the name of all EF Models
            //Found in the project

            Project project = _dte.ActiveDocument.ProjectItem.ContainingProject;

            foreach(ProjectItem pi in project.ProjectItems)
                Recurse(pi);

            foreach (ProjectItem pi in _allModels)
                listBox1.Items.Add(RelativePath(Path.GetDirectoryName(project.FullName), pi.FileNames[0]));

        }

        private void Recurse(ProjectItem item)
        {
            foreach (ProjectItem pi in item.ProjectItems)
                Recurse(pi);


            if (item.Name.ToUpper().EndsWith(".EDMX"))
                _allModels.Add(item);


        }


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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ModelFile = listBox1.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelFile = listBox1.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
