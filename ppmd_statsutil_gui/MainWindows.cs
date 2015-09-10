using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppmd_statsutil_gui
{
    public partial class MainWindows : Form
    {
        private Color  COLOR_CORRECT = Color.FromArgb(200, 255, 200);
        private Color  COLOR_WRONG   = Color.FromArgb(255, 200, 200);
        private const string ROM_Extension = "nds";
        private const string FileFilter = "NDS ROM|*.nds|All Files|*.*";

        //When these are true, the helper text was cleared out, and the value can be safely used !
        private bool txtRomPath_init    = false;
        //private bool txtExportPath_init = false;
        private bool txtOutRomPath_init = false;

        public MainWindows()
        {
            InitializeComponent();
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
                }
                else
                {
                    //lock the next sub-section
                    grpImports.Enabled = false;
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
        //  
        //-----------------------------------------------------------------



    }
}
