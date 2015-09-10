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
using System.IO;

namespace ppmd_statsutil_gui
{
    public partial class MainWindows : Form
    {
        private Color               COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color               COLOR_WRONG   = Color.FromArgb(255, 200, 200);
        private const string URLToGithub = "https://github.com/PsyCommando";
        private const string URLToWiki = "http://projectpokemon.org/wiki/Pok%C3%A9mon_Mystery_Dungeon_Explorers";
        private  const string ROM_Extension    = "nds";
        private  const string FileFilter       = "NDS ROM|*.nds|All Files|*.*";
        private  const string NDSTOOL_Name     = "ndstool.exe";
        private  const string StatsUtil_Name   = "ppmd_statsutil.exe";
        private  const string RomExtractSubdir = "extracted_rom";
        private const string ExportedSubdir    = "exported_data";
        private const string DefaultGameStrName = "game_strings.txt";

        private const string DefaultItemDir     = "item_data";
        private const string DefaultMoveDir = "move_data";
        private const string DefaultPkmnDir = "pokemon_data";

        //Possible export operations
        private const string Exp_ItemData = "Item Data";
        private const string Exp_MoveData = "Move Data";
        private const string Exp_PkStats  = "Pokemon Stats";
        private const string Exp_Text = "Text";

        //When these are true, the helper text was cleared out, and the value can be safely used !
        private bool txtRomPath_init    = false;
        //private bool txtExportPath_init = false;
        private bool txtOutRomPath_init = false;

        //Variables
        private string m_lastExportDirectory   = string.Empty;
        private string m_ExtractedRomDirectory = string.Empty;

