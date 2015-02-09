using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppmd_frontends
{
    public partial class fileinputoutput_form : Form, OutPathAutoCompleter
    {
        private Color COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color COLOR_WRONG = Color.FromArgb(255, 200, 200);

        public fileinputoutput_form()
        {
            InitializeComponent();
        }

        //A couple of rules to be implemented to determine what to do when auto-completing the output path
        public virtual string GetOutputFileExtension()
        {
            return "";
        }
        public virtual bool OutputShouldBeFile(String inputPath)
        {
            System.IO.FileInfo myFileinfo = new System.IO.FileInfo(inputPath);
            System.IO.DirectoryInfo myDirInfo = new System.IO.DirectoryInfo(inputPath);

            return !myFileinfo.Exists && myDirInfo.Exists;
        }

        public virtual bool OutputShouldBeDirectory(String inputPath)
        {
            System.IO.FileInfo myinfo = new System.IO.FileInfo(inputPath);

            return !OutputShouldBeFile(inputPath) && myinfo.Exists;
        }

        public void txtInPath_TextChanged(object sender, EventArgs e)
        {
            if (txtInPath.Text.Length == 0)
                return;

            try
            {
                //Check if path valid change bg color accordingly
                System.IO.DirectoryInfo mydir  = new System.IO.DirectoryInfo(txtInPath.Text);
                System.IO.FileInfo      myfile = new System.IO.FileInfo(txtInPath.Text);

                if (myfile.Exists || mydir.Exists)
                    txtInPath.BackColor = COLOR_CORRECT;
                else
                    txtInPath.BackColor = COLOR_WRONG;
            }
            catch(Exception)
            {
                txtInPath.BackColor = COLOR_WRONG;
            }
        }

        public void txtOutPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Check if path is valid, color the box accordingly
                System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(txtOutPath.Text);

                if( parentOutDir.Exists )
                    txtInPath.BackColor = COLOR_CORRECT;
                else
                    txtInPath.BackColor = COLOR_WRONG;
            }
            catch(Exception)
            {
                txtInPath.BackColor = COLOR_WRONG;
            }
        }

        public void btnInBrowseDir_Click(object sender, EventArgs e)
        {
            try 
            { 
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtInPath.Text);
                if (txtInPath.Text != String.Empty && dirinfo.Exists )
                {
                    folderBrowserDialog1.SelectedPath = txtInPath.Text;
                }
            }
            catch(Exception)
            {}

            try
            { 
                DialogResult result = folderBrowserDialog1.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                    txtInPath.Text = folderBrowserDialog1.SelectedPath;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtInPath.Focus();
            btnInBrowseDir.Focus();
        }

        public void btnOutBrowseDir_Click(object sender, EventArgs e)
        {
            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtOutPath.Text);
                if (txtOutPath.Text != String.Empty && dirinfo.Exists)
                {
                    folderBrowserDialog1.SelectedPath = txtOutPath.Text;
                }
            }
            catch (Exception)
            { }

            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                    txtOutPath.Text = folderBrowserDialog1.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtOutPath.Focus();
            btnOutBrowseDir.Focus();
        }

        public void btnInBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ValidateNames = false;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = true;

            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtInPath.Text);
                if (txtInPath.Text != String.Empty && dirinfo.Exists)
                {
                    openFileDialog1.InitialDirectory = txtInPath.Text;
                }
            }
            catch (Exception)
            { }

            DialogResult result = openFileDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtInPath.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Reset();
            txtInPath.Focus();
            btnInBrowse.Focus();
        }

        public void btnOutBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ValidateNames = false;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;

            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtOutPath.Text);
                if (txtOutPath.Text != String.Empty && dirinfo.Exists)
                {
                    saveFileDialog1.InitialDirectory = txtOutPath.Text;
                }
            }
            catch (Exception)
            { }

            DialogResult result = saveFileDialog1.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtOutPath.Text = saveFileDialog1.FileName;
            }
            saveFileDialog1.Reset();
            txtOutPath.Focus();
            btnOutBrowse.Focus();
        }

        public void txtInPath_Leave(object sender, EventArgs e)
        {
            //If not empty skip
            if (txtOutPath.Text != String.Empty)
                return;

            try
            {
                String outfilex = GetOutputFileExtension();
                if (OutputShouldBeFile(txtInPath.Text))
                {
                    //Output is file!
                    String inDirName = txtInPath.Text;
                    String outFileName = String.Empty;

                    if (inDirName.EndsWith("\\") || inDirName.EndsWith("/"))
                        outFileName = inDirName.Remove((inDirName.Length - 1)) + outfilex;
                    else
                        outFileName = inDirName + outfilex;

                    txtOutPath.Text = outFileName;
                }
                else if(OutputShouldBeDirectory(txtInPath.Text))
                {
                    //Output is directory!
                    String inFileName = System.IO.Path.GetFileNameWithoutExtension(txtInPath.Text);
                    String inPath     = System.IO.Directory.GetParent(txtInPath.Text).FullName;
                    txtOutPath.Text = inPath + "\\" + inFileName;
                }
                else
                    throw new Exception();

                txtOutPath.BackColor = Color.White;
            }
            catch (Exception)
            {
                //txtOutPath.BackColor = Color.White;
            }
        }
    }

    public interface OutPathAutoCompleter
    {
        //A couple of rules to be implemented to determine what to do when auto-completing the output path
        string GetOutputFileExtension();
        bool OutputShouldBeFile(String inputPath);
        bool OutputShouldBeDirectory(String inputPath);
    }
}
