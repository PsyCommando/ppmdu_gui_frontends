using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using FrontendCommon;


namespace simple_ndstool_frontend
{
    public partial class MainWindow : Form
    {
        private static Size CompactSize = new Size(450, 200);
        private static Size ExpandedSize = new Size(450, 360);

        private const String Conf_SrcRom = "SourceROM";
        private const String Conf_SrcDir = "SourceDirectory";
        private const String Conf_DestRom = "DestinationROM";
        private const String Conf_DestDir = "DestinationDirectory";

        private const String SettingBtnDef = "Settings";
        private const String SettingBtnSave = "Save";

        public const String NdsToolName = "ndstool.exe";

        public MainWindow()
        {
            InitializeComponent();
            CompactMode();
            ReadConfig();
            reswriter.WriteEmbeddedResourcesToCWD();
        }

        //=============================================================================
        //  Saving/Loading Settings
        //=============================================================================
        private void ReadConfig()
        {
            try
            {
                Configuration      config      = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");

                if (appSettings.Settings.Count != 0)
                {
                    foreach (string key in appSettings.Settings.AllKeys)
                    {
                        if( appSettings.Settings[key].Key == Conf_SrcRom )
                            txtSrcROM.Text = appSettings.Settings[key].Value;

                        if (appSettings.Settings[key].Key == Conf_SrcDir)
                            txtSrcDir.Text = appSettings.Settings[key].Value;

                        if (appSettings.Settings[key].Key == Conf_DestRom)
                            txtDestROM.Text = appSettings.Settings[key].Value;

                        if (appSettings.Settings[key].Key == Conf_DestDir)
                            txtDestDir.Text = appSettings.Settings[key].Value;
                    }
                }
            }
            catch( Exception e )
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateConfigFile()
        {
            try 
            {
                // Get the application configuration file.
                Configuration      config      = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = config.AppSettings;

                appSettings.Settings.Add( Conf_SrcRom,  txtSrcROM.Text  );
                appSettings.Settings.Add( Conf_SrcDir,  txtSrcDir.Text  );
                appSettings.Settings.Add( Conf_DestRom, txtDestROM.Text );
                appSettings.Settings.Add( Conf_DestDir, txtDestDir.Text );

                // Save the configuration file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload in memory of the changed section. 
                // This to to read the section with the 
                // updated values.
                ConfigurationManager.RefreshSection("appSettings");

            }
            catch( Exception e )
            {
                MessageBox.Show(this, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        //
        //
        private void ExpandedMode()
        {
            btnSettings.Text      = SettingBtnSave;


            this.MaximumSize = ExpandedSize;
            this.MinimumSize = ExpandedSize;
            this.Size = ExpandedSize;

            btnCancel.Enabled = true;
            btnCancel.Visible = true;
            MainSplit.Panel2Collapsed = false;
        }

        private void CompactMode()
        {
            btnSettings.Text      = SettingBtnDef;


            this.MaximumSize = CompactSize;
            this.MinimumSize = CompactSize;
            this.Size = CompactSize;

            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            MainSplit.Panel2Collapsed = true;
        }

        private string HandleDirectoryBrowser(string initpath)
        {
            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(initpath);
                if (initpath != String.Empty && dirinfo.Exists)
                {
                    folderBrowserDialog1.SelectedPath = initpath;
                }
            }
            catch (Exception)
            { }

            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                    return folderBrowserDialog1.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }


        private string HandleOpenFileDialog( string initpath )
        {
            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(initpath);
                if (initpath != String.Empty && dirinfo.Exists)
                {
                    openFileDialog1.InitialDirectory = initpath;
                }
            }
            catch (Exception)
            { }

            try
            {
                DialogResult result = openFileDialog1.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                    return openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }

        private string HandleSaveFileDialog(string initpath)
        {
            try
            {
                //Set the directory that was in the txt box already if necessary
                System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(initpath);
                if (initpath != String.Empty && dirinfo.Exists)
                {
                    saveFileDialog1.InitialDirectory = initpath;
                }
            }
            catch (Exception)
            { }

            try
            {
                DialogResult result = saveFileDialog1.ShowDialog(this);

                if (result == System.Windows.Forms.DialogResult.OK)
                    return saveFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }

        private void RunNdsTool(string romname, string dirname, bool bexport)
        {
            string args = " \"" + romname + "\" " +
                          "-9 \"" + dirname + "/arm9.bin\" " +
                          "-7 \"" + dirname + "/arm7.bin\" " +
                          "-y9 \"" + dirname + "/y9.bin\" " +
                          "-y7 \"" + dirname + "/y7.bin\" " +
                          "-d \"" + dirname + "/data\" " +
                          "-y \"" + dirname + "/overlay\" " +
                          "-t \"" + dirname + "/banner.bin\" " +
                          "-h \"" + dirname + "/header.bin\" " +
                          "-v";

            if (bexport)
                args = "-x" + args;
            else
                args = "-c" + args;

            UtilityLauncher runndstool = new UtilityLauncher(this, NdsToolName);

            //First extract the data
            if (runndstool.StartUtil(args))
            {
                runndstool.WaitUntilFinished();
            }

            if (runndstool.GetReturnCode() != 0)
                throw new Exception("ndstool.exe encountered an error.");
        }


        //=============================================================================
        //  Button Events
        //=============================================================================
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if( !MainSplit.Panel2Collapsed )
            {
                UpdateConfigFile();
                CompactMode();
            }
            else
                ExpandedMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Read settings
            ReadConfig();
            CompactMode();
        }

        private void btnBrowseSrcROM_Click(object sender, EventArgs e)
        {
            if ( ! String.IsNullOrEmpty( txtSrcROM.Text ) )
                txtSrcROM.Text = HandleOpenFileDialog(txtSrcROM.Text);
            else
                txtSrcROM.Text = HandleOpenFileDialog( Directory.GetCurrentDirectory() );
        }

        private void btnBrowseDestDir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDestDir.Text))
                txtDestDir.Text = HandleDirectoryBrowser(txtDestDir.Text);
            else
                txtDestDir.Text = HandleDirectoryBrowser(Directory.GetCurrentDirectory());
        }

