using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Windows.Forms;

namespace TutorManager2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent());
        }
    }
}
