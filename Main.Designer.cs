namespace Zipper
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.CreateTab = new MetroFramework.Controls.MetroTabPage();
            this.CreateZip = new MetroFramework.Controls.MetroButton();
            this.AddFile = new MetroFramework.Controls.MetroButton();
            this.FileList = new MetroFramework.Controls.MetroGrid();
            this.ExtractTab = new MetroFramework.Controls.MetroTabPage();
            this.RemoveFile = new MetroFramework.Controls.MetroButton();
            this.AddDirectoryFiles = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.mainTabControl.SuspendLayout();
            this.CreateTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).BeginInit();
            this.ExtractTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.CreateTab);
            this.mainTabControl.Controls.Add(this.ExtractTab);
            this.mainTabControl.Location = new System.Drawing.Point(23, 63);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 1;
            this.mainTabControl.Size = new System.Drawing.Size(321, 205);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTabControl.UseSelectable = true;
            // 
            // CreateTab
            // 
            this.CreateTab.Controls.Add(this.AddDirectoryFiles);
            this.CreateTab.Controls.Add(this.RemoveFile);
            this.CreateTab.Controls.Add(this.CreateZip);
            this.CreateTab.Controls.Add(this.AddFile);
            this.CreateTab.Controls.Add(this.FileList);
            this.CreateTab.HorizontalScrollbarBarColor = true;
            this.CreateTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CreateTab.HorizontalScrollbarSize = 10;
            this.CreateTab.Location = new System.Drawing.Point(4, 38);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Size = new System.Drawing.Size(313, 163);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Create";
            this.CreateTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreateTab.VerticalScrollbarBarColor = true;
            this.CreateTab.VerticalScrollbarHighlightOnWheel = false;
            this.CreateTab.VerticalScrollbarSize = 10;
            // 
            // CreateZip
            // 
            this.CreateZip.Location = new System.Drawing.Point(237, 3);
            this.CreateZip.Name = "CreateZip";
            this.CreateZip.Size = new System.Drawing.Size(73, 45);
            this.CreateZip.TabIndex = 4;
            this.CreateZip.Text = "ZIP";
            this.CreateZip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreateZip.UseSelectable = true;
            this.CreateZip.Click += new System.EventHandler(this.CreateZip_Click);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(79, 3);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(73, 45);
            this.AddFile.TabIndex = 3;
            this.AddFile.Text = "Add File";
            this.AddFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddFile.UseSelectable = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // FileList
            // 
            this.FileList.AllowUserToResizeRows = false;
            this.FileList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileList.DefaultCellStyle = dataGridViewCellStyle11;
            this.FileList.EnableHeadersVisualStyles = false;
            this.FileList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.FileList.Location = new System.Drawing.Point(2, 54);
            this.FileList.Name = "FileList";
            this.FileList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.FileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileList.Size = new System.Drawing.Size(315, 106);
            this.FileList.TabIndex = 2;
            this.FileList.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ExtractTab
            // 
            this.ExtractTab.Controls.Add(this.metroButton1);
            this.ExtractTab.Controls.Add(this.metroButton2);
            this.ExtractTab.Controls.Add(this.metroButton3);
            this.ExtractTab.Controls.Add(this.metroButton4);
            this.ExtractTab.HorizontalScrollbarBarColor = true;
            this.ExtractTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ExtractTab.HorizontalScrollbarSize = 10;
            this.ExtractTab.Location = new System.Drawing.Point(4, 38);
            this.ExtractTab.Name = "ExtractTab";
            this.ExtractTab.Size = new System.Drawing.Size(313, 163);
            this.ExtractTab.TabIndex = 1;
            this.ExtractTab.Text = "Extract";
            this.ExtractTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExtractTab.VerticalScrollbarBarColor = true;
            this.ExtractTab.VerticalScrollbarHighlightOnWheel = false;
            this.ExtractTab.VerticalScrollbarSize = 10;
            // 
            // RemoveFile
            // 
            this.RemoveFile.Location = new System.Drawing.Point(158, 3);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(73, 45);
            this.RemoveFile.TabIndex = 5;
            this.RemoveFile.Text = "Remove \r\nFile";
            this.RemoveFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RemoveFile.UseSelectable = true;
            this.RemoveFile.Click += new System.EventHandler(this.RemoveFile_Click);
            // 
            // AddDirectoryFiles
            // 
            this.AddDirectoryFiles.Location = new System.Drawing.Point(0, 3);
            this.AddDirectoryFiles.Name = "AddDirectoryFiles";
            this.AddDirectoryFiles.Size = new System.Drawing.Size(73, 45);
            this.AddDirectoryFiles.TabIndex = 6;
            this.AddDirectoryFiles.Text = "Add From \r\nDirectory";
            this.AddDirectoryFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddDirectoryFiles.UseSelectable = true;
            this.AddDirectoryFiles.Click += new System.EventHandler(this.AddDirectoryFiles_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(73, 45);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Open \r\nArchive";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(158, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(73, 45);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Extract \r\nSelected";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(237, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(73, 45);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "ZIP";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(79, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(73, 45);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Extract To";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 291);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Zipper";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).EndInit();
            this.ExtractTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTabPage CreateTab;
        private MetroFramework.Controls.MetroGrid FileList;
        private MetroFramework.Controls.MetroTabPage ExtractTab;
        private MetroFramework.Controls.MetroButton CreateZip;
        private MetroFramework.Controls.MetroButton AddFile;
        private MetroFramework.Controls.MetroButton RemoveFile;
        private MetroFramework.Controls.MetroButton AddDirectoryFiles;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;

    }
}

