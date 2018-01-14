using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TagLib;

namespace Mp3_Sorter
{
    public partial class mainFrm : Form
    {
        string loadedFolderPath;
        List<string> audioFilePaths;
        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            loadedFolderPath = Application.StartupPath;
            folderBrowser.SelectedPath = loadedFolderPath;
            dirPathTxtBox.Text = loadedFolderPath;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if(audioFilePaths != null && audioFilePaths.Count > 0)
            {
                string sortedFilesDestination = loadedFolderPath;
                if (sortToNewFolderChkBox.Checked)
                {
                    sortedFilesDestination += @"\Sorted";
                    if (!System.IO.Directory.Exists(sortedFilesDestination))
                    {
                        System.IO.Directory.CreateDirectory(sortedFilesDestination);
                    }
                }
                
                for (int i=0; i < audioFilePaths.Count; i++)
                {
                    File musicFile = File.Create(audioFilePaths[i]);
                    string newFileDir = sortedFilesDestination + @"\" + musicFile.Tag.FirstPerformer + @"\" + musicFile.Tag.Album;
                    if(!System.IO.Directory.Exists(newFileDir))
                    {
                        System.IO.Directory.CreateDirectory(newFileDir);
                    }
                    newFileDir += @"\" + System.IO.Path.GetFileName(audioFilePaths[i]);
                    if (!System.IO.File.Exists(newFileDir))
                    {
                        System.IO.File.Copy(audioFilePaths[i], newFileDir);
                    }
                }
                Text = "Mp3 Sorter - Files sorted";
            }
            else
            {
                Text = "Mp3 Sorter - No files found";
            }
        }

        private void folderBrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                loadedFolderPath = folderBrowser.SelectedPath;
                dirPathTxtBox.Text = loadedFolderPath;
                loadMp3sFromDirectory();
            }
        }

        private void dirPathTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (System.IO.Directory.Exists(dirPathTxtBox.Text))
                {
                    loadedFolderPath = dirPathTxtBox.Text;
                    loadMp3sFromDirectory();
                }
            }
        }

        private void loadMp3sFromDirectory()
        {
            List<string> filesInPath = new List<string>();
            audioFilePaths = new List<string>();
            filesInPath.AddRange(System.IO.Directory.GetFiles(loadedFolderPath));
            if (includeSubfoldersChkBox.Checked)
            {
                List<string> subDirs = new List<string>();
                subDirs.AddRange(System.IO.Directory.GetDirectories(loadedFolderPath));
                while (subDirs.Count > 0)
                {
                    subDirs.AddRange(System.IO.Directory.GetDirectories(subDirs[0]));
                    filesInPath.AddRange(System.IO.Directory.GetFiles(subDirs[0]));
                    subDirs.RemoveAt(0);
                }
            }
            for (int i = 0; i < filesInPath.Count; i++)
            {
                if (filesInPath[i].EndsWith(".mp3") || filesInPath[i].EndsWith(".wav") || filesInPath[i].EndsWith(".ogg") || filesInPath[i].EndsWith(".flac"))
                {
                    audioFilePaths.Add(filesInPath[i]);
                }
            }
        }
    }
}
