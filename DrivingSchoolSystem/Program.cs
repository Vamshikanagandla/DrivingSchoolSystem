using System;
using System.Windows.Forms;

namespace DrivingSchoolSystem
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

            // Run your main form
            Form1 mainForm = new Form1();
            Application.Run(mainForm);

            // After the main form is closed, set icon for all open forms
            foreach (Form form in Application.OpenForms)
            {
                form.Icon = Properties.Resources.abc; // Assuming "acc" is the name of your icon resource
            }
        }
    }
}