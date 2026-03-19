namespace FileManagementWA
{
    partial class CfrmFileManagement
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
            this.grpbxFiles = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLastAccessed = new System.Windows.Forms.Button();
            this.btnCreated = new System.Windows.Forms.Button();
            this.btnAttributes = new System.Windows.Forms.Button();
            this.grpbxDirectories = new System.Windows.Forms.GroupBox();
            this.txtDirectoryFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectories = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.grpbxFiles.SuspendLayout();
            this.grpbxDirectories.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxFiles
            // 
            this.grpbxFiles.Controls.Add(this.txtFilePath);
            this.grpbxFiles.Controls.Add(this.btnBrowseFiles);
            this.grpbxFiles.Controls.Add(this.btnCopy);
            this.grpbxFiles.Controls.Add(this.btnDelete);
            this.grpbxFiles.Controls.Add(this.btnCreate);
            this.grpbxFiles.Controls.Add(this.btnLastAccessed);
            this.grpbxFiles.Controls.Add(this.btnCreated);
            this.grpbxFiles.Controls.Add(this.btnAttributes);
            this.grpbxFiles.Location = new System.Drawing.Point(17, 16);
            this.grpbxFiles.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxFiles.Name = "grpbxFiles";
            this.grpbxFiles.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxFiles.Size = new System.Drawing.Size(508, 181);
            this.grpbxFiles.TabIndex = 0;
            this.grpbxFiles.TabStop = false;
            this.grpbxFiles.Text = "Files";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(27, 38);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(420, 22);
            this.txtFilePath.TabIndex = 7;
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(456, 38);
            this.btnBrowseFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(35, 28);
            this.btnBrowseFiles.TabIndex = 6;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(332, 118);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(116, 42);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(177, 119);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 42);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLastAccessed
            // 
            this.btnLastAccessed.Location = new System.Drawing.Point(177, 70);
            this.btnLastAccessed.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastAccessed.Name = "btnLastAccessed";
            this.btnLastAccessed.Size = new System.Drawing.Size(116, 42);
            this.btnLastAccessed.TabIndex = 2;
            this.btnLastAccessed.Text = "Last Accessed";
            this.btnLastAccessed.UseVisualStyleBackColor = true;
            this.btnLastAccessed.Click += new System.EventHandler(this.btnLastAccessed_Click);
            // 
            // btnCreated
            // 
            this.btnCreated.Location = new System.Drawing.Point(27, 118);
            this.btnCreated.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreated.Name = "btnCreated";
            this.btnCreated.Size = new System.Drawing.Size(116, 42);
            this.btnCreated.TabIndex = 1;
            this.btnCreated.Text = "Created";
            this.btnCreated.UseVisualStyleBackColor = true;
            this.btnCreated.Click += new System.EventHandler(this.btnCreated_Click);
            // 
            // btnAttributes
            // 
            this.btnAttributes.Location = new System.Drawing.Point(27, 70);
            this.btnAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttributes.Name = "btnAttributes";
            this.btnAttributes.Size = new System.Drawing.Size(116, 42);
            this.btnAttributes.TabIndex = 0;
            this.btnAttributes.Text = "Attributes";
            this.btnAttributes.UseVisualStyleBackColor = true;
            this.btnAttributes.Click += new System.EventHandler(this.btnAttributes_Click);
            // 
            // grpbxDirectories
            // 
            this.grpbxDirectories.Controls.Add(this.txtDirectoryFilePath);
            this.grpbxDirectories.Controls.Add(this.btnBrowseDirectories);
            this.grpbxDirectories.Controls.Add(this.btnClose);
            this.grpbxDirectories.Controls.Add(this.btnListFiles);
            this.grpbxDirectories.Location = new System.Drawing.Point(17, 204);
            this.grpbxDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxDirectories.Name = "grpbxDirectories";
            this.grpbxDirectories.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxDirectories.Size = new System.Drawing.Size(508, 132);
            this.grpbxDirectories.TabIndex = 1;
            this.grpbxDirectories.TabStop = false;
            this.grpbxDirectories.Text = "Directories";
            // 
            // txtDirectoryFilePath
            // 
            this.txtDirectoryFilePath.Location = new System.Drawing.Point(27, 42);
            this.txtDirectoryFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectoryFilePath.Name = "txtDirectoryFilePath";
            this.txtDirectoryFilePath.Size = new System.Drawing.Size(420, 22);
            this.txtDirectoryFilePath.TabIndex = 8;
            // 
            // btnBrowseDirectories
            // 
            this.btnBrowseDirectories.Location = new System.Drawing.Point(456, 38);
            this.btnBrowseDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseDirectories.Name = "btnBrowseDirectories";
            this.btnBrowseDirectories.Size = new System.Drawing.Size(35, 28);
            this.btnBrowseDirectories.TabIndex = 2;
            this.btnBrowseDirectories.Text = "...";
            this.btnBrowseDirectories.UseVisualStyleBackColor = true;
            this.btnBrowseDirectories.Click += new System.EventHandler(this.btnBrowseDirectories_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 74);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListFiles
            // 
            this.btnListFiles.Location = new System.Drawing.Point(27, 74);
            this.btnListFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(116, 42);
            this.btnListFiles.TabIndex = 0;
            this.btnListFiles.Text = "List Files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // CfrmFileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 367);
            this.ControlBox = false;
            this.Controls.Add(this.grpbxDirectories);
            this.Controls.Add(this.grpbxFiles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CfrmFileManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files & Directories";
            this.grpbxFiles.ResumeLayout(false);
            this.grpbxFiles.PerformLayout();
            this.grpbxDirectories.ResumeLayout(false);
            this.grpbxDirectories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxFiles;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLastAccessed;
        private System.Windows.Forms.Button btnCreated;
        private System.Windows.Forms.Button btnAttributes;
        private System.Windows.Forms.GroupBox grpbxDirectories;
        private System.Windows.Forms.TextBox txtDirectoryFilePath;
        private System.Windows.Forms.Button btnBrowseDirectories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
    }
}

