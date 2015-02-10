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
        //private enum animstate
        //{
        //    READY,
        //    WORKING,
        //    SUCCESS,
        //    FAILURE,
        //}

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

        //private animstate m_curanim;
        //private int       m_curanimfrm;
        //private System.IO.StreamReader m_utilOut;

        public const string KAOMADO_FILEX = ".kao";
        public const string KAOMADO_EXE = "ppmd_kaoutil.exe";
        private const string URL_TO_GITHUB = "https://github.com/PsyCommando";

        public kaoutil_form()
        {
            InitializeComponent();
            //m_curanim = animstate.READY;
            //m_curanimfrm = 0;
            SetStatusReady();
            //m_utilOut = null;
        }

        public override string GetOutputFileExtension()
        {
            return KAOMADO_FILEX;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (txtInPath.Text != String.Empty)
            {
                DoExecuteUtility();
            }
            else
                MessageBox.Show(this,"The input path cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableDisableEditableControls( bool enable )
        {
            this.btnExec.Enabled = enable;
            this.btnInBrowse.Enabled = enable;
            this.btnInBrowseDir.Enabled = enable;
            this.btnOutBrowse.Enabled = enable;
            this.btnOutBrowseDir.Enabled = enable;

            this.grpOptions.Enabled = enable;
            this.grpOutImgType.Enabled = enable;

            this.txtInPath.Enabled = enable;
            this.txtOutPath.Enabled = enable;
        }



        private void DoExecuteUtility()
        {
            SetStatusWorking();
            EnableDisableEditableControls(false);
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

                //
                FrontendCommon.UtilityLauncher myUtility = new FrontendCommon.UtilityLauncher(this, KAOMADO_EXE);

                if( myUtility.StartUtil(args) )
                {
                    //m_utilOut = myUtility.GetOutputStream();
                    myUtility.WaitUntilFinished();
                    //m_utilOut = null;
                }

                if( myUtility.GetReturnCode() == 0 )
                    SetStatusSuccess();
                else
                    SetStatusFailure();

                //if (FrontendCommon.UtilityLauncher.ExecuteUtility(this, KAOMADO_EXE, args))
                //    SetStatusSuccess();
                //else
                //    SetStatusFailure();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tmrUpdateWorkStatus.Stop();
                //m_utilOut = null;
                SetStatusFailure();
            }
            EnableDisableEditableControls(true);
            timerResetStatus.Start();
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
            numNbSlots.Enabled = chkNbSlots.Checked;
        }

        private void SetStatusReady()
        {
            lblStatus.Text = "Ready!";
            lblStatus.ForeColor = Color.Black;
            //m_curanim = animstate.READY;
            //lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.idle0;
        }

        private void SetStatusWorking()
        {
            lblStatus.Text = "Working...";
            lblStatus.ForeColor = Color.DarkGoldenrod;
            //m_curanim = animstate.WORKING;
            //lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.working0;
        }

        private void SetStatusSuccess()
        {
            lblStatus.Text = "Success!!";
            lblStatus.ForeColor = Color.Green;
            //m_curanim = animstate.SUCCESS;
            //lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.idle0;
        }

        private void SetStatusFailure()
        {
            lblStatus.Text = "Failure..";
            lblStatus.ForeColor = Color.Crimson;
            //m_curanim = animstate.FAILURE;
            //lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.fail0;
        }

        //private void timerAnimPooch_Tick(object sender, EventArgs e)
        //{
        //    //Set current frame
        //    const int nbfrms = 8;
        //    if (m_curanimfrm < nbfrms)
        //        ++m_curanimfrm;
        //    else
        //        m_curanimfrm = 0;

        //    //Display frame
        //    if( m_curanim == animstate.READY )
        //        DoAnimReady(m_curanimfrm);
        //    else if (m_curanim == animstate.WORKING)
        //        DoAnimWorking(m_curanimfrm);
        //    else if (m_curanim == animstate.SUCCESS)
        //        DoAnimSuccess(m_curanimfrm);
        //    else if (m_curanim == animstate.FAILURE)
        //        DoAnimFail(m_curanimfrm);
        //}

        //private void DoAnimReady( int frame )
        //{
        //    if(frame % 2 == 0)
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.idle0;
        //    else
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.idle1;
        //}

        //private void DoAnimWorking(int frame)
        //{
        //    if (frame % 2 == 0)
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.working0;
        //    else
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.working1;
        //}

        //private void DoAnimSuccess(int frame)
        //{
        //    lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.idle0;
        //}

        //private void DoAnimFail(int frame)
        //{
        //    if (frame % 2 == 0)
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.fail0;
        //    else
        //        lblStatus.Image = global::ppmd_kaoutil_gui.Properties.Resources.fail1;
        //}

        private void timerResetStatus_Tick(object sender, EventArgs e)
        {
            SetStatusReady();
            //lblConOut.Text = "";
            timerResetStatus.Stop();
        }

        private void lnkHomePage_Click(object sender, EventArgs e)
        {
            Process.Start(URL_TO_GITHUB);
        }

        //private void tmrUpdateWorkStatus_Tick(object sender, EventArgs e)
        //{
        //    if (m_utilOut != null && !m_utilOut.EndOfStream )
        //    {
        //        lblConOut.Text =  m_utilOut.ReadLine();
        //    }
        //}
    }
}
