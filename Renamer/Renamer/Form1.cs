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
                txtTargetDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
