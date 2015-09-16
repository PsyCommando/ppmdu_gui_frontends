using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontendCommon;
using System.Diagnostics;
using System.Resources;
using System.Threading;

namespace ppmd_statsutil_gui
{
    public partial class NewMainWindow : Form
    {
        private const string URLToGithub = "https://github.com/PsyCommando/ppmdu_gui_frontends";
        private const string URLToWiki = "http://projectpokemon.org/wiki/Pok%C3%A9mon_Mystery_Dungeon_Explorers";

        public const string StatsUtil_Name = "ppmd_statsutil.exe";
        private const string RomExtractSubdir = "rom_data";
        private const string ExportedSubdir = "exported_data";
        private const string DefaultGameStrName = "game_strings.txt";

        //Possible export/import operations
        private const string IO_ItemData = "Item Data";
        private const string IO_MoveData = "Move Data";
        private const string IO_PkStats = "Pokemon Stats";
        private const string IO_Text = "Text";
        private const int    IO_NbPossibleOps = 4;

        private const string DefaultItemDir = "item_data";
        private const string DefaultMoveDir = "move_data";
        private const string DefaultPkmnDir = "pokemon_data";

        //
        private Color COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color COLOR_WRONG = Color.FromArgb(255, 200, 200);
        private Color COLOR_WARN = Color.FromArgb(200, 225, 200);

        public NewMainWindow()
        {
            InitializeComponent();
            utilities.WriteEmbeddedResourcesToCWD();

            chklstDataSelect.Items.Clear();
            chklstDataSelect.Items.Add(IO_ItemData, false);
            chklstDataSelect.Items.Add(IO_MoveData, false);
            chklstDataSelect.Items.Add(IO_PkStats, false);
            chklstDataSelect.Items.Add(IO_Text, false);

            MainLayout.Select();
            //ValidateAllPaths();

        }

//========================================================================================
// Misc
//========================================================================================
        private string HandleDirectoryBrowser( string initpath )
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

