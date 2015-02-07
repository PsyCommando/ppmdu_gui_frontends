using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppmd_frontends
{
    public partial class KaoutilForm : fileinputoutput_form
    {
        public const string KAOMADO_FILEX = ".kao";

        public KaoutilForm()
        {
            InitializeComponent();
        }

        public override string GetOutputFileExtension()
        {
            return KAOMADO_FILEX;
        }
    }
}
