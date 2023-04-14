using System;
using System.Windows.Forms;

namespace NugetaCrypterGUI.Forms.SubForms
{
    struct Path
    {
        public static string FilePath;
        public static string Extension;
        public static bool Batch;
        public static bool Vbs;
    }
    public partial class SubOptions : Form
    {
        public SubOptions()
        {
            InitializeComponent();
        }

        private void SubOptions_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void FileChooser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Executable Files|*.exe";

 
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                string selectedFilePath = openFileDialog.FileName;

                 Path.FilePath = selectedFilePath;  
            }
            else
            {
               MessageBox.Show("No file selected.");
            }
        }

        private void ExtensionsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Path.Extension = ExtensionsDropDown.Text.ToString();
            MessageBox.Show(Path.Extension);
        }

        private void browserCheck_Click(object sender, EventArgs e)
        {
            Path.Batch = batchCheck.Checked;
        }
    }
}
