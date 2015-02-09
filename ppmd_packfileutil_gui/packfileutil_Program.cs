using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ppmd_packfileutil_gui
{
    static class packfileutil_Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new packfileutil_form());
        }
    }
}
