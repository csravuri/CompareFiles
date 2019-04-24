using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareFiles
{
    public partial class Form1 : Form
    {
        private string file1Path;
        private string file2Path;
        private string vsPath;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void file2Label_DragOver(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void file2Label_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if(files != null && files.Any())
            {
                file2Path = files.First();
                this.file2Label.Text = file2Path;
            }
        }

        private void file1Lable_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void file1Lable_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
            {
                file1Path = files.First();
                this.file1Lable.Text = file1Path;
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            vsPath = GetVisualStudioPath();
            
            if (!string.IsNullOrEmpty(file1Path) && !string.IsNullOrEmpty(file2Path) && vsPath != "")
            {
                string exeString = "\"" + vsPath + $@"\devenv.exe" + "\"";
                string argString = $"/diff \"{file1Path}\" \"{file2Path}\"";
                Process.Start(exeString, argString);
            }
        }

        private string GetVisualStudioPath()
        {
            string vsPath = this.vsPathTextBox.Text;
            if (string.IsNullOrEmpty(vsPath))
            {
                vsPath = ConfigurationManager.AppSettings["VSPath"];
            }

            return vsPath;
        }
    }
}
