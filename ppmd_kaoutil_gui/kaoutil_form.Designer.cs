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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.optRaw = new System.Windows.Forms.RadioButton();
            this.optBMP = new System.Windows.Forms.RadioButton();
            this.optPNG = new System.Windows.Forms.RadioButton();
            this.numNbSlots = new System.Windows.Forms.NumericUpDown();
            this.chkNbSlots = new System.Windows.Forms.CheckBox();
            this.ttipKaomado = new System.Windows.Forms.ToolTip(this.components);
            this.btnExec = new System.Windows.Forms.Button();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.numNbSlots);
            this.groupBox1.Controls.Add(this.chkNbSlots);
            this.groupBox1.Location = new System.Drawing.Point(11, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.optRaw);
            this.groupBox2.Controls.Add(this.optBMP);
            this.groupBox2.Controls.Add(this.optPNG);
            this.groupBox2.Location = new System.Drawing.Point(6, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Image Format";
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
            this.btnExec.Location = new System.Drawing.Point(565, 159);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(95, 23);
            this.btnExec.TabIndex = 21;
            this.btnExec.Text = "Build/Unpack";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(522, 190);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(138, 13);
            this.lnkGithub.TabIndex = 22;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "PPMD Utilities GitHub Page";
            // 
            // kaoutil_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 212);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(680, 250);
            this.MinimumSize = new System.Drawing.Size(680, 250);
            this.Name = "kaoutil_form";
            this.Text = "ppmd_kaoutil";
            this.Controls.SetChildIndex(this.txtInPath, 0);
            this.Controls.SetChildIndex(this.txtOutPath, 0);
            this.Controls.SetChildIndex(this.btnOutBrowse, 0);
            this.Controls.SetChildIndex(this.btnInBrowse, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnInBrowseDir, 0);
            this.Controls.SetChildIndex(this.btnOutBrowseDir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnExec, 0);
            this.Controls.SetChildIndex(this.lnkGithub, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numNbSlots;
        private System.Windows.Forms.CheckBox chkNbSlots;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optRaw;
        private System.Windows.Forms.RadioButton optBMP;
        private System.Windows.Forms.RadioButton optPNG;
        private System.Windows.Forms.ToolTip ttipKaomado;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkGithub;
    }
}