        private bool ValidateParentDirExists( string path )
        {
            try
            {
                if (path.Length == 0)
                    return false;

                //Check if path has valid parent dir, color the box accordingly
                System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(path);
                return parentOutDir.Exists;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidatePath(string path)
        {
            try
            {
                if (path.Length == 0)
                    return false;

                return System.IO.File.Exists(path) || System.IO.Directory.Exists(path);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidateATextbox(ref System.Windows.Forms.TextBox txtbox)
        {
            if (txtbox.Text.Length == 0)
            {
                txtbox.BackColor = COLOR_WRONG;
                return false;
            }

            if (ValidatePath(txtbox.Text))
            {
                txtbox.BackColor = COLOR_CORRECT;
                return true;
            }
            else
            {
                txtbox.BackColor = COLOR_WRONG;
            }

            return false;
        }

        private bool ValidateATextboxNonexistingPath(ref System.Windows.Forms.TextBox txtbox)
        {
            if (txtbox.Text.Length == 0)
            {
                txtbox.BackColor = COLOR_WRONG;
                return false;
            }

            if (ValidatePath(txtbox.Text))
            {
                txtbox.BackColor = COLOR_CORRECT;
                return true;
            }
            else if (ValidateParentDirExists(txtbox.Text))
            {
                txtbox.BackColor = COLOR_WARN;
                return true;
            }
            else
            {
                txtbox.BackColor = COLOR_WRONG;
            }

            return false;
        }

        private bool ValidateAllPaths()
        {
            return ValidateATextbox(ref txtGamePath) && ValidateATextboxNonexistingPath(ref txtExtData);
        }

        private bool CheckForErrors(bool isimportmode)
        {
            if (chklstDataSelect.CheckedItems.Count == 0 && !chkImportExportAll.Checked)
            {
                MessageBox.Show(this, "You need to check what you want to import/export from in the list!", "Need more info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (isimportmode)
            {
                if( !(ValidateATextbox(ref txtGamePath) && ValidateATextbox(ref txtExtData)) )
                {
                    MessageBox.Show(this, "Can't import from a non-existing directory! The path highlighted in red is invalid!", "Invalid Import Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            { 
                if (!ValidateAllPaths())
                {
                    MessageBox.Show(this, "The path highlighted in red is invalid!", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

//========================================================================================
// Buttons
//========================================================================================
        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            txtGamePath.Text = HandleDirectoryBrowser(txtGamePath.Text);
        }

        private void btnBrowseExData_Click(object sender, EventArgs e)
        {
            txtExtData.Text = HandleDirectoryBrowser(txtExtData.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors(false))
                return;

            MainLayout.Enabled = false;
            try
            {
                //Make the export directory if it doesn't exists
                if (!System.IO.Directory.Exists(txtExtData.Text))
                {
                    System.IO.Directory.CreateDirectory(txtExtData.Text);
                }

                bool doitem    = chkImportExportAll.Checked;
                bool domoves   = chkImportExportAll.Checked;
                bool dopkstats = chkImportExportAll.Checked;
                bool dotext    = chkImportExportAll.Checked;

                if (!chkImportExportAll.Checked)
                { 
                    //Gather a list of the operations we need to do
                    for (int i = 0; i < chklstDataSelect.CheckedItems.Count; ++i)
                    //foreach( object item in chklstDataSelect.CheckedItems )
                    {
                        string itemname = chklstDataSelect.GetItemText(chklstDataSelect.CheckedItems[i]);

                        if (itemname.Equals(IO_ItemData))
                        {
                            doitem = true;
                        }
                        else if (itemname.Equals(IO_MoveData))
                        {
                            domoves = true;
                        }
                        else if (itemname.Equals(IO_PkStats))
                        {
                            dopkstats = true;
                        }
                        else if (itemname.Equals(IO_Text))
                        {
                            dotext = true;
                        }
                    }
                }

                DoRunStatsUtil(txtGamePath.Text, txtExtData.Text, true, doitem, domoves, dopkstats, dotext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MainLayout.Enabled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors(true))
                return;

            MainLayout.Enabled = false;
            try
            {
                bool doitem    = chkImportExportAll.Checked;
                bool domoves   = chkImportExportAll.Checked;
                bool dopkstats = chkImportExportAll.Checked;
                bool dotext    = chkImportExportAll.Checked;

                if (!chkImportExportAll.Checked)
                { 
                    //Gather a list of the operations we need to do
                    for (int i = 0; i < chklstDataSelect.CheckedItems.Count; ++i)
                    {
                        string itemname = chklstDataSelect.GetItemText(chklstDataSelect.CheckedItems[i]);

                        if (itemname.Equals(IO_ItemData))
                        {
                            doitem = true;
                        }
                        else if (itemname.Equals(IO_MoveData))
                        {
                            domoves = true;
                        }
                        else if (itemname.Equals(IO_PkStats))
                        {
                            dopkstats = true;
                        }
                        else if (itemname.Equals(IO_Text))
                        {
                            dotext = true;
                        }
                    }
                }

                DoRunStatsUtil(txtGamePath.Text, txtExtData.Text, false, doitem, domoves, dopkstats, dotext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MainLayout.Enabled = true;
            }
        }

//========================================================================================
// TxtBoxes
//========================================================================================
        private void txtGamePath_TextChanged(object sender, EventArgs e)
        {
            ValidateATextbox(ref txtGamePath);
            //if (txtGamePath.Text.Length == 0)
            //    return;

            //if (ValidatePath(txtGamePath.Text))
            //{
            //    txtGamePath.BackColor = COLOR_CORRECT;
            //}
            //else
            //{ 
            //    txtGamePath.BackColor = COLOR_WRONG;
            //}
        }

        private void txtExtData_TextChanged(object sender, EventArgs e)
        {
            ValidateATextboxNonexistingPath(ref txtExtData);
            //if (txtExtData.Text.Length == 0)
            //    return;

            //if (ValidatePath(txtExtData.Text))
            //{
            //    txtExtData.BackColor = COLOR_CORRECT;
            //}
            //else if( ValidateParentDirExists(txtExtData.Text) )
            //    txtExtData.BackColor = COLOR_WARN;
            //else
            //    txtExtData.BackColor = COLOR_WRONG;
        }
    

//
//
//
        private void DoRunStatsUtil(string extractedromdir, string extdata, bool bexport, bool doitem, bool domoves, bool dopkstats, bool dotext)
        {
            UtilityLauncher runstatutil = new UtilityLauncher(this, StatsUtil_Name);

            string argsstats = string.Empty;

            if (bexport)
                argsstats = "-e \""; //+ System.IO.Path.Combine(extractedromdir, "data"); //+ "\" \"" + m_lastExportDirectory + "\" -log";
            else
                argsstats = "-i \"";// + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" -log";


            //Then check for the strings, as we have to do them separately
            if (dotext)
            {
                if (bexport)
                {
                    if (runstatutil.StartUtil("-e \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" \"" + extdata + "\"" + " -str -log"))
                    {
                        runstatutil.WaitUntilFinished();
                    }
                }
                else
                {
                    if (runstatutil.StartUtil("-i \"" + System.IO.Path.Combine(extdata, DefaultGameStrName) + "\" \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\"" + " -str -log"))
                    {
                        runstatutil.WaitUntilFinished();
                    }
                }

                Thread.Sleep(100);

                if (runstatutil.GetReturnCode() != 0)
                    throw new Exception("ppmd_statsutil.exe encountered an error!");
            }


            //Run exportall
            if (doitem && domoves && dopkstats)
            {
                string myargs = argsstats;
                if (bexport)
                    myargs = myargs + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" \"" + extdata + "\" -log";
                else
                    myargs = myargs + extdata + "\" \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" -log";


                if (runstatutil.StartUtil(myargs))
                {
                    runstatutil.WaitUntilFinished();
                }

                if (runstatutil.GetReturnCode() != 0)
                    throw new Exception("ppmd_statsutil.exe encountered an error!");
            }
            else
            {
                if (doitem)
                {
                    string myargs = argsstats;
                    if (bexport)
                        myargs = myargs + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" \"" + System.IO.Path.Combine(extdata, DefaultItemDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(extdata, DefaultItemDir) + "\" \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" -log";

                    if (runstatutil.StartUtil(myargs + " -items"))
                    {
                        runstatutil.WaitUntilFinished();
                    }

                    Thread.Sleep(100);

                    if (runstatutil.GetReturnCode() != 0)
                        throw new Exception("ppmd_statsutil.exe encountered an error!");
                }
                if (domoves)
                {
                    string myargs = argsstats;
                    if (bexport)
                        myargs = myargs + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" \"" + System.IO.Path.Combine(extdata, DefaultMoveDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(extdata, DefaultMoveDir) + "\" \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" -log";


                    if (runstatutil.StartUtil(myargs + " -mv"))
                    {
                        runstatutil.WaitUntilFinished();
                    }

                    Thread.Sleep(100);

                    if (runstatutil.GetReturnCode() != 0)
                        throw new Exception("ppmd_statsutil.exe encountered an error!");
                }
                if (dopkstats)
                {
                    string myargs = argsstats;
                    if (bexport)
                        myargs = myargs + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" \"" + System.IO.Path.Combine(extdata, DefaultPkmnDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(extdata, DefaultPkmnDir) + "\" \"" + extractedromdir/*System.IO.Path.Combine(extractedromdir, "data")*/ + "\" -log";


                    if (runstatutil.StartUtil(myargs + " -pk"))
                    {
                        runstatutil.WaitUntilFinished();
                    }

                    Thread.Sleep(100);

                    if (runstatutil.GetReturnCode() != 0)
                        throw new Exception("ppmd_statsutil.exe encountered an error!");
                }
            }

        }

        private void chkImportExportAll_CheckedChanged(object sender, EventArgs e)
        {
            //bool state = chkImportExportAll.Checked;

            //for (int i = 0; i < chklstDataSelect.Items.Count; ++i)
            //    chklstDataSelect.SetItemChecked(i, state);

            if (chkImportExportAll.Checked)
                chklstDataSelect.Enabled = false;
            else
                chklstDataSelect.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URLToGithub);
        }
    }
}
