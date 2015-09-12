namespace ppmd_statsutil_gui
{
    partial class MainWindows
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpPaths = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutRomFile = new System.Windows.Forms.Button();
            this.txtInRomPath = new System.Windows.Forms.TextBox();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.btnInFile = new System.Windows.Forms.Button();
            this.btnInDir = new System.Windows.Forms.Button();
            this.btnOutDir = new System.Windows.Forms.Button();
            this.txtOutRomPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpImports = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chklstExport = new System.Windows.Forms.CheckedListBox();
            this.contmenuCheckExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitChkAllExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mitUnChkAllExport = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExtractRom = new System.Windows.Forms.Button();
            this.grpEdits = new System.Windows.Forms.GroupBox();
            this.splitEditData = new System.Windows.Forms.SplitContainer();
            this.tvEditableData = new System.Windows.Forms.TreeView();
            this.tbllayEditData = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEditOutside = new System.Windows.Forms.Button();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRebuildRom = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chklstImport = new System.Windows.Forms.CheckedListBox();
            this.contmenuCheckImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitChkAllImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mitUnChkAllImport = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.fswExportedData = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainLayout.SuspendLayout();
            this.grpPaths.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpImports.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contmenuCheckExport.SuspendLayout();
            this.grpEdits.SuspendLayout();
            this.splitEditData.Panel1.SuspendLayout();
            this.splitEditData.Panel2.SuspendLayout();
            this.splitEditData.SuspendLayout();
            this.tbllayEditData.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contmenuCheckImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswExportedData)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.ColumnCount = 4;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57306F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57306F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57306F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28082F));
            this.MainLayout.Controls.Add(this.grpPaths, 0, 0);
            this.MainLayout.Controls.Add(this.grpImports, 0, 1);
            this.MainLayout.Controls.Add(this.grpEdits, 2, 1);
            this.MainLayout.Controls.Add(this.lnkGithub, 1, 3);
            this.MainLayout.Controls.Add(this.lnkWiki, 0, 3);
            this.MainLayout.Controls.Add(this.grpExport, 0, 2);
            this.MainLayout.Controls.Add(this.pbLogo, 3, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.33396F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.83302F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.83302F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(714, 542);
            this.MainLayout.TabIndex = 0;
            // 
            // grpPaths
            // 
            this.grpPaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.SetColumnSpan(this.grpPaths, 3);
            this.grpPaths.Controls.Add(this.tableLayoutPanel2);
            this.grpPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaths.Location = new System.Drawing.Point(3, 3);
            this.grpPaths.Name = "grpPaths";
            this.grpPaths.Size = new System.Drawing.Size(606, 100);
            this.grpPaths.TabIndex = 1;
            this.grpPaths.TabStop = false;
            this.grpPaths.Text = "Step #1 - Set the path to the ROM data, and the path to export data to.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.16667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.16667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOutRomFile, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtInRomPath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtExportPath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnInFile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInDir, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOutDir, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtOutRomPath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ROM File/Dir:";
            // 
            // btnOutRomFile
            // 
            this.btnOutRomFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOutRomFile.Location = new System.Drawing.Point(437, 57);
            this.btnOutRomFile.Name = "btnOutRomFile";
            this.btnOutRomFile.Size = new System.Drawing.Size(75, 21);
            this.btnOutRomFile.TabIndex = 7;
            this.btnOutRomFile.Text = "Browse File..";
            this.btnOutRomFile.UseVisualStyleBackColor = true;
            this.btnOutRomFile.Click += new System.EventHandler(this.btnOutRomFile_Click);
            // 
            // txtInRomPath
            // 
            this.txtInRomPath.AllowDrop = true;
            this.txtInRomPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInRomPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtInRomPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInRomPath.Location = new System.Drawing.Point(94, 3);
            this.txtInRomPath.Name = "txtInRomPath";
            this.txtInRomPath.Size = new System.Drawing.Size(337, 20);
            this.txtInRomPath.TabIndex = 1;
            this.txtInRomPath.Text = "Path to ROM / Extracted ROM";
            this.txtInRomPath.TextChanged += new System.EventHandler(this.txtInRomPath_TextChanged);
            this.txtInRomPath.Enter += new System.EventHandler(this.txtRomPath_Enter);
            // 
            // txtExportPath
            // 
            this.txtExportPath.AllowDrop = true;
            this.txtExportPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtExportPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtExportPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExportPath.Location = new System.Drawing.Point(94, 30);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(337, 20);
            this.txtExportPath.TabIndex = 1;
            this.txtExportPath.Text = "./exported_data";
            this.txtExportPath.TextChanged += new System.EventHandler(this.txtExportPath_TextChanged);
            // 
            // btnInFile
            // 
            this.btnInFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInFile.Location = new System.Drawing.Point(437, 3);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(75, 21);
            this.btnInFile.TabIndex = 2;
            this.btnInFile.Text = "Browse File..";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // btnInDir
            // 
            this.btnInDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInDir.Location = new System.Drawing.Point(518, 3);
            this.btnInDir.Name = "btnInDir";
            this.btnInDir.Size = new System.Drawing.Size(79, 21);
            this.btnInDir.TabIndex = 4;
            this.btnInDir.Text = "Browse Dir..";
            this.btnInDir.UseVisualStyleBackColor = true;
            this.btnInDir.Click += new System.EventHandler(this.btnInDir_Click);
            // 
            // btnOutDir
            // 
            this.btnOutDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOutDir.Location = new System.Drawing.Point(518, 30);
            this.btnOutDir.Name = "btnOutDir";
            this.btnOutDir.Size = new System.Drawing.Size(79, 21);
            this.btnOutDir.TabIndex = 5;
            this.btnOutDir.Text = "Browse Dir..";
            this.btnOutDir.UseVisualStyleBackColor = true;
            this.btnOutDir.Click += new System.EventHandler(this.btnOutDir_Click);
            // 
            // txtOutRomPath
            // 
            this.txtOutRomPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOutRomPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtOutRomPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutRomPath.Location = new System.Drawing.Point(94, 57);
            this.txtOutRomPath.Name = "txtOutRomPath";
            this.txtOutRomPath.Size = new System.Drawing.Size(337, 20);
            this.txtOutRomPath.TabIndex = 6;
            this.txtOutRomPath.Text = "Path to Place Edited ROM";
            this.txtOutRomPath.TextChanged += new System.EventHandler(this.txtOutRomPath_TextChanged);
            this.txtOutRomPath.Enter += new System.EventHandler(this.txtOutRomPath_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Export Directory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modified ROM:";
            // 
            // grpImports
            // 
            this.grpImports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.SetColumnSpan(this.grpImports, 2);
            this.grpImports.Controls.Add(this.tableLayoutPanel3);
            this.grpImports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImports.Enabled = false;
            this.grpImports.Location = new System.Drawing.Point(3, 109);
            this.grpImports.Name = "grpImports";
            this.grpImports.Size = new System.Drawing.Size(402, 201);
            this.grpImports.TabIndex = 2;
            this.grpImports.TabStop = false;
            this.grpImports.Text = "Step #2 - Export the game\'s data to an editable format";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnExport, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnExtractRom, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(396, 182);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox4, 4);
            this.groupBox4.Controls.Add(this.chklstExport);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 139);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "What to export from the game ?";
            // 
            // chklstExport
            // 
            this.chklstExport.CheckOnClick = true;
            this.chklstExport.ContextMenuStrip = this.contmenuCheckExport;
            this.chklstExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstExport.FormattingEnabled = true;
            this.chklstExport.Items.AddRange(new object[] {
            "Item Data",
            "Move Data",
            "Pokemon Stats",
            "Text"});
            this.chklstExport.Location = new System.Drawing.Point(3, 16);
            this.chklstExport.MultiColumn = true;
            this.chklstExport.Name = "chklstExport";
            this.chklstExport.Size = new System.Drawing.Size(384, 120);
            this.chklstExport.Sorted = true;
            this.chklstExport.TabIndex = 0;
            this.chklstExport.UseCompatibleTextRendering = true;
            // 
            // contmenuCheckExport
            // 
            this.contmenuCheckExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitChkAllExport,
            this.mitUnChkAllExport});
            this.contmenuCheckExport.Name = "contextMenuStrip1";
            this.contmenuCheckExport.Size = new System.Drawing.Size(138, 48);
            // 
            // mitChkAllExport
            // 
            this.mitChkAllExport.Name = "mitChkAllExport";
            this.mitChkAllExport.Size = new System.Drawing.Size(137, 22);
            this.mitChkAllExport.Text = "Check &All";
            this.mitChkAllExport.Click += new System.EventHandler(this.mitChkAllExport_Click);
            // 
            // mitUnChkAllExport
            // 
            this.mitUnChkAllExport.Name = "mitUnChkAllExport";
            this.mitUnChkAllExport.Size = new System.Drawing.Size(137, 22);
            this.mitUnChkAllExport.Text = "&Uncheck All";
            this.mitUnChkAllExport.Click += new System.EventHandler(this.mitUnChkAllExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(201, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exporting will overwrite anything that was already exported to that folder!";
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(102, 148);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 31);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExtractRom
            // 
            this.btnExtractRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtractRom.Location = new System.Drawing.Point(3, 148);
            this.btnExtractRom.Name = "btnExtractRom";
            this.btnExtractRom.Size = new System.Drawing.Size(93, 31);
            this.btnExtractRom.TabIndex = 4;
            this.btnExtractRom.Text = "Extract ROM";
            this.btnExtractRom.UseVisualStyleBackColor = true;
            this.btnExtractRom.Click += new System.EventHandler(this.btnExtractRom_Click);
            // 
            // grpEdits
            // 
            this.grpEdits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.SetColumnSpan(this.grpEdits, 2);
            this.grpEdits.Controls.Add(this.splitEditData);
            this.grpEdits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEdits.Enabled = false;
            this.grpEdits.Location = new System.Drawing.Point(411, 109);
            this.grpEdits.Name = "grpEdits";
            this.MainLayout.SetRowSpan(this.grpEdits, 2);
            this.grpEdits.Size = new System.Drawing.Size(300, 408);
            this.grpEdits.TabIndex = 5;
            this.grpEdits.TabStop = false;
            this.grpEdits.Text = "Step #3 - Edit the data!";
            this.grpEdits.EnabledChanged += new System.EventHandler(this.grpEdits_EnabledChanged);
            // 
            // splitEditData
            // 
            this.splitEditData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEditData.Location = new System.Drawing.Point(3, 16);
            this.splitEditData.Name = "splitEditData";
            this.splitEditData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEditData.Panel1
            // 
            this.splitEditData.Panel1.Controls.Add(this.tvEditableData);
            // 
            // splitEditData.Panel2
            // 
            this.splitEditData.Panel2.Controls.Add(this.tbllayEditData);
            this.splitEditData.Size = new System.Drawing.Size(294, 389);
            this.splitEditData.SplitterDistance = 351;
            this.splitEditData.TabIndex = 0;
            // 
            // tvEditableData
            // 
            this.tvEditableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEditableData.Enabled = false;
            this.tvEditableData.Location = new System.Drawing.Point(0, 0);
            this.tvEditableData.Name = "tvEditableData";
            this.tvEditableData.Size = new System.Drawing.Size(294, 351);
            this.tvEditableData.TabIndex = 1;
            this.tvEditableData.Visible = false;
            // 
            // tbllayEditData
            // 
            this.tbllayEditData.ColumnCount = 4;
            this.tbllayEditData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllayEditData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllayEditData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllayEditData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllayEditData.Controls.Add(this.btnEdit, 0, 0);
            this.tbllayEditData.Controls.Add(this.btnEditOutside, 1, 0);
            this.tbllayEditData.Controls.Add(this.btnOpenDir, 2, 0);
            this.tbllayEditData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayEditData.Location = new System.Drawing.Point(0, 0);
            this.tbllayEditData.Name = "tbllayEditData";
            this.tbllayEditData.RowCount = 1;
            this.tbllayEditData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayEditData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayEditData.Size = new System.Drawing.Size(294, 34);
            this.tbllayEditData.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 28);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditOutside
            // 
            this.btnEditOutside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditOutside.Enabled = false;
            this.btnEditOutside.Location = new System.Drawing.Point(76, 3);
            this.btnEditOutside.Name = "btnEditOutside";
            this.btnEditOutside.Size = new System.Drawing.Size(67, 28);
            this.btnEditOutside.TabIndex = 1;
            this.btnEditOutside.Text = "Open";
            this.btnEditOutside.UseVisualStyleBackColor = true;
            this.btnEditOutside.Click += new System.EventHandler(this.btnEditOutside_Click);
            // 
            // btnOpenDir
            // 
            this.tbllayEditData.SetColumnSpan(this.btnOpenDir, 2);
            this.btnOpenDir.Location = new System.Drawing.Point(149, 3);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(139, 28);
            this.btnOpenDir.TabIndex = 2;
            this.btnOpenDir.Text = "Open Directory";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(207, 520);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(116, 13);
            this.lnkGithub.TabIndex = 4;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "Visit Github for updates";
            // 
            // lnkWiki
            // 
            this.lnkWiki.AutoSize = true;
            this.lnkWiki.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkWiki.Location = new System.Drawing.Point(3, 520);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(133, 13);
            this.lnkWiki.TabIndex = 3;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "Visit the wiki for PMD2 info";
            // 
            // grpExport
            // 
            this.grpExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.SetColumnSpan(this.grpExport, 2);
            this.grpExport.Controls.Add(this.tableLayoutPanel4);
            this.grpExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExport.Enabled = false;
            this.grpExport.Location = new System.Drawing.Point(3, 316);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(402, 201);
            this.grpExport.TabIndex = 3;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Step #4 - After you\'ve done your edits";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnImport, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnRebuildRom, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(396, 182);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Location = new System.Drawing.Point(3, 148);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 31);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRebuildRom
            // 
            this.btnRebuildRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRebuildRom.Location = new System.Drawing.Point(102, 148);
            this.btnRebuildRom.Name = "btnRebuildRom";
            this.btnRebuildRom.Size = new System.Drawing.Size(93, 31);
            this.btnRebuildRom.TabIndex = 1;
            this.btnRebuildRom.Text = "Rebuild ROM";
            this.btnRebuildRom.UseVisualStyleBackColor = true;
            this.btnRebuildRom.Click += new System.EventHandler(this.btnRebuildRom_Click);
            // 
            // groupBox5
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox5, 4);
            this.groupBox5.Controls.Add(this.chklstImport);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 139);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "What to import into the game ?";
            // 
            // chklstImport
            // 
            this.chklstImport.CheckOnClick = true;
            this.chklstImport.ContextMenuStrip = this.contmenuCheckImport;
            this.chklstImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstImport.FormattingEnabled = true;
            this.chklstImport.Items.AddRange(new object[] {
            "Item Data",
            "Move Data",
            "Pokemon Stats",
            "Text"});
            this.chklstImport.Location = new System.Drawing.Point(3, 16);
            this.chklstImport.MultiColumn = true;
            this.chklstImport.Name = "chklstImport";
            this.chklstImport.Size = new System.Drawing.Size(384, 120);
            this.chklstImport.Sorted = true;
            this.chklstImport.TabIndex = 0;
            this.chklstImport.UseCompatibleTextRendering = true;
            // 
            // contmenuCheckImport
            // 
            this.contmenuCheckImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitChkAllImport,
            this.mitUnChkAllImport});
            this.contmenuCheckImport.Name = "contextMenuStrip1";
            this.contmenuCheckImport.Size = new System.Drawing.Size(138, 48);
            // 
            // mitChkAllImport
            // 
            this.mitChkAllImport.Name = "mitChkAllImport";
            this.mitChkAllImport.Size = new System.Drawing.Size(137, 22);
            this.mitChkAllImport.Text = "Check &All";
            this.mitChkAllImport.Click += new System.EventHandler(this.mitChkAllImport_Click);
            // 
            // mitUnChkAllImport
            // 
            this.mitUnChkAllImport.Name = "mitUnChkAllImport";
            this.mitUnChkAllImport.Size = new System.Drawing.Size(137, 22);
            this.mitUnChkAllImport.Text = "&Uncheck All";
            this.mitUnChkAllImport.Click += new System.EventHandler(this.mitUnChkAllImport_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(612, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 106);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // fswExportedData
            // 
            this.fswExportedData.EnableRaisingEvents = true;
            this.fswExportedData.IncludeSubdirectories = true;
            this.fswExportedData.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 542);
            this.Controls.Add(this.MainLayout);
            this.MinimumSize = new System.Drawing.Size(730, 580);
            this.Name = "MainWindows";
            this.Text = "PMD Stats Utility";
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.grpPaths.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpImports.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.contmenuCheckExport.ResumeLayout(false);
            this.grpEdits.ResumeLayout(false);
            this.splitEditData.Panel1.ResumeLayout(false);
            this.splitEditData.Panel2.ResumeLayout(false);
            this.splitEditData.ResumeLayout(false);
            this.tbllayEditData.ResumeLayout(false);
            this.grpExport.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contmenuCheckImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswExportedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.GroupBox grpPaths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtInRomPath;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.Button btnInDir;
        private System.Windows.Forms.Button btnOutDir;
        private System.Windows.Forms.GroupBox grpImports;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox chklstExport;
        private System.Windows.Forms.ContextMenuStrip contmenuCheckExport;
        private System.Windows.Forms.ToolStripMenuItem mitChkAllExport;
        private System.Windows.Forms.ToolStripMenuItem mitUnChkAllExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRebuildRom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox chklstImport;
        private System.Windows.Forms.ContextMenuStrip contmenuCheckImport;
        private System.Windows.Forms.ToolStripMenuItem mitChkAllImport;
        private System.Windows.Forms.ToolStripMenuItem mitUnChkAllImport;
        private System.Windows.Forms.GroupBox grpEdits;
        private System.Windows.Forms.TextBox txtOutRomPath;
        private System.Windows.Forms.Button btnOutRomFile;
        private System.IO.FileSystemWatcher fswExportedData;
        private System.Windows.Forms.SplitContainer splitEditData;
        private System.Windows.Forms.TreeView tvEditableData;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExtractRom;
        private System.Windows.Forms.TableLayoutPanel tbllayEditData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditOutside;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.LinkLabel lnkWiki;

    }
}

