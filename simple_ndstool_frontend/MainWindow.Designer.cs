namespace simple_ndstool_frontend
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.UpperLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.rtxtInstructions = new System.Windows.Forms.RichTextBox();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.LowerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpBuild = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSrcDir = new System.Windows.Forms.TextBox();
            this.txtDestROM = new System.Windows.Forms.TextBox();
            this.btnBrowseSrcDir = new System.Windows.Forms.Button();
            this.btnBrowseDestROM = new System.Windows.Forms.Button();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrcROM = new System.Windows.Forms.TextBox();
            this.txtDestDir = new System.Windows.Forms.TextBox();
            this.btnBrowseSrcROM = new System.Windows.Forms.Button();
            this.btnBrowseDestDir = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.UpperLayout.SuspendLayout();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.LowerLayout.SuspendLayout();
            this.grpBuild.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpExtract.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperLayout
            // 
            this.UpperLayout.ColumnCount = 4;
            this.UpperLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UpperLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UpperLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UpperLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UpperLayout.Controls.Add(this.btnExtract, 0, 1);
            this.UpperLayout.Controls.Add(this.btnBuild, 1, 1);
            this.UpperLayout.Controls.Add(this.rtxtInstructions, 0, 0);
            this.UpperLayout.Controls.Add(this.btnCancel, 2, 1);
            this.UpperLayout.Controls.Add(this.btnSettings, 3, 1);
            this.UpperLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperLayout.Location = new System.Drawing.Point(0, 0);
            this.UpperLayout.Margin = new System.Windows.Forms.Padding(0);
            this.UpperLayout.MaximumSize = new System.Drawing.Size(434, 150);
            this.UpperLayout.MinimumSize = new System.Drawing.Size(434, 150);
            this.UpperLayout.Name = "UpperLayout";
            this.UpperLayout.RowCount = 2;
            this.UpperLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.UpperLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.UpperLayout.Size = new System.Drawing.Size(434, 150);
            this.UpperLayout.TabIndex = 0;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(3, 123);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(111, 123);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // rtxtInstructions
            // 
            this.rtxtInstructions.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtxtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtInstructions.BulletIndent = 3;
            this.UpperLayout.SetColumnSpan(this.rtxtInstructions, 4);
            this.rtxtInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInstructions.HideSelection = false;
            this.rtxtInstructions.Location = new System.Drawing.Point(3, 3);
            this.rtxtInstructions.Name = "rtxtInstructions";
            this.rtxtInstructions.ReadOnly = true;
            this.rtxtInstructions.Size = new System.Drawing.Size(428, 114);
            this.rtxtInstructions.TabIndex = 12;
            this.rtxtInstructions.Text = resources.GetString("rtxtInstructions.Text");
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(1);
            this.MainSplit.MaximumSize = new System.Drawing.Size(434, 310);
            this.MainSplit.MinimumSize = new System.Drawing.Size(434, 310);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.UpperLayout);
            this.MainSplit.Panel1MinSize = 130;
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.LowerLayout);
            this.MainSplit.Panel2MinSize = 160;
            this.MainSplit.Size = new System.Drawing.Size(434, 310);
            this.MainSplit.SplitterDistance = 146;
            this.MainSplit.TabIndex = 1;
            // 
            // LowerLayout
            // 
            this.LowerLayout.ColumnCount = 4;
            this.LowerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LowerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LowerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LowerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LowerLayout.Controls.Add(this.grpBuild, 0, 2);
            this.LowerLayout.Controls.Add(this.grpExtract, 0, 0);
            this.LowerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerLayout.Location = new System.Drawing.Point(0, 0);
            this.LowerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.LowerLayout.Name = "LowerLayout";
            this.LowerLayout.RowCount = 4;
            this.LowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.LowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.LowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.LowerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.LowerLayout.Size = new System.Drawing.Size(434, 160);
            this.LowerLayout.TabIndex = 0;
            // 
            // grpBuild
            // 
            this.LowerLayout.SetColumnSpan(this.grpBuild, 4);
            this.grpBuild.Controls.Add(this.tableLayoutPanel2);
            this.grpBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBuild.Location = new System.Drawing.Point(1, 81);
            this.grpBuild.Margin = new System.Windows.Forms.Padding(1);
            this.grpBuild.MaximumSize = new System.Drawing.Size(432, 80);
            this.grpBuild.MinimumSize = new System.Drawing.Size(432, 80);
            this.grpBuild.Name = "grpBuild";
            this.LowerLayout.SetRowSpan(this.grpBuild, 2);
            this.grpBuild.Size = new System.Drawing.Size(432, 80);
            this.grpBuild.TabIndex = 1;
            this.grpBuild.TabStop = false;
            this.grpBuild.Text = "When building..";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSrcDir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDestROM, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseSrcDir, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseDestROM, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(426, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source Dir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destination ROM:";
            // 
            // txtSrcDir
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtSrcDir, 2);
            this.txtSrcDir.Location = new System.Drawing.Point(109, 3);
            this.txtSrcDir.Name = "txtSrcDir";
            this.txtSrcDir.Size = new System.Drawing.Size(204, 20);
            this.txtSrcDir.TabIndex = 2;
            this.txtSrcDir.Leave += new System.EventHandler(this.txtSrcDir_Leave);
            // 
            // txtDestROM
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDestROM, 2);
            this.txtDestROM.Location = new System.Drawing.Point(109, 33);
            this.txtDestROM.Name = "txtDestROM";
            this.txtDestROM.Size = new System.Drawing.Size(204, 20);
            this.txtDestROM.TabIndex = 3;
            this.txtDestROM.Leave += new System.EventHandler(this.txtDestROM_Leave);
            // 
            // btnBrowseSrcDir
            // 
            this.btnBrowseSrcDir.Location = new System.Drawing.Point(321, 3);
            this.btnBrowseSrcDir.Name = "btnBrowseSrcDir";
            this.btnBrowseSrcDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSrcDir.TabIndex = 4;
            this.btnBrowseSrcDir.Text = "Browse..";
            this.btnBrowseSrcDir.UseVisualStyleBackColor = true;
            this.btnBrowseSrcDir.Click += new System.EventHandler(this.btnBrowseSrcDir_Click);
            // 
            // btnBrowseDestROM
            // 
            this.btnBrowseDestROM.Location = new System.Drawing.Point(321, 33);
            this.btnBrowseDestROM.Name = "btnBrowseDestROM";
            this.btnBrowseDestROM.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDestROM.TabIndex = 5;
            this.btnBrowseDestROM.Text = "Browse..";
            this.btnBrowseDestROM.UseVisualStyleBackColor = true;
            this.btnBrowseDestROM.Click += new System.EventHandler(this.btnBrowseDestROM_Click);
            // 
            // grpExtract
            // 
            this.LowerLayout.SetColumnSpan(this.grpExtract, 4);
            this.grpExtract.Controls.Add(this.tableLayoutPanel1);
            this.grpExtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExtract.Location = new System.Drawing.Point(1, 1);
            this.grpExtract.Margin = new System.Windows.Forms.Padding(1);
            this.grpExtract.MaximumSize = new System.Drawing.Size(432, 80);
            this.grpExtract.MinimumSize = new System.Drawing.Size(432, 80);
            this.grpExtract.Name = "grpExtract";
            this.LowerLayout.SetRowSpan(this.grpExtract, 2);
            this.grpExtract.Size = new System.Drawing.Size(432, 80);
            this.grpExtract.TabIndex = 0;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "When extracting..";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSrcROM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDestDir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseSrcROM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseDestDir, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source ROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Dir:";
            // 
            // txtSrcROM
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtSrcROM, 2);
            this.txtSrcROM.Location = new System.Drawing.Point(109, 3);
            this.txtSrcROM.Name = "txtSrcROM";
            this.txtSrcROM.Size = new System.Drawing.Size(204, 20);
            this.txtSrcROM.TabIndex = 2;
            this.txtSrcROM.Leave += new System.EventHandler(this.txtSrcROM_Leave);
            // 
            // txtDestDir
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDestDir, 2);
            this.txtDestDir.Location = new System.Drawing.Point(109, 33);
            this.txtDestDir.Name = "txtDestDir";
            this.txtDestDir.Size = new System.Drawing.Size(204, 20);
            this.txtDestDir.TabIndex = 3;
            this.txtDestDir.Leave += new System.EventHandler(this.txtDestDir_Leave);
            // 
            // btnBrowseSrcROM
            // 
            this.btnBrowseSrcROM.Location = new System.Drawing.Point(321, 3);
            this.btnBrowseSrcROM.Name = "btnBrowseSrcROM";
            this.btnBrowseSrcROM.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSrcROM.TabIndex = 4;
            this.btnBrowseSrcROM.Text = "Browse..";
            this.btnBrowseSrcROM.UseVisualStyleBackColor = true;
            this.btnBrowseSrcROM.Click += new System.EventHandler(this.btnBrowseSrcROM_Click);
            // 
            // btnBrowseDestDir
            // 
            this.btnBrowseDestDir.Location = new System.Drawing.Point(321, 33);
            this.btnBrowseDestDir.Name = "btnBrowseDestDir";
            this.btnBrowseDestDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDestDir.TabIndex = 5;
            this.btnBrowseDestDir.Text = "Browse..";
            this.btnBrowseDestDir.UseVisualStyleBackColor = true;
            this.btnBrowseDestDir.Click += new System.EventHandler(this.btnBrowseDestDir_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(327, 123);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "nds";
            this.openFileDialog1.Filter = "NDS ROM file|*.nds|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "nds";
            this.saveFileDialog1.FileName = "out";
            this.saveFileDialog1.Filter = "NDS ROM file|*.nds|All files|*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 322);
            this.Controls.Add(this.MainSplit);
            this.MinimumSize = new System.Drawing.Size(450, 360);
            this.Name = "MainWindow";
            this.Text = "Simple NDSTool Frontend";
            this.UpperLayout.ResumeLayout(false);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            this.MainSplit.ResumeLayout(false);
            this.LowerLayout.ResumeLayout(false);
            this.grpBuild.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpExtract.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UpperLayout;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.TableLayoutPanel LowerLayout;
        private System.Windows.Forms.GroupBox grpBuild;
        private System.Windows.Forms.GroupBox grpExtract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSrcDir;
        private System.Windows.Forms.TextBox txtDestROM;
        private System.Windows.Forms.Button btnBrowseSrcDir;
        private System.Windows.Forms.Button btnBrowseDestROM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrcROM;
        private System.Windows.Forms.TextBox txtDestDir;
        private System.Windows.Forms.Button btnBrowseSrcROM;
        private System.Windows.Forms.Button btnBrowseDestDir;
        private System.Windows.Forms.RichTextBox rtxtInstructions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

