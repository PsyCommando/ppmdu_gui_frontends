namespace ppmd_packfileutilgui
{
    partial class PackFileUtilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackFileUtilForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.numForcedOffset = new System.Windows.Forms.NumericUpDown();
            this.lblForcedOffset = new System.Windows.Forms.Label();
            this.chkPokeSprite = new System.Windows.Forms.CheckBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numForcedOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.ValidateNames = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHex);
            this.groupBox1.Controls.Add(this.numForcedOffset);
            this.groupBox1.Controls.Add(this.lblForcedOffset);
            this.groupBox1.Controls.Add(this.chkPokeSprite);
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Checked = true;
            this.chkHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHex.Enabled = false;
            this.chkHex.Location = new System.Drawing.Point(167, 43);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(45, 17);
            this.chkHex.TabIndex = 4;
            this.chkHex.Text = "Hex";
            this.ttip.SetToolTip(this.chkHex, "Check to input an hexadecimal value, uncheck to input a decimal value.");
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // numForcedOffset
            // 
            this.numForcedOffset.Enabled = false;
            this.numForcedOffset.Hexadecimal = true;
            this.numForcedOffset.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numForcedOffset.Location = new System.Drawing.Point(109, 41);
            this.numForcedOffset.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numForcedOffset.Name = "numForcedOffset";
            this.numForcedOffset.Size = new System.Drawing.Size(51, 20);
            this.numForcedOffset.TabIndex = 3;
            this.ttip.SetToolTip(this.numForcedOffset, resources.GetString("numForcedOffset.ToolTip"));
            this.numForcedOffset.Value = new decimal(new int[] {
            4864,
            0,
            0,
            0});
            // 
            // lblForcedOffset
            // 
            this.lblForcedOffset.AutoSize = true;
            this.lblForcedOffset.Enabled = false;
            this.lblForcedOffset.Location = new System.Drawing.Point(29, 43);
            this.lblForcedOffset.Name = "lblForcedOffset";
            this.lblForcedOffset.Size = new System.Drawing.Size(74, 13);
            this.lblForcedOffset.TabIndex = 2;
            this.lblForcedOffset.Text = "Forced Offset:";
            // 
            // chkPokeSprite
            // 
            this.chkPokeSprite.AutoSize = true;
            this.chkPokeSprite.Location = new System.Drawing.Point(6, 19);
            this.chkPokeSprite.Name = "chkPokeSprite";
            this.chkPokeSprite.Size = new System.Drawing.Size(154, 17);
            this.chkPokeSprite.TabIndex = 0;
            this.chkPokeSprite.Text = "Pokemon Sprites Container";
            this.ttip.SetToolTip(this.chkPokeSprite, "Check this if the pack file to build contains pokemon sprites! Use the default fo" +
        "rced offset if you didn\'t add any new sprites. Check documentation for more deta" +
        "ils.");
            this.chkPokeSprite.UseVisualStyleBackColor = true;
            this.chkPokeSprite.CheckedChanged += new System.EventHandler(this.chkPokeSprite_CheckedChanged);
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(567, 100);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(95, 23);
            this.btnExec.TabIndex = 7;
            this.btnExec.Text = "Pack/Unpack";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // ttip
            // 
            this.ttip.AutoPopDelay = 25000;
            this.ttip.InitialDelay = 500;
            this.ttip.ReshowDelay = 100;
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(600, 163);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(55, 13);
            this.lnkGithub.TabIndex = 8;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "My Github";
            this.ttip.SetToolTip(this.lnkGithub, "For source code, documentation, and more tools, visit my github profile.");
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(567, 129);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Pick a folder";
            // 
            // PackFileUtilForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(664, 182);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.groupBox1);
            this.Name = "PackFileUtilForm";
            this.Text = "ppmd Pack File Utility";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnExec, 0);
            this.Controls.SetChildIndex(this.lnkGithub, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numForcedOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblForcedOffset;
        private System.Windows.Forms.CheckBox chkPokeSprite;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ToolTip ttip;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numForcedOffset;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

