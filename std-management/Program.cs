using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std_management
{
    static class Globals
    {
        static public bool isAuth = false;
    }

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

            //Application.Run(new HRForm());
            //return;

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    if (loginForm.isStudent)
                        Application.Run(new MainForm());
                    else 
                        Application.Run(new HRForm());
                }
            }
        }
    }
}
