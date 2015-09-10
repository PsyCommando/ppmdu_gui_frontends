using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace FrontendCommon
{
    public class UtilityLauncher
    {
        private const string LOG_FILE_PREFIX = "execlog_";
        private const string LOG_FILE_SUFFIX = ".log";
        private string       m_utilname;
        private IWin32Window m_parentwin;
        private Process      m_process;
        private bool         m_HasRedirectedOutputs;

        public UtilityLauncher( IWin32Window parentWindow, String utilityName )
        {
            m_utilname  = utilityName;
            m_parentwin = parentWindow;
            m_process   = null;
        }

        public bool StartUtil( String args, bool hideWindow = false, bool redirectOutStreams = false )
        {
            string cwd = System.IO.Directory.GetCurrentDirectory();
            string AppPath = cwd + "\\" + m_utilname;

            //Check if utility is here
            System.IO.FileInfo myfile = new System.IO.FileInfo(AppPath);
            //if (myfile.Exists)
            //{
            //Launch utility
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            //startInfo.ErrorDialog = true;
            startInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
            startInfo.FileName = AppPath;
            startInfo.Arguments = args;
            //startInfo.RedirectStandardError = redirectOutStreams;
            //startInfo.RedirectStandardOutput = redirectOutStreams;
            m_HasRedirectedOutputs = redirectOutStreams;

            if (hideWindow)
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            m_process = Process.Start(startInfo);

            return m_process != null;
            //}
            //else
            //{
            //    //Show message about missing application.
            //    MessageBox.Show(m_parentwin, m_utilname + " is missing from the application's folder !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }

        public void KillUtil()
        {
            if (m_process != null) 
            { 
                m_process.Kill();
            }
            else
                throw new Exception("Process not started");
        }

        public void WaitUntilFinished()
        {
            if (m_process != null)
            {
                m_process.WaitForExit();
            }
            else
                throw new Exception("Process not started");
        }

        public String GetLastLineOutput()
        {
            if (m_process != null)
            {
                return m_process.StandardOutput.ReadLine();
            }
            else
                throw new Exception("Process not started");
        }

        public System.IO.StreamReader GetOutputStream()
        {
            if (m_process != null)
            {
                return m_process.StandardOutput;
            }
            else
                throw new Exception("Process not started");
        }

        public bool GetHasExited()
        {
            return m_process.HasExited;
        }

        public int GetReturnCode()
        {
            return m_process.ExitCode;
        }

        /*
         * Static method to execute the utility straight away.
         * Return true when the execution went without problems.
         */
        public static bool ExecuteUtility( IWin32Window parentWindow, String utilityName, String args, bool hideWindow = false )
        {
            try
            {
                //System.IO.StreamWriter fstr = System.IO.File.CreateText(LOG_FILE_PREFIX + utilityName + LOG_FILE_SUFFIX);
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
                    startInfo.RedirectStandardError = false;
                    startInfo.RedirectStandardOutput = false;

                    if (hideWindow)
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();

                        //fstr.Write(exeProcess.StandardOutput.ReadToEnd());
                        //string errorstream = exeProcess.StandardError.ReadToEnd();
                        //fstr.Write( errorstream );
                        //fstr.Flush();
                        //fstr.Close();

                        if (exeProcess.ExitCode != 0)
                        {
                            MessageBox.Show(parentWindow, utilityName + " returned code " + exeProcess.ExitCode + ", the operation may have failed.\n" /*+ errorstream*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                else
                {
                    //Show message about missing application.
                    MessageBox.Show(parentWindow, utilityName + " is missing from the application's folder !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(parentWindow, e.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
