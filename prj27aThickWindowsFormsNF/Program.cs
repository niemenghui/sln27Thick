using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj27aThickWindowsFormsNF
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]         //to use single-threaded apartment model instead of multi-threaded.
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //19
            Form1 frm1 = new Form1();
            Application.Run(frm1);
        }
    }
}
