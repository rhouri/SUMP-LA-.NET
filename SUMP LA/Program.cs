using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SUMPLA_net
    {
    static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Launching...");
            Application.Run(new LA2Frm2());
            }
        }
    }