        public MainWindows()
        {
            InitializeComponent();

            //Fill the export and import checked lists
            chklstExport.Items.Clear();
            chklstExport.Items.Add( Exp_ItemData, false );
            chklstExport.Items.Add(Exp_MoveData, false);
            chklstExport.Items.Add(Exp_PkStats, false);
            chklstExport.Items.Add(Exp_Text, false);

            chklstImport.Items.Clear();
            chklstImport.Items.Add(Exp_ItemData, false);
            chklstImport.Items.Add(Exp_MoveData, false);
            chklstImport.Items.Add(Exp_PkStats, false);
            chklstImport.Items.Add(Exp_Text, false);

            WriteExesToCWD();

            MainLayout.Select();

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

        private string HandleOpenFileBrowser(string initpath)
        {
            string filetoopen = string.Empty;
            openFileDialog1.ValidateNames   = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter          = FileFilter;

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
                {
                    filetoopen = openFileDialog1.FileName;
                }
                openFileDialog1.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filetoopen;
        }

        private string HandleSaveFileBrowser(string initpath)
        {
            string filetosave = string.Empty;
            saveFileDialog1.ValidateNames = false;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.Filter = FileFilter;

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
                {
                    filetosave = saveFileDialog1.FileName;
                }
                saveFileDialog1.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filetosave;
        }

        private void WriteObjToFile( byte[] bytes, string path )
        {
            if (File.Exists(path))  //Don't overwrite anything
                return;

            using (FileStream fsDst = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                //byte[] bytes = (byte[])theobj;
                fsDst.Write(bytes, 0, bytes.Length);
                fsDst.Close();
                fsDst.Dispose();
            }  
        }

        /*
         * Writes the 2 required executable to the current working directory.
         */
        private void WriteExesToCWD()
        {
            WriteObjToFile(Properties.Resources.ppmd_statsutil,     Path.Combine(Directory.GetCurrentDirectory(), StatsUtil_Name));
            WriteObjToFile(Properties.Resources.gamelang,           Path.Combine(Directory.GetCurrentDirectory(), "gamelang.xml"));
            WriteObjToFile(Properties.Resources.ndstool,            Path.Combine(Directory.GetCurrentDirectory(), "ndstool.exe"));
            WriteObjToFile(Properties.Resources.libgcc_s_sjlj_1,    Path.Combine(Directory.GetCurrentDirectory(), "libgcc_s_sjlj-1.dll"));
            WriteObjToFile(Properties.Resources.libstdc___6,        Path.Combine(Directory.GetCurrentDirectory(), "libstdc++-6.dll"));
        }

//========================================================================================
// App Logic
//========================================================================================
        private void CheckIfAllPathsSets()
        {

                //Validate the ROM path, the output directory, and output rom
            if (txtRomPath_init  && txtOutRomPath_init && 
                    ValidatePathExistsAsFileOrDir(txtInRomPath.Text) &&
                    ValidateParentDirExists(txtExportPath.Text) &&
                    ValidateOutputFilename(txtOutRomPath.Text, ROM_Extension))
                {
                    //Unlock the next sub-section
                    grpImports.Enabled = true;
                    grpEdits.Enabled   = true;
                    grpExport.Enabled  = true;
                    
                    if( System.IO.Directory.Exists(txtInRomPath.Text) )
                    { 
                        m_ExtractedRomDirectory = txtInRomPath.Text;
                        btnExtractRom.Enabled = false;
                    }
                    else
                    {
                        btnExtractRom.Enabled = true;
                    }
                }
                else
                {
                    //lock the next sub-section
                    grpImports.Enabled = false;
                    grpEdits.Enabled   = false;
                    grpExport.Enabled  = false;
                }

        }


        private void PopulateEditTreeView()
        {
            tvEditableData.Nodes.Clear();

            string[] subdirs  = System.IO.Directory.GetDirectories(m_lastExportDirectory);
            string[] subfiles = System.IO.Directory.GetFiles(m_lastExportDirectory);

            foreach( string dirname in subdirs )
            {
                TreeNode curnode = tvEditableData.Nodes.Add(System.IO.Path.GetFileName(dirname));
                curnode.ToolTipText = dirname;

                string[] curdirsubfiles = System.IO.Directory.GetFiles(dirname);
                foreach( string sf in curdirsubfiles )
                {
                    curnode.Nodes.Add(System.IO.Path.GetFileName(sf)).ToolTipText = sf;
                }
            }

            foreach( string fname in subfiles )
            {
                tvEditableData.Nodes.Add(System.IO.Path.GetFileName(fname)).ToolTipText = fname;
            }
        }

//========================================================================================
//  Path Validation
//========================================================================================

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

        private bool ValidateOutputFilename(string path, string extension)
        {
            try
            {
                if (path.Length == 0)
                    return false;

                //Check if path has valid parent dir, color the box accordingly
                System.IO.DirectoryInfo parentOutDir = System.IO.Directory.GetParent(path);

                return parentOutDir.Exists && 
                       System.IO.Path.HasExtension(path) &&
                       System.IO.Path.GetExtension(path).Substring(1).Equals(extension); //Skip the dot from the extension..
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidatePathExistsAsFileOrDir(string path)
        {
            try
            {
                if (path.Length == 0)
                    return false;

                //Check if path valid change bg color accordingly
                System.IO.DirectoryInfo mydir  = new System.IO.DirectoryInfo(path);
                System.IO.FileInfo      myfile = new System.IO.FileInfo(path);

                return ( (myfile.Exists && myfile.Extension.Substring(1) == ROM_Extension) || mydir.Exists );
            }
            catch (Exception)
            {
                return false;
            }
        }



//========================================================================================
//  Events
//========================================================================================

        //-----------------------------------------------------------------
        //  Browse Buttons
        //-----------------------------------------------------------------
        private void btnInFile_Click(object sender, EventArgs e)
        {
            if (!txtRomPath_init) //Clear out the helper text
            {
                txtInRomPath.Text = string.Empty;
                txtRomPath_init = true;
            }

            txtInRomPath.Text = HandleOpenFileBrowser(txtInRomPath.Text);

            CheckIfAllPathsSets();
            btnInFile.Focus();
        }

        private void btnInDir_Click(object sender, EventArgs e)
        {
            if (!txtRomPath_init) //Clear out the helper text
            { 
                txtInRomPath.Text = string.Empty;
                txtRomPath_init = true;
            }

            txtInRomPath.Text = HandleDirectoryBrowser(txtInRomPath.Text);

            CheckIfAllPathsSets();
            btnInDir.Focus();
        }

        private void btnOutDir_Click(object sender, EventArgs e)
        {
            txtExportPath.Text = HandleDirectoryBrowser(txtExportPath.Text);

            CheckIfAllPathsSets();
            btnOutDir.Focus();
        }

        private void btnOutRomFile_Click(object sender, EventArgs e)
        {
            if (!txtOutRomPath_init) //Clear out the helper text
            {
                txtOutRomPath.Text = string.Empty;
                txtOutRomPath_init = true;
            }

            txtOutRomPath.Text = HandleSaveFileBrowser(txtOutRomPath.Text);

            CheckIfAllPathsSets();
            btnOutRomFile.Focus();
        }


        //-----------------------------------------------------------------
        //  Path Textboxes
        //-----------------------------------------------------------------
        private void txtInRomPath_TextChanged(object sender, EventArgs e)
        {
            if (txtInRomPath.Text.Length == 0)
                return;

            if (ValidatePathExistsAsFileOrDir(txtInRomPath.Text))
            {
                txtInRomPath.BackColor = COLOR_CORRECT;
                CheckIfAllPathsSets();
            }
            else
                txtInRomPath.BackColor = COLOR_WRONG;
        }

        private void txtExportPath_TextChanged(object sender, EventArgs e)
        {
            if (txtExportPath.Text.Length == 0)
                return;

            if( ValidateParentDirExists(txtExportPath.Text) )
            {
                txtExportPath.BackColor = COLOR_CORRECT;
                CheckIfAllPathsSets();
            }
            else
                txtExportPath.BackColor = COLOR_WRONG;
        }

        private void txtOutRomPath_TextChanged(object sender, EventArgs e)
        {
            if (txtOutRomPath.Text.Length == 0)
                return;

            if (ValidateOutputFilename(txtOutRomPath.Text, ROM_Extension))
            {
                txtOutRomPath.BackColor = COLOR_CORRECT;
                CheckIfAllPathsSets();
            }
            else
                txtOutRomPath.BackColor = COLOR_WRONG;
        }

        private void txtRomPath_Enter(object sender, EventArgs e)
        {
            if (!txtRomPath_init) //Clear out the helper text
            {
                txtInRomPath.Text = string.Empty;
                txtRomPath_init = true;
            }
        }

        private void txtOutRomPath_Enter(object sender, EventArgs e)
        {
            if (!txtOutRomPath_init) //Clear out the helper text
            {
                txtOutRomPath.Text = string.Empty;
                txtOutRomPath_init = true;
            }
        }

        //-----------------------------------------------------------------
        //  Step #2 Stuff
        //-----------------------------------------------------------------



        private void DoRunStatsUtil(string extractedromdir, bool bexport, bool doitem, bool domoves, bool dopkstats, bool dotext)
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
                    if (runstatutil.StartUtil("-e \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" \"" + m_lastExportDirectory + "\"" + " -str -log"))
                    {
                        runstatutil.WaitUntilFinished();
                    }
                }
                else
                {
                    if (runstatutil.StartUtil("-i \"" + System.IO.Path.Combine(m_lastExportDirectory, DefaultGameStrName) + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\"" + " -str -log"))
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
                    myargs = myargs + System.IO.Path.Combine(extractedromdir, "data") + "\" \"" + m_lastExportDirectory + "\" -log";
                else
                    myargs = myargs + m_lastExportDirectory + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" -log";


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
                        myargs = myargs + System.IO.Path.Combine(extractedromdir, "data") + "\" \"" + System.IO.Path.Combine(m_lastExportDirectory, DefaultItemDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(m_lastExportDirectory, DefaultItemDir) + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" -log";

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
                        myargs = myargs + System.IO.Path.Combine(extractedromdir, "data") + "\" \"" + System.IO.Path.Combine(m_lastExportDirectory, DefaultMoveDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(m_lastExportDirectory, DefaultMoveDir) + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" -log";


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
                        myargs = myargs + System.IO.Path.Combine(extractedromdir, "data") + "\" \"" + System.IO.Path.Combine(m_lastExportDirectory, DefaultPkmnDir) + "\" -log";
                    else
                        myargs = myargs + System.IO.Path.Combine(m_lastExportDirectory, DefaultPkmnDir) + "\" \"" + System.IO.Path.Combine(extractedromdir, "data") + "\" -log";


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


        private void RunNdsTool( string romname, string dirname, bool bexport )
        {
            string args =" \"" + romname + "\" " +
                          "-9 \"" + dirname + "/arm9.bin\" " +
                          "-7 \"" + dirname + "/arm7.bin\" " +
                          "-y9 \"" + dirname + "/y9.bin\" " +
                          "-y7 \"" + dirname + "/y7.bin\" " +
                          "-d \"" + dirname + "/data\" " +
                          "-y \"" + dirname + "/overlay\" " +
                          "-t \"" + dirname + "/banner.bin\" " +
                          "-h \"" + dirname + "/header.bin\" " +
                          "-v";

            if( bexport )
                args = "-x" + args;
            else
                args = "-c" + args;

            UtilityLauncher runndstool = new UtilityLauncher(this, NDSTOOL_Name);

            //First extract the data
            if (runndstool.StartUtil(args))
            {
                runndstool.WaitUntilFinished();
            }

            if (runndstool.GetReturnCode() != 0)
                throw new Exception("ndstool.exe encountered an error.");
        }

        private void DoExtractRom()
        {
            m_ExtractedRomDirectory = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), RomExtractSubdir);

            System.IO.Directory.CreateDirectory(m_ExtractedRomDirectory);

            RunNdsTool(txtInRomPath.Text, m_ExtractedRomDirectory, true);
        }

        private void DoBuildRom()
        {
            //string extractedromdir = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), RomExtractSubdir);
            RunNdsTool(txtOutRomPath.Text, m_ExtractedRomDirectory, false);
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chklstExport.CheckedItems.Count == 0)
                return;

            m_lastExportDirectory = txtExportPath.Text;

            if (!System.IO.Directory.Exists(m_lastExportDirectory))
                System.IO.Directory.CreateDirectory(m_lastExportDirectory);
            //string romextractdir = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), RomExtractSubdir);

            MainLayout.Enabled = false;
            try
            {
                if (!System.IO.Directory.Exists(m_ExtractedRomDirectory))
                {
                    DoExtractRom();
                }


                bool doitem = false;
                bool domoves = false;
                bool dopkstats = false;
                bool dotext = false;

                //Gather a list of the operations we need to do
                for (int i = 0; i < chklstExport.CheckedItems.Count; ++i)
                //foreach( object item in chklstExport.CheckedItems )
                {
                    string itemname = chklstExport.GetItemText(chklstExport.CheckedItems[i]);

                    if (itemname.Equals(Exp_ItemData))
                    {
                        doitem = true;
                    }
                    else if (itemname.Equals(Exp_MoveData))
                    {
                        domoves = true;
                    }
                    else if (itemname.Equals(Exp_PkStats))
                    {
                        dopkstats = true;
                    }
                    else if (itemname.Equals(Exp_Text))
                    {
                        dotext = true;
                    }
                }

                DoRunStatsUtil(m_ExtractedRomDirectory, true, doitem, domoves, dopkstats, dotext);

                PopulateEditTreeView();
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

        private void btnExtractRom_Click(object sender, EventArgs e)
        {
            MainLayout.Enabled = false;
            try
            {
                DoExtractRom();
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

        //-----------------------------------------------------------------
        //  Step #3 Stuff
        //-----------------------------------------------------------------
        private void grpEdits_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void btnEditOutside_Click(object sender, EventArgs e)
        {
            //tvEditableData.SelectedNode.Text

            if (tvEditableData.SelectedNode != null)
                Process.Start( System.IO.Path.GetFullPath( tvEditableData.SelectedNode.ToolTipText ) );
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            if (m_lastExportDirectory != string.Empty)
                Process.Start( System.IO.Path.GetFullPath(m_lastExportDirectory) );
        }

        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URLToWiki);
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URLToGithub);
        }


        //-----------------------------------------------------------------
        //  Step #4 Stuff
        //-----------------------------------------------------------------
        private void btnRebuildRom_Click(object sender, EventArgs e)
        {
            MainLayout.Enabled = false;
            try
            {
                DoBuildRom();
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
            if (chklstImport.CheckedItems.Count == 0)
                return;

            string romextractdir = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), RomExtractSubdir);

            MainLayout.Enabled = false;
            try
            {
                bool doitem = false;
                bool domoves = false;
                bool dopkstats = false;
                bool dotext = false;

                //Gather a list of the operations we need to do
                for (int i = 0; i < chklstImport.CheckedItems.Count; ++i)
                {
                    string itemname = chklstImport.GetItemText(chklstImport.CheckedItems[i]);

                    if (itemname.Equals(Exp_ItemData))
                    {
                        doitem = true;
                    }
                    else if (itemname.Equals(Exp_MoveData))
                    {
                        domoves = true;
                    }
                    else if (itemname.Equals(Exp_PkStats))
                    {
                        dopkstats = true;
                    }
                    else if (itemname.Equals(Exp_Text))
                    {
                        dotext = true;
                    }
                }

                DoRunStatsUtil(romextractdir, false, doitem, domoves, dopkstats, dotext);
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

//
//  Context Strips
//
        private void mitChkAllExport_Click(object sender, EventArgs e)
        {
            for( int i = 0; i < chklstExport.Items.Count; ++i )
                chklstExport.SetItemChecked( i, true );
        }

        private void mitUnChkAllExport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstExport.Items.Count; ++i)
                chklstExport.SetItemChecked(i, false);
        }

        private void mitChkAllImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstImport.Items.Count; ++i)
                chklstImport.SetItemChecked(i, true);
        }

        private void mitUnChkAllImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstImport.Items.Count; ++i)
                chklstImport.SetItemChecked(i, false);
        }

    }
}
