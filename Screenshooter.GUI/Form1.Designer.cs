namespace Screenshooter.GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colVersionNumber = new System.Windows.Forms.ColumnHeader();
            this.colDescription = new System.Windows.Forms.ColumnHeader();
            this.colCompanyName = new System.Windows.Forms.ColumnHeader();
            this.colCopyright = new System.Windows.Forms.ColumnHeader();
            this.colTrademark = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.colLanguage = new System.Windows.Forms.ColumnHeader();
            this.colSha1 = new System.Windows.Forms.ColumnHeader();
            this.colIdentified = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colProductName,
            this.colVersionNumber,
            this.colDescription,
            this.colCompanyName,
            this.colCopyright,
            this.colTrademark,
            this.colSize,
            this.colLanguage,
            this.colSha1,
            this.colIdentified});
            this.lvFiles.ContextMenuStrip = this.contextMenuStrip;
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(1396, 729);
            this.lvFiles.SmallImageList = this.icons;
            this.lvFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 300;
            // 
            // colProductName
            // 
            this.colProductName.Text = "Product Name";
            this.colProductName.Width = 100;
            // 
            // colVersionNumber
            // 
            this.colVersionNumber.Text = "Version Number";
            this.colVersionNumber.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 100;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Text = "Company Name";
            this.colCompanyName.Width = 100;
            // 
            // colCopyright
            // 
            this.colCopyright.Text = "Copyright";
            this.colCopyright.Width = 100;
            // 
            // colTrademark
            // 
            this.colTrademark.Text = "Trademark";
            this.colTrademark.Width = 100;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 100;
            // 
            // colLanguage
            // 
            this.colLanguage.Text = "Language";
            this.colLanguage.Width = 100;
            // 
            // colSha1
            // 
            this.colSha1.Text = "Sha1";
            this.colSha1.Width = 200;
            // 
            // colIdentified
            // 
            this.colIdentified.Text = "Identified ?";
            this.colIdentified.Width = 80;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuReload,
            this.searchToolStripMenuItem,
            this.informationsToolStripMenuItem,
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(262, 114);
            // 
            // toolStripMenuReload
            // 
            this.toolStripMenuReload.Name = "toolStripMenuReload";
            this.toolStripMenuReload.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuReload.Text = "Reload";
            this.toolStripMenuReload.Click += new System.EventHandler(this.toolStripMenuReload_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.informationsToolStripMenuItem.Text = "Check VT";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // runTakeScreenshotAndAnalyzeItToolStripMenuItem
            // 
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem.Name = "runTakeScreenshotAndAnalyzeItToolStripMenuItem";
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem.Text = "Run, Take screenshot and Analyze it";
            this.runTakeScreenshotAndAnalyzeItToolStripMenuItem.Click += new System.EventHandler(this.runTakeScreenshotAndAnalyzeItToolStripMenuItem_Click);
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons.ImageSize = new System.Drawing.Size(16, 16);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbLogs
            // 
            this.tbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLogs.Location = new System.Drawing.Point(0, 0);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.ReadOnly = true;
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogs.Size = new System.Drawing.Size(1396, 729);
            this.tbLogs.TabIndex = 1;
            this.tbLogs.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 729);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tbLogs);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvFiles;
        private ColumnHeader colName;
        private ColumnHeader colProductName;
        private ColumnHeader colVersionNumber;
        private ColumnHeader colDescription;
        private ColumnHeader colCompanyName;
        private ColumnHeader colCopyright;
        private ColumnHeader colTrademark;
        private ColumnHeader colSize;
        private ColumnHeader colSha1;
        private ColumnHeader colLanguage;
        private ImageList icons;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuReload;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ColumnHeader colIdentified;
        private ToolStripMenuItem informationsToolStripMenuItem;
        private ToolStripMenuItem runTakeScreenshotAndAnalyzeItToolStripMenuItem;
        private TextBox tbLogs;
    }
}