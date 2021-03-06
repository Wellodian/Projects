﻿namespace Renamer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cbxSequentialNumbering = new System.Windows.Forms.CheckBox();
            this.cbxPrependFolderName = new System.Windows.Forms.CheckBox();
            this.cbxIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.btnGetTargetDirectory = new System.Windows.Forms.Button();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.btnGetSourceDirectory = new System.Windows.Forms.Button();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 451);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.cbxSequentialNumbering);
            this.panel2.Controls.Add(this.cbxPrependFolderName);
            this.panel2.Controls.Add(this.cbxIncludeSubFolders);
            this.panel2.Controls.Add(this.btnGetTargetDirectory);
            this.panel2.Controls.Add(this.txtTargetDirectory);
            this.panel2.Controls.Add(this.lblTargetDirectory);
            this.panel2.Controls.Add(this.btnGetSourceDirectory);
            this.panel2.Controls.Add(this.txtSourceDirectory);
            this.panel2.Controls.Add(this.lblSourceDirectory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 128);
            this.panel2.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Find Files";
            this.toolStripButton1.Click += new System.EventHandler(this.btnFindFiles);
            // 
            // cbxSequentialNumbering
            // 
            this.cbxSequentialNumbering.AutoSize = true;
            this.cbxSequentialNumbering.Location = new System.Drawing.Point(352, 78);
            this.cbxSequentialNumbering.Name = "cbxSequentialNumbering";
            this.cbxSequentialNumbering.Size = new System.Drawing.Size(130, 17);
            this.cbxSequentialNumbering.TabIndex = 13;
            this.cbxSequentialNumbering.Text = "Sequential Numbering";
            this.cbxSequentialNumbering.UseVisualStyleBackColor = true;
            // 
            // cbxPrependFolderName
            // 
            this.cbxPrependFolderName.AutoSize = true;
            this.cbxPrependFolderName.Location = new System.Drawing.Point(352, 55);
            this.cbxPrependFolderName.Name = "cbxPrependFolderName";
            this.cbxPrependFolderName.Size = new System.Drawing.Size(129, 17);
            this.cbxPrependFolderName.TabIndex = 12;
            this.cbxPrependFolderName.Text = "Prepend Folder Name";
            this.cbxPrependFolderName.UseVisualStyleBackColor = true;
            // 
            // cbxIncludeSubFolders
            // 
            this.cbxIncludeSubFolders.AutoSize = true;
            this.cbxIncludeSubFolders.Location = new System.Drawing.Point(352, 32);
            this.cbxIncludeSubFolders.Name = "cbxIncludeSubFolders";
            this.cbxIncludeSubFolders.Size = new System.Drawing.Size(120, 17);
            this.cbxIncludeSubFolders.TabIndex = 11;
            this.cbxIncludeSubFolders.Text = "Include Sub-Folders";
            this.cbxIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnGetTargetDirectory
            // 
            this.btnGetTargetDirectory.Location = new System.Drawing.Point(303, 67);
            this.btnGetTargetDirectory.Name = "btnGetTargetDirectory";
            this.btnGetTargetDirectory.Size = new System.Drawing.Size(24, 23);
            this.btnGetTargetDirectory.TabIndex = 9;
            this.btnGetTargetDirectory.Text = "...";
            this.btnGetTargetDirectory.UseVisualStyleBackColor = true;
            this.btnGetTargetDirectory.Click += new System.EventHandler(this.btnGetTargetDirectory_Click);
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Location = new System.Drawing.Point(107, 69);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(190, 20);
            this.txtTargetDirectory.TabIndex = 8;
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Location = new System.Drawing.Point(12, 72);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(86, 13);
            this.lblTargetDirectory.TabIndex = 7;
            this.lblTargetDirectory.Text = "Target Directory:";
            // 
            // btnGetSourceDirectory
            // 
            this.btnGetSourceDirectory.Location = new System.Drawing.Point(303, 34);
            this.btnGetSourceDirectory.Name = "btnGetSourceDirectory";
            this.btnGetSourceDirectory.Size = new System.Drawing.Size(24, 23);
            this.btnGetSourceDirectory.TabIndex = 6;
            this.btnGetSourceDirectory.Text = "...";
            this.btnGetSourceDirectory.UseVisualStyleBackColor = true;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(107, 36);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(190, 20);
            this.txtSourceDirectory.TabIndex = 5;
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(12, 39);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(89, 13);
            this.lblSourceDirectory.TabIndex = 4;
            this.lblSourceDirectory.Text = "Source Directory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGetTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.Button btnGetSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.CheckBox cbxPrependFolderName;
        private System.Windows.Forms.CheckBox cbxIncludeSubFolders;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.CheckBox cbxSequentialNumbering;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

