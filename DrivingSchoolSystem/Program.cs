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

            // Set the icon for the main form
            mainForm.Icon = Properties.Resources.abc; // Assuming "acc" is the name of your icon resource

            // Subscribe to the Load event for each form to set their icons
            mainForm.Load += MainForm_Load;

            Application.Run(mainForm);
        }

        // Event handler for the Load event of the main form
        private static void MainForm_Load(object sender, EventArgs e)
        {
            // Set icon for all open forms associated with the main form
            foreach (Form form in Application.OpenForms)
            {
                if (form != sender) // Exclude the main form itself
                {
                    form.Icon = Properties.Resources.abc; // Assuming "acc" is the name of your icon resource
                }
            }
        }
    }
}