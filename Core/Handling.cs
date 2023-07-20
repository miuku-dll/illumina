using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using illumina.Core;

namespace illumina.Core
{
    internal class Handling
    {

        public static void QuickSave()
        {
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }



        // Error codes

        public static void Error101()
        {
            MessageBox.Show("Error 101");
        }
    }
}
