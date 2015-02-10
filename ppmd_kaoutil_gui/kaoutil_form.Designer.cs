namespace ppmd_kaoutil_gui
{
    partial class kaoutil_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaoutil_form));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpOutImgType = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.optRaw = new System.Windows.Forms.RadioButton();
            this.optBMP = new System.Windows.Forms.RadioButton();
            this.optPNG = new System.Windows.Forms.RadioButton();
            this.numNbSlots = new System.Windows.Forms.NumericUpDown();
            this.chkNbSlots = new System.Windows.Forms.CheckBox();
            this.ttipKaomado = new System.Windows.Forms.ToolTip(this.components);
            this.btnExec = new System.Windows.Forms.Button();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnkStatHomePage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerResetStatus = new System.Windows.Forms.Timer(this.components);
            this.grpOptions.SuspendLayout();
            this.grpOutImgType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSlots)).BeginInit();
            this.statBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.grpOutImgType);
            this.grpOptions.Controls.Add(this.numNbSlots);
            this.grpOptions.Controls.Add(this.chkNbSlots);
            this.grpOptions.Location = new System.Drawing.Point(11, 64);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(214, 145);
            this.grpOptions.TabIndex = 20;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpOutImgType
            // 
            this.grpOutImgType.Controls.Add(this.label3);
            this.grpOutImgType.Controls.Add(this.optRaw);
            this.grpOutImgType.Controls.Add(this.optBMP);
            this.grpOutImgType.Controls.Add(this.optPNG);
            this.grpOutImgType.Location = new System.Drawing.Point(6, 43);
            this.grpOutImgType.Name = "grpOutImgType";
            this.grpOutImgType.Size = new System.Drawing.Size(202, 95);
            this.grpOutImgType.TabIndex = 3;
            this.grpOutImgType.TabStop = false;
            this.grpOutImgType.Text = "Output Image Format";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 23);
            this.label3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "All images are exported as: \r\n- 4 bits per pixels \r\n- 16 colors \r\n- 40 x 40";
            // 
            // optRaw
            // 
            this.optRaw.AutoSize = true;
            this.optRaw.Location = new System.Drawing.Point(6, 68);
            this.optRaw.Name = "optRaw";
            this.optRaw.Size = new System.Drawing.Size(47, 17);
            this.optRaw.TabIndex = 2;
            this.optRaw.Text = "Raw";
            this.optRaw.UseVisualStyleBackColor = true;
            // 
            // optBMP
            // 
            this.optBMP.AutoSize = true;
            this.optBMP.Location = new System.Drawing.Point(6, 45);
            this.optBMP.Name = "optBMP";
            this.optBMP.Size = new System.Drawing.Size(48, 17);
            this.optBMP.TabIndex = 1;
            this.optBMP.Text = "BMP";
            this.optBMP.UseVisualStyleBackColor = true;
            // 
            // optPNG
            // 
            this.optPNG.AutoSize = true;
            this.optPNG.Checked = true;
            this.optPNG.Location = new System.Drawing.Point(6, 21);
            this.optPNG.Name = "optPNG";
            this.optPNG.Size = new System.Drawing.Size(48, 17);
            this.optPNG.TabIndex = 0;
            this.optPNG.TabStop = true;
            this.optPNG.Text = "PNG";
            this.optPNG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optPNG.UseVisualStyleBackColor = true;
            // 
            // numNbSlots
            // 
            this.numNbSlots.Enabled = false;
            this.numNbSlots.Location = new System.Drawing.Point(149, 17);
            this.numNbSlots.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numNbSlots.Name = "numNbSlots";
            this.numNbSlots.Size = new System.Drawing.Size(55, 20);
            this.numNbSlots.TabIndex = 1;
            this.ttipKaomado.SetToolTip(this.numNbSlots, resources.GetString("numNbSlots.ToolTip"));
            this.numNbSlots.Value = new decimal(new int[] {
            1155,
            0,
            0,
            0});
            // 
            // chkNbSlots
            // 
            this.chkNbSlots.AutoSize = true;
            this.chkNbSlots.Location = new System.Drawing.Point(7, 20);
            this.chkNbSlots.Name = "chkNbSlots";
            this.chkNbSlots.Size = new System.Drawing.Size(127, 17);
            this.chkNbSlots.TabIndex = 0;
            this.chkNbSlots.Text = "Override Nb of Slots :";
            this.ttipKaomado.SetToolTip(this.chkNbSlots, "If checked, the kaomado.kao file that will be outputed will have a table of conte" +
        "nt with that total amount of pokemon slots. \r\nIf unsure, leave this unchecked !!" +
        "!");
            this.chkNbSlots.UseVisualStyleBackColor = true;
            this.chkNbSlots.CheckedChanged += new System.EventHandler(this.chkNbEntries_CheckedChanged);
            // 
            // ttipKaomado
            // 
            this.ttipKaomado.AutoPopDelay = 25000;
            this.ttipKaomado.InitialDelay = 500;
            this.ttipKaomado.ReshowDelay = 100;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(565, 186);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(95, 23);
            this.btnExec.TabIndex = 21;
            this.btnExec.Text = "Build/Unpack";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // statBar
            // 
            this.statBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.lnkStatHomePage});
            this.statBar.Location = new System.Drawing.Point(0, 220);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(664, 22);
            this.statBar.SizingGrip = false;
            this.statBar.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Ready!";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(455, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // lnkStatHomePage
            // 
            this.lnkStatHomePage.IsLink = true;
            this.lnkStatHomePage.Name = "lnkStatHomePage";
            this.lnkStatHomePage.Size = new System.Drawing.Size(152, 17);
            this.lnkStatHomePage.Text = "PPMD Utilities GitHub Page";
            // 
            // timerResetStatus
            // 
            this.timerResetStatus.Interval = 2500;
            this.timerResetStatus.Tick += new System.EventHandler(this.timerResetStatus_Tick);
            // 
            // kaoutil_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 242);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.grpOptions);
            this.MaximumSize = new System.Drawing.Size(680, 280);
            this.MinimumSize = new System.Drawing.Size(680, 280);
            this.Name = "kaoutil_form";
            this.Text = "ppmd_kaoutil";
            this.Controls.SetChildIndex(this.grpOptions, 0);
            this.Controls.SetChildIndex(this.btnExec, 0);
            this.Controls.SetChildIndex(this.statBar, 0);
            this.Controls.SetChildIndex(this.txtInPath, 0);
            this.Controls.SetChildIndex(this.txtOutPath, 0);
            this.Controls.SetChildIndex(this.btnOutBrowse, 0);
            this.Controls.SetChildIndex(this.btnInBrowse, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnInBrowseDir, 0);
            this.Controls.SetChildIndex(this.btnOutBrowseDir, 0);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpOutImgType.ResumeLayout(false);
            this.grpOutImgType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSlots)).EndInit();
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.NumericUpDown numNbSlots;
        private System.Windows.Forms.CheckBox chkNbSlots;
        private System.Windows.Forms.GroupBox grpOutImgType;
        private System.Windows.Forms.RadioButton optRaw;
        private System.Windows.Forms.RadioButton optBMP;
        private System.Windows.Forms.RadioButton optPNG;
        private System.Windows.Forms.ToolTip ttipKaomado;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timerResetStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lnkStatHomePage;
    }
}

