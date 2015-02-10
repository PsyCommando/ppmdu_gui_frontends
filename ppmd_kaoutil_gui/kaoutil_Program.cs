using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppmd_kaoutil_gui
{
    static class kaoutil_Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new kaoutil_form());
        }
    }
}
