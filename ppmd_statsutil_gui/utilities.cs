using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Resources;
using System.Threading;
using System.IO;

/*
 * This utility class is used to write the embedded resources to the current working directory.
 */

namespace ppmd_statsutil_gui
{
    class utilities
    {
        public const string StatsUtilFname = ppmd_statsutil_gui.NewMainWindow.StatsUtil_Name;
        public const string GameLangFname  = "gamelang.xml";

        public static void WriteEmbeddedResourcesToCWD()
        {
            if (!File.Exists(StatsUtilFname))
                WriteObjToFile(Properties.Resources.ppmd_statsutil, Path.Combine(Directory.GetCurrentDirectory(), StatsUtilFname));
            if (!File.Exists(GameLangFname))
                WriteObjToFile(Properties.Resources.gamelang, Path.Combine(Directory.GetCurrentDirectory(), GameLangFname));
        }

        private static void WriteObjToFile(byte[] bytes, string path)
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
    }
}
