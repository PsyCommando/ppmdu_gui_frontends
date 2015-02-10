namespace ppmd_frontends
{
    public partial class fileinputoutput_form
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
            this.btnOutBrowseDir = new System.Windows.Forms.Button();
            this.btnInBrowseDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInBrowse = new System.Windows.Forms.Button();
            this.btnOutBrowse = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.txtInPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnOutBrowseDir
            // 
            this.btnOutBrowseDir.Location = new System.Drawing.Point(565, 38);
            this.btnOutBrowseDir.Name = "btnOutBrowseDir";
            this.btnOutBrowseDir.Size = new System.Drawing.Size(95, 23);
            this.btnOutBrowseDir.TabIndex = 19;
            this.btnOutBrowseDir.Text = "Browse Dir...";
            this.btnOutBrowseDir.UseVisualStyleBackColor = true;
            this.btnOutBrowseDir.Click += new System.EventHandler(this.btnOutBrowseDir_Click);
            // 
            // btnInBrowseDir
            // 
            this.btnInBrowseDir.Location = new System.Drawing.Point(565, 7);
            this.btnInBrowseDir.Name = "btnInBrowseDir";
            this.btnInBrowseDir.Size = new System.Drawing.Size(95, 23);
            this.btnInBrowseDir.TabIndex = 18;
            this.btnInBrowseDir.Text = "Browse Dir...";
            this.btnInBrowseDir.UseVisualStyleBackColor = true;
            this.btnInBrowseDir.Click += new System.EventHandler(this.btnInBrowseDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Input :";
            // 
            // btnInBrowse
            // 
            this.btnInBrowse.Location = new System.Drawing.Point(472, 7);
            this.btnInBrowse.Name = "btnInBrowse";
            this.btnInBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnInBrowse.TabIndex = 15;
            this.btnInBrowse.Text = "Browse File...";
            this.btnInBrowse.UseVisualStyleBackColor = true;
            this.btnInBrowse.Click += new System.EventHandler(this.btnInBrowse_Click);
            // 
            // btnOutBrowse
            // 
            this.btnOutBrowse.Location = new System.Drawing.Point(472, 38);
            this.btnOutBrowse.Name = "btnOutBrowse";
            this.btnOutBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnOutBrowse.TabIndex = 14;
            this.btnOutBrowse.Text = "Browse File...";
            this.btnOutBrowse.UseVisualStyleBackColor = true;
            this.btnOutBrowse.Click += new System.EventHandler(this.btnOutBrowse_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.AllowDrop = true;
            this.txtOutPath.Location = new System.Drawing.Point(56, 38);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(409, 20);
            this.txtOutPath.TabIndex = 13;
            this.txtOutPath.TextChanged += new System.EventHandler(this.txtOutPath_TextChanged);
            // 
            // txtInPath
            // 
            this.txtInPath.AllowDrop = true;
            this.txtInPath.Location = new System.Drawing.Point(56, 11);
            this.txtInPath.Name = "txtInPath";
            this.txtInPath.Size = new System.Drawing.Size(409, 20);
            this.txtInPath.TabIndex = 12;
            this.txtInPath.TextChanged += new System.EventHandler(this.txtInPath_TextChanged);
            this.txtInPath.Leave += new System.EventHandler(this.txtInPath_Leave);
            // 
            // fileinputoutput_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 182);
            this.Controls.Add(this.btnOutBrowseDir);
            this.Controls.Add(this.btnInBrowseDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInBrowse);
            this.Controls.Add(this.btnOutBrowse);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.txtInPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 220);
            this.MinimumSize = new System.Drawing.Size(680, 220);
            this.Name = "fileinputoutput_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "fileinputoutput_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        protected System.Windows.Forms.Button btnOutBrowseDir;
        protected System.Windows.Forms.Button btnInBrowseDir;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnInBrowse;
        protected System.Windows.Forms.Button btnOutBrowse;
        protected System.Windows.Forms.TextBox txtOutPath;
        protected System.Windows.Forms.TextBox txtInPath;
    }
}