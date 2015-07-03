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

namespace Renamer
{
    public partial class Form1 : Form
    {
        string[] filesToUpdate;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetSourceDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtSourceDirectory.Text = folderBrowserDialog1.SelectedPath;

                // update target directory?
                string message = "Would you like to update the target directory to the same as the source directory?";
                string caption = "Update target directory";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Displays the MessageBox.
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    txtTargetDirectory.Text = txtSourceDirectory.Text;
                }
            }
        }

        private void btnGetTargetDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtTargetDirectory.Text = folderBrowserDialog1.SelectedPath ;
            }
        }

        private void btnFindFiles(object sender, EventArgs e)
        {
            if (ValidateSourceAndTarget())
            {
                FindFiles(txtSourceDirectory.Text);
            }
            else
            {
                MessageBox.Show("The source or target directory is not valid.  Please correct.");
            }
        }

        private void FindFiles(string sourceDirectory)
        {
 	        bool includeSubFolders = cbxIncludeSubFolders.Checked;

            string currentDirectory = sourceDirectory;
            string currentDirectoryName = new DirectoryInfo(currentDirectory).Name;

            string[] subDirectories = Directory.GetDirectories(sourceDirectory);

            string[] files = Directory.GetFiles(currentDirectory);
            if ((files != null) && (files.Length > 0))
            {
                foreach (string fileName in files)
                {
                    fileList.Items.Add(fileName);
                }
            }

            if (includeSubFolders)
            {
                foreach (string subDirectory in subDirectories)
                {
                    if (!String.IsNullOrEmpty(subDirectory))
                        FindFiles(subDirectory);
                }
            }
        }


        private bool ValidateSourceAndTarget()
        {
            return (Directory.Exists(txtSourceDirectory.Text) && Directory.Exists(txtTargetDirectory.Text));
        }

       //private void RenameFile(string source, string destination)
       // {
       //     try
       //     {
       //         if (!(File.Exists(source))) 
       //             Console.WriteLine("Filename: {0} does not exist, it must have been renamed manually during the execution of the program", source);

       //         //extract parent directory name
       //         string sourceDirectory = Path.GetDirectoryName(source);
       //         string sourceFileName = Path.GetFileName(source);

       //         string dest = String.Format("{0}\\{1}-{2}", sourceDirectory, destination, sourceFileName);

       //         if (File.Exists(dest))
       //         {
       //             Console.WriteLine("Cannot rename " + source + " to " + dest + ":  Destination file exists");
                    
       //         }

       //         File.Move(source, dest);

       //     }
       //     catch (Exception e)
       //     {
       //         Diag.LogException(e.Message);
       //     }
       // }

       // private void RenameFiles(string sourceDirectory)
       // {
       //     try
       //     {
       //         string currentDirectory = sourceDirectory;
       //         string currentDirectoryName = new DirectoryInfo(currentDirectory).Name;
       //         //string parentDirectory = (Directory.GetParent(currentDirectory)).Name;

       //         string[] subDirectories = Directory.GetDirectories(sourceDirectory);


       //         foreach (string subDirectory in subDirectories)
       //         {
       //             if (!String.IsNullOrEmpty(subDirectory))
       //                 RenameFiles(subDirectory);
       //         }

                
       //         string[] files = Directory.GetFiles(currentDirectory);
       //         if ((files == null) || (files.Length < 1))
       //             Console.WriteLine(String.Format("No files in {0}", currentDirectory));
       //         else
       //         {
       //             foreach (string fileName in files)
       //             {
       //                 RenameFile(fileName, currentDirectoryName);    
       //             }
       //         }
       //     }
       //     catch (Exception e)
       //     {
       //         Diag.LogException(e.Message);
       //     }
       // }
    }
    }

