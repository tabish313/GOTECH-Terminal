using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOTECH.Startup;
using GOTECH.Home;
using GOTECH.Course;
using GOTECH.Students;
using GOTECH.Trainer;
using GOTECH.Business;
using GOTECH.Help;

namespace GOTECH
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
            Application.Run(new FormLogin());
        }

        public static bool IsDesignMode()
        {
            if(Application.ExecutablePath.IndexOf("devenv.exe",StringComparison.OrdinalIgnoreCase)>1)
            {
                return true;
            }
            return false;
        }
    }
}
