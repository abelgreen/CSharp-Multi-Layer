using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace MainApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Sielence is Gold
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HiTech());
        }
    }
}
