using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ppmd_frontends;

namespace ppmd_packfileutil_gui
{
    public partial class packfileutil_form : fileinputoutput_form
    {
        private const String PACK_FILEX    = ".bin";
        private const String PPMD_PFU_NAME = "ppmd_packfileutil.exe";
        private const String URL_TO_GITHUB = "https://github.com/PsyCommando";
        private Color  COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color  COLOR_WRONG   = Color.FromArgb(255, 200, 200);

        public packfileutil_form()
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

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (txtInPath.Text != String.Empty)
                DoExecuteUtility();
            else
                MessageBox.Show(this,"The input path cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableDisableEditableControls(bool enable)
        {
            this.btnExec.Enabled = enable;
            this.btnInBrowse.Enabled = enable;
            this.btnInBrowseDir.Enabled = enable;
            this.btnOutBrowse.Enabled = enable;
            this.btnOutBrowseDir.Enabled = enable;

            this.grpOptions.Enabled = enable;

            this.txtInPath.Enabled = enable;
            this.txtOutPath.Enabled = enable;
        }

        private void DoExecuteUtility()
        {
            SetStatusWorking();
            EnableDisableEditableControls(false);
            try
            {
                utilitylaunchparams execparams = GatherParameters();
                string args = "\"" + execparams.inputpath + "\" \"" + execparams.outputPath + "\"";

                if (execparams.foffset != 0)
                    args = "-a " + execparams.foffset + " " + args;

                FrontendCommon.UtilityLauncher myUtility = new FrontendCommon.UtilityLauncher(this, PPMD_PFU_NAME);

                if (myUtility.StartUtil(args))
                {
                    myUtility.WaitUntilFinished();
                }

                if (myUtility.GetReturnCode() == 0)
                    SetStatusSuccess();
                else
                    SetStatusFailure();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatusFailure();
            }
            EnableDisableEditableControls(true);
            timerResetStatus.Start();
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

        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            numForcedOffset.Hexadecimal = chkHex.Checked;
        }

        private void SetStatusReady()
        {
            lblStatus.Text = "Ready!";
            lblStatus.ForeColor = Color.Black;
        }

        private void SetStatusWorking()
        {
            lblStatus.Text = "Working...";
            lblStatus.ForeColor = Color.DarkGoldenrod;
        }

        private void SetStatusSuccess()
        {
            lblStatus.Text = "Success!!";
            lblStatus.ForeColor = Color.Green;
        }

        private void SetStatusFailure()
        {
            lblStatus.Text = "Failure..";
            lblStatus.ForeColor = Color.Crimson;
        }

        private void timerResetStatus_Tick(object sender, EventArgs e)
        {
            SetStatusReady();
            timerResetStatus.Stop();
        }

        private void lnkHomePage_Click(object sender, EventArgs e)
        {
            Process.Start(URL_TO_GITHUB);
        }
    }
    
    public struct utilitylaunchparams
    {
        public String inputpath;
        public String outputPath;
        public UInt32  foffset;
    }
}
