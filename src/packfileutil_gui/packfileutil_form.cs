using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ppmd_packfileutilgui
{
    public struct utilitylaunchparams
    {
        public String inputpath;
        public String outputPath;
        public UInt32  foffset;
    }

    public partial class PackFileUtilForm : ppmd_frontends.fileinputoutput_form
    {
        private const String PACK_FILEX    = ".bin";
        private const String PPMD_PFU_NAME = "ppmd_packfileutil.exe";
        private const String URL_TO_GITHUB = "https://github.com/PsyCommando";
        private Color  COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color  COLOR_WRONG   = Color.FromArgb(255, 200, 200);

        public PackFileUtilForm()
        {
            InitializeComponent();
        }

        private void chkPokeSprite_CheckedChanged(object sender, EventArgs e)
        {
            numForcedOffset.Enabled = chkPokeSprite.Checked;
            chkHex.Enabled          = chkPokeSprite.Checked;
            lblForcedOffset.Enabled = chkPokeSprite.Checked;
        }

        //A couple of rules to be implemented to determine what to do when auto-completing the output path
        public override string GetOutputFileExtension()
        {
            return PACK_FILEX;
        }

        //private void txtInPath_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtInPath.Text.Length == 0)
        //        return;

        //    try
        //    {
        //        //Check if path valid change bg color accordingly
        //        System.IO.DirectoryInfo mydir  = new System.IO.DirectoryInfo(txtInPath.Text);
        //        System.IO.FileInfo      myfile = new System.IO.FileInfo(txtInPath.Text);

        //        if (myfile.Exists || mydir.Exists)
        //            txtInPath.BackColor = COLOR_CORRECT;
        //        else
        //            txtInPath.BackColor = COLOR_WRONG;
        //    }
        //    catch(Exception)
        //    {
        //        txtInPath.BackColor = COLOR_WRONG;
        //    }
        //}



        //private void txtOutPath_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Check if path is valid, color the box accordingly
        //        System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(txtOutPath.Text);

        //        if( parentOutDir.Exists )
        //            txtInPath.BackColor = COLOR_CORRECT;
        //        else
        //            txtInPath.BackColor = COLOR_WRONG;
        //    }
        //    catch(Exception)
        //    {
        //        txtInPath.BackColor = COLOR_WRONG;
        //    }
        //}

        private void txtForcedOffset_TextChanged(object sender, EventArgs e)
        {
            //Check if offset valid, change bg color appropriately
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (txtInPath.Text != String.Empty)
                DoExecuteUtility();
            else
                MessageBox.Show(this,"The input path cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DoExecuteUtility()
        {
            try
            {
                utilitylaunchparams execparams = GatherParameters();
                string args = "\"" + execparams.inputpath + "\" \"" + execparams.outputPath + "\"";

                if (execparams.foffset != 0)
                    args = "-a " + execparams.foffset + " " + args;

                FrontendCommon.UtilityLauncher.ExecuteUtility(this, PPMD_PFU_NAME, args);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private utilitylaunchparams GatherParameters()
        {
            utilitylaunchparams myParams = new utilitylaunchparams();
            System.IO.FileInfo myInFileInfo = new System.IO.FileInfo (txtInPath.Text);
            System.IO.DirectoryInfo myInDirInfo = new System.IO.DirectoryInfo(txtInPath.Text);

            //Validate input path
            if ( myInFileInfo.Exists || myInDirInfo.Exists)
                myParams.inputpath = txtInPath.Text;
            else
                throw new Exception("Input path doesn't exist!");

            //Validate output path
            System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(txtOutPath.Text);

            if (!parentOutDir.Exists)
                throw new Exception("Output path parent directory doesn't exist!");
            else
                myParams.outputPath = txtOutPath.Text;

            //Get forced offset if necessary
            if (chkPokeSprite.Checked)
                myParams.foffset = Decimal.ToUInt32(numForcedOffset.Value);
            else
                myParams.foffset = 0;

            return myParams;
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URL_TO_GITHUB);
        }

        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            numForcedOffset.Hexadecimal = chkHex.Checked;
        }

        //private void txtInPath_Leave(object sender, EventArgs e)
        //{
        //    //If not empty skip
        //    if(txtOutPath.Text != String.Empty)
        //        return;

        //    try
        //    {
        //        System.IO.FileInfo      inputF     = new System.IO.FileInfo(txtInPath.Text);
        //        System.IO.DirectoryInfo inputFdir  = new System.IO.DirectoryInfo(txtInPath.Text);
        //        String                  inFileName = System.IO.Path.GetFileNameWithoutExtension(txtInPath.Text);
        //        String                  inPath     = System.IO.Directory.GetParent(txtInPath.Text).FullName;

        //        //Find out if file or directory
        //        if (!inputF.Exists && inputFdir.Exists)
        //        {
        //            //Input is Directory
        //            String inDirName   = txtInPath.Text;
        //            String outFileName = String.Empty;// = System.IO.Path.GetDirectoryName(txtInPath.Text) + ".bin";

        //            if (inDirName.EndsWith("\\") || inDirName.EndsWith("/"))
        //                outFileName = inDirName.Remove((inDirName.Length - 1)) + PACK_FILEX;
        //            else
        //                outFileName = inDirName + PACK_FILEX;

        //            txtOutPath.Text = outFileName;
        //        }
        //        else if (inputF.Exists)
        //        {
        //            txtOutPath.Text = inPath + "\\" + inFileName;
        //        }
        //        else
        //        {
        //            throw new Exception();
        //        }

        //        txtOutPath.BackColor = Color.White;
        //    }
        //    catch(Exception)
        //    {
        //        txtOutPath.BackColor = Color.White;
        //    }
        //}

        //private void btnInBrowseDir_Click(object sender, EventArgs e)
        //{
        //    try 
        //    { 
        //        //Set the directory that was in the txt box already if necessary
        //        System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtInPath.Text);
        //        if (txtInPath.Text != String.Empty && dirinfo.Exists )
        //        {
        //            folderBrowserDialog1.SelectedPath = txtInPath.Text;
        //        }
        //    }
        //    catch(Exception)
        //    {}

        //    try
        //    { 
        //        DialogResult result = folderBrowserDialog1.ShowDialog(this);

        //        if (result == System.Windows.Forms.DialogResult.OK)
        //            txtInPath.Text = folderBrowserDialog1.SelectedPath;
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    txtInPath.Focus();
        //    btnInBrowseDir.Focus();
        //}

        //private void btnOutBrowseDir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Set the directory that was in the txt box already if necessary
        //        System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtOutPath.Text);
        //        if (txtOutPath.Text != String.Empty && dirinfo.Exists)
        //        {
        //            folderBrowserDialog1.SelectedPath = txtOutPath.Text;
        //        }
        //    }
        //    catch (Exception)
        //    { }

        //    try
        //    {
        //        DialogResult result = folderBrowserDialog1.ShowDialog(this);

        //        if (result == System.Windows.Forms.DialogResult.OK)
        //            txtOutPath.Text = folderBrowserDialog1.SelectedPath;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    txtOutPath.Focus();
        //    btnOutBrowseDir.Focus();
        //}

        //private void btnInBrowse_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.ValidateNames = false;
        //    openFileDialog1.CheckFileExists = false;
        //    openFileDialog1.CheckPathExists = true;

        //    try
        //    {
        //        //Set the directory that was in the txt box already if necessary
        //        System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtInPath.Text);
        //        if (txtInPath.Text != String.Empty && dirinfo.Exists)
        //        {
        //            openFileDialog1.InitialDirectory = txtInPath.Text;
        //        }
        //    }
        //    catch (Exception)
        //    { }

        //    DialogResult result = openFileDialog1.ShowDialog(this);
        //    if (result == System.Windows.Forms.DialogResult.OK)
        //    {
        //        txtInPath.Text = openFileDialog1.FileName;
        //    }
        //    openFileDialog1.Reset();
        //    txtInPath.Focus();
        //    btnInBrowse.Focus();
        //}

        //private void btnOutBrowse_Click(object sender, EventArgs e)
        //{
        //    saveFileDialog1.ValidateNames = false;
        //    saveFileDialog1.CheckFileExists = false;
        //    saveFileDialog1.CheckPathExists = false;

        //    try
        //    {
        //        //Set the directory that was in the txt box already if necessary
        //        System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(txtOutPath.Text);
        //        if (txtOutPath.Text != String.Empty && dirinfo.Exists)
        //        {
        //            saveFileDialog1.InitialDirectory = txtOutPath.Text;
        //        }
        //    }
        //    catch (Exception)
        //    { }

        //    DialogResult result = saveFileDialog1.ShowDialog(this);
        //    if (result == System.Windows.Forms.DialogResult.OK)
        //    {
        //        txtOutPath.Text = saveFileDialog1.FileName;
        //    }
        //    saveFileDialog1.Reset();
        //    txtOutPath.Focus();
        //    btnOutBrowse.Focus();
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
