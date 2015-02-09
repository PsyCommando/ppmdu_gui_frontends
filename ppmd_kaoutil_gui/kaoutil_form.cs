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

using ppmd_frontends;

namespace ppmd_kaoutil_gui
{
    public partial class kaoutil_form : fileinputoutput_form
    {
        public const string KAOMADO_FILEX = ".kao";
        public const string KAOMADO_EXE = "ppmd_kaoutil.exe";
        private const string URL_TO_GITHUB = "https://github.com/PsyCommando";

        public kaoutil_form()
        {
            InitializeComponent();
        }

        public override string GetOutputFileExtension()
        {
            return KAOMADO_FILEX;
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
            this.Enabled = false;
            try
            {
                utilLaunchParams execparams = GatherParameters();
                string args = "\"" + execparams.inputPath + "\" \"" + execparams.outputPath + "\"";

                if (execparams.nbslots != 0)
                    args = "-n " + execparams.nbslots + " " + args;

                if( execparams.outimgt == utilLaunchParams.outImgTy.BMP )
                    args = "-bmp " + args;
                else if (execparams.outimgt == utilLaunchParams.outImgTy.RAW)
                    args = "-raw " + args;

                FrontendCommon.UtilityLauncher.ExecuteUtility( this, KAOMADO_EXE, args );

            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private utilLaunchParams GatherParameters()
        {
            utilLaunchParams myParams = new utilLaunchParams();
            System.IO.FileInfo myInFileInfo = new System.IO.FileInfo(txtInPath.Text);
            System.IO.DirectoryInfo myInDirInfo = new System.IO.DirectoryInfo(txtInPath.Text);

            //Validate input path
            if (myInFileInfo.Exists || myInDirInfo.Exists)
                myParams.inputPath = txtInPath.Text;
            else
                throw new Exception("Input path doesn't exist!");

            //Validate output path
            System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(txtOutPath.Text);

            if (!parentOutDir.Exists)
                throw new Exception("Output path parent directory doesn't exist!");
            else
                myParams.outputPath = txtOutPath.Text;

            //Get nb of slots if necessary
            if (chkNbSlots.Checked)
                myParams.nbslots = Decimal.ToUInt32(numNbSlots.Value);
            else
                myParams.nbslots = 0;

            //Get output image type
            if (optRaw.Checked)
                myParams.outimgt = utilLaunchParams.outImgTy.RAW;
            else if( optBMP.Checked )
                myParams.outimgt = utilLaunchParams.outImgTy.BMP;
            else
                myParams.outimgt = utilLaunchParams.outImgTy.PNG;

            return myParams;
        }

        private void chkNbEntries_CheckedChanged(object sender, EventArgs e)
        {
            numNbSlots.Enabled    = chkNbSlots.Checked;
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URL_TO_GITHUB);
        }

        private struct utilLaunchParams
        {
            public enum outImgTy
            {
                PNG,
                BMP,
                RAW,
            }
            public UInt32 nbslots;
            public outImgTy outimgt;
            public string inputPath;
            public string outputPath;
        }
    }
}
