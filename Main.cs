using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Zipper
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        IList<zipinfo> fileList = new List<zipinfo>();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileList.ColumnCount = 3;
            FileList.Columns[0].Name = "Name";
            FileList.Columns[1].Name = "Location";
            FileList.Columns[2].Name = "Size";
            for (int i = 0; i < FileList.Columns.Count; i++) { FileList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; }
            RemoveFile.Enabled = CreateZip.Enabled = false;
        }

        private void AddDirectoryFiles_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string dirFiles in Directory.GetFiles(fbd.SelectedPath))
                    {
                        FileInfo file = new FileInfo(dirFiles);
                        zipinfo newFile = new zipinfo(file.Name, dirFiles, file.Length, file);
                        fileList.Add(newFile);
                        updateFileList();
                    }
                    foreach (string dirFile in Directory.GetDirectories(fbd.SelectedPath))
                    {
                        foreach (string dirFiles in Directory.GetFiles(dirFile))
                        {
                            FileInfo file = new FileInfo(dirFiles);
                            zipinfo newFile = new zipinfo(file.Name, Path.Combine(dirFile, dirFiles), file.Length, file);
                            fileList.Add(newFile);
                            updateFileList();
                        }
                    }
                }
            }
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(ofd.FileName);
                    zipinfo newFile = new zipinfo(file.Name, ofd.FileName, file.Length, file);
                    fileList.Add(newFile);
                    updateFileList();
                }
            }
        }

        private void RemoveFile_Click(object sender, EventArgs e)
        {
            fileList.RemoveAt(FileList.CurrentCell.RowIndex);
            updateFileList();
        }

        private void CreateZip_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    List<string> List = new List<string>();
                    foreach (zipinfo file in fileList)
                        List.Add(file.location);
                    Compression.AddToArchive(sfd.FileName, List, Compression.ArchiveAction.Replace, Compression.Overwrite.IfNewer, CompressionLevel.Optimal);
                }
            }
        }

        private void updateFileList()
        {
            RemoveFile.Enabled = CreateZip.Enabled = Convert.ToBoolean(fileList.Count);
            FileList.Rows.Clear();
            foreach (zipinfo newFile in fileList)
                FileList.Rows.Add(new string[] { newFile.name, newFile.location, newFile.size });
        }
    }
    public class zipinfo
    {
        public string name { get; private set; }
        public string location { get; private set; }
        public string size { get; private set; }
        public FileInfo fileInfo { get; private set; }
        public zipinfo() { }
        public zipinfo(string name, string location, long size, FileInfo fileInfo)
        {
            this.name = name;
            this.location = location;
            this.size = ((ConvertBytesToKilobytes(size) < 1) ? size.ToString("#.##") + "B" : (ConvertBytesToMegabytes(size) < 1) ? ConvertBytesToKilobytes(size).ToString("#.##") + "Kb" : ConvertBytesToMegabytes(size).ToString("#.##") + "Mb");
            this.fileInfo = fileInfo;
        }
        private static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
        private static double ConvertBytesToKilobytes(long bytes)
        {
            return (bytes / 1024f);
        }
    }
}
