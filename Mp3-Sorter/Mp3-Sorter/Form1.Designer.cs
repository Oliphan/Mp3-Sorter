namespace Mp3_Sorter
{
    partial class mainFrm
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortToNewFolderChkBox = new System.Windows.Forms.CheckBox();
            this.dirPathTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowseBtn = new System.Windows.Forms.Button();
            this.includeSubfoldersChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(255, 41);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortToNewFolderChkBox
            // 
            this.sortToNewFolderChkBox.AutoSize = true;
            this.sortToNewFolderChkBox.Checked = true;
            this.sortToNewFolderChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortToNewFolderChkBox.Location = new System.Drawing.Point(132, 45);
            this.sortToNewFolderChkBox.Name = "sortToNewFolderChkBox";
            this.sortToNewFolderChkBox.Size = new System.Drawing.Size(117, 17);
            this.sortToNewFolderChkBox.TabIndex = 2;
            this.sortToNewFolderChkBox.Text = "Sort into new folder";
            this.sortToNewFolderChkBox.UseVisualStyleBackColor = true;
            // 
            // dirPathTxtBox
            // 
            this.dirPathTxtBox.Location = new System.Drawing.Point(82, 14);
            this.dirPathTxtBox.Name = "dirPathTxtBox";
            this.dirPathTxtBox.Size = new System.Drawing.Size(167, 20);
            this.dirPathTxtBox.TabIndex = 3;
            this.dirPathTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dirPathTxtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder Path:";
            // 
            // folderBrowseBtn
            // 
            this.folderBrowseBtn.Location = new System.Drawing.Point(255, 12);
            this.folderBrowseBtn.Name = "folderBrowseBtn";
            this.folderBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBrowseBtn.TabIndex = 5;
            this.folderBrowseBtn.Text = "Browse";
            this.folderBrowseBtn.UseVisualStyleBackColor = true;
            this.folderBrowseBtn.Click += new System.EventHandler(this.folderBrowseBtn_Click);
            // 
            // includeSubfoldersChkBox
            // 
            this.includeSubfoldersChkBox.AutoSize = true;
            this.includeSubfoldersChkBox.Checked = true;
            this.includeSubfoldersChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSubfoldersChkBox.Location = new System.Drawing.Point(12, 45);
            this.includeSubfoldersChkBox.Name = "includeSubfoldersChkBox";
            this.includeSubfoldersChkBox.Size = new System.Drawing.Size(114, 17);
            this.includeSubfoldersChkBox.TabIndex = 6;
            this.includeSubfoldersChkBox.Text = "Include Subfolders";
            this.includeSubfoldersChkBox.UseVisualStyleBackColor = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 76);
            this.Controls.Add(this.includeSubfoldersChkBox);
            this.Controls.Add(this.folderBrowseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirPathTxtBox);
            this.Controls.Add(this.sortToNewFolderChkBox);
            this.Controls.Add(this.sortBtn);
            this.Name = "mainFrm";
            this.Text = "Mp3 Sorter - Select a folder";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.CheckBox sortToNewFolderChkBox;
        private System.Windows.Forms.TextBox dirPathTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folderBrowseBtn;
        private System.Windows.Forms.CheckBox includeSubfoldersChkBox;
    }
}

