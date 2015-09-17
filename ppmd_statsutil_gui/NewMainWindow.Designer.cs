namespace ppmd_statsutil_gui
{
    partial class NewMainWindow
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
            this.grpImportExport = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chklstDataSelect = new System.Windows.Forms.CheckedListBox();
            this.chkImportExportAll = new System.Windows.Forms.CheckBox();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpPaths = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseExData = new System.Windows.Forms.Button();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.txtExtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.grpExec = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttipInPath = new System.Windows.Forms.ToolTip(this.components);
            this.ttipOutPath = new System.Windows.Forms.ToolTip(this.components);
            this.ttipGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpImportExport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.grpPaths.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpExec.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpImportExport
            // 
            this.grpImportExport.Controls.Add(this.tableLayoutPanel2);
            this.grpImportExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImportExport.Location = new System.Drawing.Point(3, 3);
            this.grpImportExport.Name = "grpImportExport";
            this.grpImportExport.Size = new System.Drawing.Size(288, 121);
            this.grpImportExport.TabIndex = 0;
            this.grpImportExport.TabStop = false;
            this.grpImportExport.Text = "Step #1 - What to Import/Export ?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chklstDataSelect, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkImportExportAll, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 102);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // chklstDataSelect
            // 
            this.chklstDataSelect.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chklstDataSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklstDataSelect.CheckOnClick = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chklstDataSelect, 2);
            this.chklstDataSelect.ColumnWidth = 200;
            this.chklstDataSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstDataSelect.FormattingEnabled = true;
            this.chklstDataSelect.Items.AddRange(new object[] {
            "Item Data",
            "Move Data",
            "Pokemon Stats",
            "Text"});
            this.chklstDataSelect.Location = new System.Drawing.Point(3, 3);
            this.chklstDataSelect.Name = "chklstDataSelect";
            this.chklstDataSelect.Size = new System.Drawing.Size(276, 71);
            this.chklstDataSelect.TabIndex = 0;
            this.ttipGeneral.SetToolTip(this.chklstDataSelect, "Pick what should be imported/exported to/from the game!\r\n");
            // 
            // chkImportExportAll
            // 
            this.chkImportExportAll.AutoSize = true;
            this.chkImportExportAll.Location = new System.Drawing.Point(3, 80);
            this.chkImportExportAll.Name = "chkImportExportAll";
            this.chkImportExportAll.Size = new System.Drawing.Size(78, 17);
            this.chkImportExportAll.TabIndex = 1;
            this.chkImportExportAll.Text = "All of those";
            this.ttipGeneral.SetToolTip(this.chkImportExportAll, "If checked, all of the possible choices will be imported/exported from the game!");
            this.chkImportExportAll.UseVisualStyleBackColor = true;
            this.chkImportExportAll.CheckedChanged += new System.EventHandler(this.chkImportExportAll_CheckedChanged);
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.21622F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78378F));
            this.MainLayout.Controls.Add(this.grpImportExport, 0, 0);
            this.MainLayout.Controls.Add(this.grpPaths, 0, 1);
            this.MainLayout.Controls.Add(this.grpExec, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.MainLayout.Size = new System.Drawing.Size(444, 322);
            this.MainLayout.TabIndex = 1;
            // 
            // grpPaths
            // 
            this.MainLayout.SetColumnSpan(this.grpPaths, 2);
            this.grpPaths.Controls.Add(this.tableLayoutPanel3);
            this.grpPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaths.Location = new System.Drawing.Point(3, 130);
            this.grpPaths.Name = "grpPaths";
            this.grpPaths.Size = new System.Drawing.Size(438, 79);
            this.grpPaths.TabIndex = 1;
            this.grpPaths.TabStop = false;
            this.grpPaths.Text = "Step #2 - Where to put/get the files ?";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.90749F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.09251F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel3.Controls.Add(this.btnBrowseExData, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtGamePath, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtExtData, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBrowseInput, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(432, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnBrowseExData
            // 
            this.btnBrowseExData.Location = new System.Drawing.Point(351, 33);
            this.btnBrowseExData.Name = "btnBrowseExData";
            this.btnBrowseExData.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExData.TabIndex = 5;
            this.btnBrowseExData.Text = "Browse..";
            this.btnBrowseExData.UseVisualStyleBackColor = true;
            this.btnBrowseExData.Click += new System.EventHandler(this.btnBrowseExData_Click);
            // 
            // txtGamePath
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtGamePath, 2);
            this.txtGamePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGamePath.Location = new System.Drawing.Point(153, 3);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(192, 20);
            this.txtGamePath.TabIndex = 0;
            this.txtGamePath.Text = "./rom_data/data";
            this.ttipInPath.SetToolTip(this.txtGamePath, "This is the path to the extracted ROM\'s data. \r\nThose get modified only when impo" +
        "rting data back into the game.\r\n");
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            this.txtGamePath.Leave += new System.EventHandler(this.txtGamePath_TextChanged);
            // 
            // txtExtData
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtExtData, 2);
            this.txtExtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExtData.Location = new System.Drawing.Point(153, 33);
            this.txtExtData.Name = "txtExtData";
            this.txtExtData.Size = new System.Drawing.Size(192, 20);
            this.txtExtData.TabIndex = 1;
            this.txtExtData.Text = "./exported_data";
            this.ttipOutPath.SetToolTip(this.txtExtData, "This is the path where the editable files will be exported to\r\nby the application" +
        ".\r\n\r\n!!-The files there will be overwritten each time the export button\r\nis pres" +
        "sed-!!");
            this.txtExtData.TextChanged += new System.EventHandler(this.txtExtData_TextChanged);
            this.txtExtData.Leave += new System.EventHandler(this.txtExtData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game data directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export target/Import source directory:";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(351, 3);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 4;
            this.btnBrowseInput.Text = "Browse..";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // grpExec
            // 
            this.MainLayout.SetColumnSpan(this.grpExec, 2);
            this.grpExec.Controls.Add(this.tableLayoutPanel1);
            this.grpExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExec.Location = new System.Drawing.Point(3, 215);
            this.grpExec.Name = "grpExec";
            this.grpExec.Size = new System.Drawing.Size(438, 104);
            this.grpExec.TabIndex = 2;
            this.grpExec.TabStop = false;
            this.grpExec.Text = "Step #3 - What to Do ?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnImport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 58);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.ttipGeneral.SetToolTip(this.btnExport, "Export game data into a human editable format!\r\n\r\n!!-Overwrites any exported data" +
        " in the export folder-!!\r\n");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(147, 58);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.ttipGeneral.SetToolTip(this.btnImport, "Import the editable files back into the game data!\r\n\r\n!!-Modifies the content of " +
        "the Game data directory-!!");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(291, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit project\'s github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "!!-Overwrites any exported data in the export folder-!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "!!-Modifies the content of the Game data directory-!!";
            // 
            // ttipInPath
            // 
            this.ttipInPath.AutoPopDelay = 10000;
            this.ttipInPath.InitialDelay = 100;
            this.ttipInPath.ReshowDelay = 100;
            this.ttipInPath.ShowAlways = true;
            this.ttipInPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipInPath.ToolTipTitle = "Game data path";
            this.ttipInPath.UseAnimation = false;
            this.ttipInPath.UseFading = false;
            // 
            // ttipOutPath
            // 
            this.ttipOutPath.AutoPopDelay = 10000;
            this.ttipOutPath.InitialDelay = 100;
            this.ttipOutPath.ReshowDelay = 100;
            this.ttipOutPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipOutPath.ToolTipTitle = "Export target/Import source";
            this.ttipOutPath.UseAnimation = false;
            this.ttipOutPath.UseFading = false;
            // 
            // ttipGeneral
            // 
            this.ttipGeneral.AutoPopDelay = 10000;
            this.ttipGeneral.InitialDelay = 500;
            this.ttipGeneral.ReshowDelay = 100;
            // 
            // NewMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 322);
            this.Controls.Add(this.MainLayout);
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "NewMainWindow";
            this.Text = "PPMD2 Statistics Utility Frontend v0.2";
            this.grpImportExport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MainLayout.ResumeLayout(false);
            this.grpPaths.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grpExec.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpImportExport;
        private System.Windows.Forms.CheckedListBox chklstDataSelect;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.CheckBox chkImportExportAll;
        private System.Windows.Forms.GroupBox grpPaths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grpExec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowseExData;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.TextBox txtExtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ttipInPath;
        private System.Windows.Forms.ToolTip ttipOutPath;
        private System.Windows.Forms.ToolTip ttipGeneral;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}