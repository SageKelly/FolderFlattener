namespace Folder_Flattener
{
    partial class 
        FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.p_ButtonError = new System.Windows.Forms.Panel();
            this.p_Buttons = new System.Windows.Forms.Panel();
            this.b_ShowErrors = new System.Windows.Forms.Button();
            this.b_OpenListFile = new System.Windows.Forms.Button();
            this.b_Flatten = new System.Windows.Forms.Button();
            this.b_ExportPreview = new System.Windows.Forms.Button();
            this.b_FolderExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tt_b_Flatten = new System.Windows.Forms.ToolTip(this.components);
            this.tt_b_ExportPreview = new System.Windows.Forms.ToolTip(this.components);
            this.tt_b_FolderExport = new System.Windows.Forms.ToolTip(this.components);
            this.tt_b_OpenList = new System.Windows.Forms.ToolTip(this.components);
            this.d_openList = new System.Windows.Forms.OpenFileDialog();
            this.dgv_OpenList = new System.Windows.Forms.DataGridView();
            this.dgv_ExportPreview = new System.Windows.Forms.DataGridView();
            this.fbd_SourceMusicFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_FolderExport = new System.Windows.Forms.FolderBrowserDialog();
            this.p_Notification = new System.Windows.Forms.Panel();
            this.p_Tables = new System.Windows.Forms.Panel();
            this.p_ExportPreview = new System.Windows.Forms.Panel();
            this.s_OpenAndExport = new System.Windows.Forms.Splitter();
            this.p_OpenList = new System.Windows.Forms.Panel();
            this.s_NotificationAndTables = new System.Windows.Forms.Splitter();
            this.ss_Main = new System.Windows.Forms.StatusStrip();
            this.ss_Main_l_ExportDestination = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_Main_l_RowInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspb_Flatten = new System.Windows.Forms.ToolStripProgressBar();
            this.cms_CellRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyCellInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.d_BrowseFolder = new System.Windows.Forms.OpenFileDialog();
            this.p_ButtonError.SuspendLayout();
            this.p_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OpenList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExportPreview)).BeginInit();
            this.p_Tables.SuspendLayout();
            this.p_ExportPreview.SuspendLayout();
            this.p_OpenList.SuspendLayout();
            this.ss_Main.SuspendLayout();
            this.cms_CellRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_ButtonError
            // 
            this.p_ButtonError.Controls.Add(this.p_Buttons);
            this.p_ButtonError.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_ButtonError.Location = new System.Drawing.Point(0, 0);
            this.p_ButtonError.Name = "p_ButtonError";
            this.p_ButtonError.Size = new System.Drawing.Size(146, 586);
            this.p_ButtonError.TabIndex = 0;
            // 
            // p_Buttons
            // 
            this.p_Buttons.Controls.Add(this.b_ShowErrors);
            this.p_Buttons.Controls.Add(this.b_OpenListFile);
            this.p_Buttons.Controls.Add(this.b_Flatten);
            this.p_Buttons.Controls.Add(this.b_ExportPreview);
            this.p_Buttons.Controls.Add(this.b_FolderExport);
            this.p_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Buttons.Location = new System.Drawing.Point(0, 0);
            this.p_Buttons.Name = "p_Buttons";
            this.p_Buttons.Size = new System.Drawing.Size(146, 586);
            this.p_Buttons.TabIndex = 0;
            // 
            // b_ShowErrors
            // 
            this.b_ShowErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ShowErrors.AutoSize = true;
            this.b_ShowErrors.Enabled = false;
            this.b_ShowErrors.Location = new System.Drawing.Point(0, 211);
            this.b_ShowErrors.Name = "b_ShowErrors";
            this.b_ShowErrors.Size = new System.Drawing.Size(146, 46);
            this.b_ShowErrors.TabIndex = 4;
            this.b_ShowErrors.Text = "Show Errors";
            this.b_ShowErrors.UseVisualStyleBackColor = true;
            this.b_ShowErrors.Click += new System.EventHandler(this.B_ShowErrors_Click);
            // 
            // b_OpenListFile
            // 
            this.b_OpenListFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_OpenListFile.Location = new System.Drawing.Point(0, 3);
            this.b_OpenListFile.Name = "b_OpenListFile";
            this.b_OpenListFile.Size = new System.Drawing.Size(146, 46);
            this.b_OpenListFile.TabIndex = 1;
            this.b_OpenListFile.Text = "&Open List File";
            this.tt_b_OpenList.SetToolTip(this.b_OpenListFile, "Grabs the file containing a list\r\nof files to be fetched for\r\nexporting");
            this.b_OpenListFile.UseVisualStyleBackColor = true;
            this.b_OpenListFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.B_OpenListClick);
            // 
            // b_Flatten
            // 
            this.b_Flatten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Flatten.Location = new System.Drawing.Point(0, 159);
            this.b_Flatten.Name = "b_Flatten";
            this.b_Flatten.Size = new System.Drawing.Size(146, 46);
            this.b_Flatten.TabIndex = 0;
            this.b_Flatten.Text = "&Flatten";
            this.tt_b_Flatten.SetToolTip(this.b_Flatten, "Remove all subfolders, and move their files\r\nto the highest folder in the heirarc" +
        "hy");
            this.b_Flatten.UseVisualStyleBackColor = true;
            this.b_Flatten.Click += new System.EventHandler(this.B_Flatten_Click);
            // 
            // b_ExportPreview
            // 
            this.b_ExportPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ExportPreview.Location = new System.Drawing.Point(0, 107);
            this.b_ExportPreview.Name = "b_ExportPreview";
            this.b_ExportPreview.Size = new System.Drawing.Size(146, 46);
            this.b_ExportPreview.TabIndex = 3;
            this.b_ExportPreview.Text = "Export &Preview...";
            this.tt_b_ExportPreview.SetToolTip(this.b_ExportPreview, "Shows the contents of the destination folder\r\nbefore exporting and compares for\r\n" +
        "duplicates (shown in red).");
            this.b_ExportPreview.UseVisualStyleBackColor = true;
            this.b_ExportPreview.Click += new System.EventHandler(this.B_ExportPreview_Click);
            // 
            // b_FolderExport
            // 
            this.b_FolderExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_FolderExport.Location = new System.Drawing.Point(0, 55);
            this.b_FolderExport.Name = "b_FolderExport";
            this.b_FolderExport.Size = new System.Drawing.Size(146, 46);
            this.b_FolderExport.TabIndex = 2;
            this.b_FolderExport.Text = "Export &To Folder...";
            this.tt_b_FolderExport.SetToolTip(this.b_FolderExport, "Chooses the destination folder for exporting");
            this.b_FolderExport.UseVisualStyleBackColor = true;
            this.b_FolderExport.Click += new System.EventHandler(this.B_FolderExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tt_b_Flatten
            // 
            this.tt_b_Flatten.AutoPopDelay = 10000;
            this.tt_b_Flatten.InitialDelay = 500;
            this.tt_b_Flatten.ReshowDelay = 100;
            this.tt_b_Flatten.ToolTipTitle = "Flatten folders";
            // 
            // tt_b_ExportPreview
            // 
            this.tt_b_ExportPreview.AutoPopDelay = 10000;
            this.tt_b_ExportPreview.InitialDelay = 500;
            this.tt_b_ExportPreview.ReshowDelay = 100;
            this.tt_b_ExportPreview.ToolTipTitle = "Export Preview";
            // 
            // tt_b_FolderExport
            // 
            this.tt_b_FolderExport.ToolTipTitle = "Export To Folder";
            // 
            // tt_b_OpenList
            // 
            this.tt_b_OpenList.ToolTipTitle = "Open List";
            // 
            // d_openList
            // 
            this.d_openList.DefaultExt = "wpl";
            this.d_openList.Filter = resources.GetString("d_openList.Filter");
            this.d_openList.Title = "Open List";
            this.d_openList.FileOk += new System.ComponentModel.CancelEventHandler(this.D_OpenList_FileOk);
            // 
            // dgv_OpenList
            // 
            this.dgv_OpenList.AllowUserToAddRows = false;
            this.dgv_OpenList.AllowUserToDeleteRows = false;
            this.dgv_OpenList.AllowUserToResizeRows = false;
            this.dgv_OpenList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_OpenList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_OpenList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_OpenList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_OpenList.Location = new System.Drawing.Point(0, 0);
            this.dgv_OpenList.Name = "dgv_OpenList";
            this.dgv_OpenList.ShowEditingIcon = false;
            this.dgv_OpenList.Size = new System.Drawing.Size(200, 580);
            this.dgv_OpenList.TabIndex = 0;
            this.dgv_OpenList.TabStop = false;
            // 
            // dgv_ExportPreview
            // 
            this.dgv_ExportPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv_ExportPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ExportPreview.Location = new System.Drawing.Point(0, 0);
            this.dgv_ExportPreview.Name = "dgv_ExportPreview";
            this.dgv_ExportPreview.Size = new System.Drawing.Size(706, 580);
            this.dgv_ExportPreview.TabIndex = 0;
            this.dgv_ExportPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // fbd_SourceMusicFolder
            // 
            this.fbd_SourceMusicFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // p_Notification
            // 
            this.p_Notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Notification.Location = new System.Drawing.Point(0, 0);
            this.p_Notification.Name = "p_Notification";
            this.p_Notification.Size = new System.Drawing.Size(1058, 78);
            this.p_Notification.TabIndex = 1;
            // 
            // p_Tables
            // 
            this.p_Tables.Controls.Add(this.p_ExportPreview);
            this.p_Tables.Controls.Add(this.s_OpenAndExport);
            this.p_Tables.Controls.Add(this.p_OpenList);
            this.p_Tables.Controls.Add(this.s_NotificationAndTables);
            this.p_Tables.Controls.Add(this.p_ButtonError);
            this.p_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Tables.Location = new System.Drawing.Point(0, 78);
            this.p_Tables.Name = "p_Tables";
            this.p_Tables.Size = new System.Drawing.Size(1058, 586);
            this.p_Tables.TabIndex = 2;
            // 
            // p_ExportPreview
            // 
            this.p_ExportPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_ExportPreview.Controls.Add(this.dgv_ExportPreview);
            this.p_ExportPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_ExportPreview.Location = new System.Drawing.Point(352, 6);
            this.p_ExportPreview.Name = "p_ExportPreview";
            this.p_ExportPreview.Size = new System.Drawing.Size(706, 580);
            this.p_ExportPreview.TabIndex = 3;
            // 
            // s_OpenAndExport
            // 
            this.s_OpenAndExport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s_OpenAndExport.Location = new System.Drawing.Point(346, 6);
            this.s_OpenAndExport.Name = "s_OpenAndExport";
            this.s_OpenAndExport.Size = new System.Drawing.Size(6, 580);
            this.s_OpenAndExport.TabIndex = 2;
            this.s_OpenAndExport.TabStop = false;
            // 
            // p_OpenList
            // 
            this.p_OpenList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_OpenList.Controls.Add(this.dgv_OpenList);
            this.p_OpenList.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_OpenList.Location = new System.Drawing.Point(146, 6);
            this.p_OpenList.Name = "p_OpenList";
            this.p_OpenList.Size = new System.Drawing.Size(200, 580);
            this.p_OpenList.TabIndex = 1;
            // 
            // s_NotificationAndTables
            // 
            this.s_NotificationAndTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s_NotificationAndTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.s_NotificationAndTables.Location = new System.Drawing.Point(146, 0);
            this.s_NotificationAndTables.Name = "s_NotificationAndTables";
            this.s_NotificationAndTables.Size = new System.Drawing.Size(912, 6);
            this.s_NotificationAndTables.TabIndex = 0;
            this.s_NotificationAndTables.TabStop = false;
            // 
            // ss_Main
            // 
            this.ss_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_Main_l_ExportDestination,
            this.ss_Main_l_RowInfo,
            this.toolStripStatusLabel2,
            this.tspb_Flatten});
            this.ss_Main.Location = new System.Drawing.Point(0, 664);
            this.ss_Main.Name = "ss_Main";
            this.ss_Main.Size = new System.Drawing.Size(1058, 22);
            this.ss_Main.TabIndex = 1;
            // 
            // ss_Main_l_ExportDestination
            // 
            this.ss_Main_l_ExportDestination.Name = "ss_Main_l_ExportDestination";
            this.ss_Main_l_ExportDestination.Size = new System.Drawing.Size(0, 17);
            // 
            // ss_Main_l_RowInfo
            // 
            this.ss_Main_l_RowInfo.Name = "ss_Main_l_RowInfo";
            this.ss_Main_l_RowInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tspb_Flatten
            // 
            this.tspb_Flatten.Name = "tspb_Flatten";
            this.tspb_Flatten.Size = new System.Drawing.Size(100, 16);
            // 
            // cms_CellRightClick
            // 
            this.cms_CellRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyCellInfo});
            this.cms_CellRightClick.Name = "cms_CellRightClick";
            this.cms_CellRightClick.Size = new System.Drawing.Size(150, 26);
            // 
            // CopyCellInfo
            // 
            this.CopyCellInfo.Name = "CopyCellInfo";
            this.CopyCellInfo.Size = new System.Drawing.Size(149, 22);
            this.CopyCellInfo.Text = "Copy Cell Info";
            // 
            // d_BrowseFolder
            // 
            this.d_BrowseFolder.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1058, 686);
            this.Controls.Add(this.p_Tables);
            this.Controls.Add(this.p_Notification);
            this.Controls.Add(this.ss_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Folder Flattener";
            this.p_ButtonError.ResumeLayout(false);
            this.p_Buttons.ResumeLayout(false);
            this.p_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OpenList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExportPreview)).EndInit();
            this.p_Tables.ResumeLayout(false);
            this.p_ExportPreview.ResumeLayout(false);
            this.p_OpenList.ResumeLayout(false);
            this.ss_Main.ResumeLayout(false);
            this.ss_Main.PerformLayout();
            this.cms_CellRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_ButtonError;
        private System.Windows.Forms.Panel p_Buttons;
        private System.Windows.Forms.Panel p_Notification;
        private System.Windows.Forms.Button b_Flatten;
        private System.Windows.Forms.Button b_ExportPreview;
        private System.Windows.Forms.Button b_FolderExport;
        private System.Windows.Forms.Button b_OpenListFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip tt_b_Flatten;
        private System.Windows.Forms.ToolTip tt_b_ExportPreview;
        private System.Windows.Forms.ToolTip tt_b_FolderExport;
        private System.Windows.Forms.ToolTip tt_b_OpenList;
        private System.Windows.Forms.OpenFileDialog d_openList;
        private System.Windows.Forms.FolderBrowserDialog fbd_SourceMusicFolder;
        private System.Windows.Forms.FolderBrowserDialog fbd_FolderExport;
        private System.Windows.Forms.DataGridView dgv_OpenList;
        private System.Windows.Forms.DataGridView dgv_ExportPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_Tables;
        private System.Windows.Forms.Splitter s_NotificationAndTables;
        private System.Windows.Forms.Panel p_ExportPreview;
        private System.Windows.Forms.Splitter s_OpenAndExport;
        private System.Windows.Forms.Panel p_OpenList;
        private System.Windows.Forms.StatusStrip ss_Main;
        private System.Windows.Forms.ToolStripStatusLabel ss_Main_l_ExportDestination;
        private System.Windows.Forms.ToolStripStatusLabel ss_Main_l_RowInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip cms_CellRightClick;
        private System.Windows.Forms.ToolStripMenuItem CopyCellInfo;
        private System.Windows.Forms.ToolStripProgressBar tspb_Flatten;
        private System.Windows.Forms.OpenFileDialog d_BrowseFolder;
        private System.Windows.Forms.Button b_ShowErrors;
    }
}

