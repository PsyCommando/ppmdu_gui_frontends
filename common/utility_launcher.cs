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
        private const string LOG_FILE_PREFIX = "execlog_";
        private const string LOG_FILE_SUFFIX = ".log";

        public static void ExecuteUtility( IWin32Window parentWindow, String utilityName, String args, bool hideWindow = false )
        {
            try
            {
                System.IO.StreamWriter fstr = System.IO.File.CreateText(LOG_FILE_PREFIX + utilityName + LOG_FILE_SUFFIX);
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
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;

                    if (hideWindow)
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();

                        fstr.Write(exeProcess.StandardOutput.ReadToEnd());
                        string errorstream = exeProcess.StandardError.ReadToEnd();
                        fstr.Write( errorstream );
                        fstr.Flush();
                        fstr.Close();

                        if (exeProcess.ExitCode != 0)
                        {
                            MessageBox.Show(parentWindow, "Kaoutil returned code " + exeProcess.ExitCode + ", the operation may have failed.\n" + errorstream, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
