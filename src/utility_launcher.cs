using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace FrontendCommon
{
    public static class UtilityLauncher
    {
        public static void ExecuteUtility( IWin32Window parentWindow, String utilityName, String args, bool hideWindow = false )
        {
            try
            {
                string cwd = System.IO.Directory.GetCurrentDirectory();
                string AppPath = cwd + "\\" + utilityName;

                //Check if utility is here
                System.IO.FileInfo myfile = new System.IO.FileInfo(AppPath);
                if (myfile.Exists)
                {
                    //Launch utility
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.CreateNoWindow = false;
                    startInfo.UseShellExecute = false;
                    startInfo.ErrorDialog = true;
                    startInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
                    startInfo.FileName = AppPath;
                    startInfo.Arguments = args;

                    if (hideWindow)
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }

                }
                else
                {
                    //Show message about missing application.
                    MessageBox.Show(parentWindow, utilityName + " is missing from the application's folder !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(parentWindow, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
