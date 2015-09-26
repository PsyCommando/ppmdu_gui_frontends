using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace simple_ndstool_frontend
{
    class reswriter
    {
        public const string NDSToolFname = simple_ndstool_frontend.MainWindow.NdsToolName;
        public const string StdlibdllFname = "libstdc++-6.dll";
        public const string gcclibdllFname = "libgcc_s_sjlj-1.dll";

        public static void WriteEmbeddedResourcesToCWD()
        {
            WriteObjToFile(Properties.Resources.ndstool, Path.Combine(Directory.GetCurrentDirectory(), NDSToolFname));
            WriteObjToFile(Properties.Resources.libstdc___6, Path.Combine(Directory.GetCurrentDirectory(), StdlibdllFname));
            WriteObjToFile(Properties.Resources.libgcc_s_sjlj_1, Path.Combine(Directory.GetCurrentDirectory(), gcclibdllFname));
        }

        private static void WriteObjToFile(byte[] bytes, string path)
        {
            if (File.Exists(path))  //Don't overwrite anything
                return;

            using (FileStream fsDst = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                fsDst.Write(bytes, 0, bytes.Length);
                fsDst.Close();
                fsDst.Dispose();
            }
        }
    }
}
