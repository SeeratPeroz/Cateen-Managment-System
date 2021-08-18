using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    static class Program
    {
        public static bool isUserValid;
        public static String userName;
        public static String userPass;
        public static string userRole;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            // If user and pass correct then Open Main Page
            if (isUserValid == true)
            {
                Application.Run(new frmMain());
            }
           
        }

    }
}