        private void btnBrowseSrcDir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSrcDir.Text))
                txtSrcDir.Text = HandleDirectoryBrowser(txtSrcDir.Text);
            else
                txtSrcDir.Text = HandleDirectoryBrowser(Directory.GetCurrentDirectory());
        }

        private void btnBrowseDestROM_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDestROM.Text))
                txtDestROM.Text = HandleSaveFileDialog(txtDestROM.Text);
            else
                txtDestROM.Text = HandleSaveFileDialog(Directory.GetCurrentDirectory());
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSrcROM.Text))
                    throw new Exception("Source ROM path is empty!");

                if (!File.Exists(txtSrcROM.Text))
                    throw new Exception("Source ROM specified does not exists!");

                if (String.IsNullOrEmpty(txtDestDir.Text))
                    throw new Exception("Destination directory path is empty!");

                if (!Directory.Exists(txtDestDir.Text))
                    System.IO.Directory.CreateDirectory(txtDestDir.Text);

                RunNdsTool( txtSrcROM.Text, txtDestDir.Text, true );
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSrcDir.Text))
                    throw new Exception("Source directory path is empty!");

                if( !Directory.Exists(txtSrcDir.Text) )
                    throw new Exception("Source directory specified does not exists!");

                if (String.IsNullOrEmpty(txtDestROM.Text))
                    throw new Exception("Destination ROM path is empty!");

                RunNdsTool(txtDestROM.Text, txtSrcDir.Text, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //=============================================================================
        //  TextBox Events
        //=============================================================================
        private void txtSrcROM_Leave(object sender, EventArgs e)
        {
        }

        private void txtDestDir_Leave(object sender, EventArgs e)
        {
        }

        private void txtSrcDir_Leave(object sender, EventArgs e)
        {
        }

        private void txtDestROM_Leave(object sender, EventArgs e)
        {
        }

    }
}
