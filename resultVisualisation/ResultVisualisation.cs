using System;
using System.Windows.Forms;

namespace resultVisualisation
{
    static class ResultVisualisation
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationForm form = new ApplicationForm();

            Application.Run(form);
        }
    }
}
