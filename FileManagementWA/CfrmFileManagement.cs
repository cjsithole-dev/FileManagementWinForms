
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementWA
{
    public partial class CfrmFileManagement : Form
    {
        public CfrmFileManagement()
        {
            InitializeComponent();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            //Open dialog to allow user to select file and display the file name in the textbox
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            //If the file selected by the user exists, get and display the file attributes
            string path = txtFilePath.Text;
            if (File.Exists(path))
            {
                var attrs = File.GetAttributes(path);
                MessageBox.Show("Attributes: " + attrs);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnCreated_Click(object sender, EventArgs e)
        {
            //If the file selected by the user exists, get and display the file's creation date and time
            string path = txtFilePath.Text;
            if (File.Exists(path))
            {
                var created = File.GetCreationTime(path);
                MessageBox.Show("Created: " + created);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Get file path of user-selected file
            string path = txtFilePath.Text;

            //Check if file exists and if exist create a copy and name it with original name + _Copy
            if (File.Exists(path))
            {
                string dir = Path.GetDirectoryName(path);
                string name = Path.GetFileNameWithoutExtension(path);
                string ext = Path.GetExtension(path);
                string newPath = Path.Combine(dir, name + "_Copy" + ext);
                File.Copy(path, newPath, true);
                MessageBox.Show("File copied!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnLastAccessed_Click(object sender, EventArgs e)
        {
            //If the file selected by the user exists, get and display the time the file was last accessed
            string path = txtFilePath.Text;
            if (File.Exists(path))
            {
                var last = File.GetLastAccessTime(path);
                MessageBox.Show("Last accessed: " + last);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Get file path of user-selected file
            string path = txtFilePath.Text;

            //Check if the file does not exists and create a the file 
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                MessageBox.Show("File created!");
            }
            else
            {
                MessageBox.Show("File already exists!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get file path of user-selected file
            string _filename = txtFilePath.Text;

            //Check if the file exists.
            if (File.Exists(_filename))
            {
                //Prompt the user for confirmation. If user clicks "Yes" (DialogResult.Yes) button, the file will be deleted.
                DialogResult result = MessageBox.Show("Delete file?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete(_filename);
                    MessageBox.Show("File deleted!");
                }
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }

        private void btnBrowseDirectories_Click(object sender, EventArgs e)
        {
            //Browse, select folder and show path in textbox
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryFilePath.Text = dlg.SelectedPath;
            }

        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            //Check if the user-selected directory exists
            string path = txtDirectoryFilePath.Text;
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string msg = string.Join("\n", files);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Directory not found!");
            }
        }
    }
}
