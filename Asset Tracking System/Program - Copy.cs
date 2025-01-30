using System;
using System.Windows.Forms;

namespace Draft_4
{
    internal static class Program
    {
        private static readonly int empId = 1; // This is a placeholder for the employee ID

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login()); 
            Application.Run(new IT_Department(empId));
            Application.Run(new Other_Employee_Assets(empId));

        }
    }
}
