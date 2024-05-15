using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DrivingSchoolSystem
{
    public partial class Booklesson : Form
    {
        int id;
        public Booklesson(int studentID)
        {
            id = studentID;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void Booklesson_Load(object sender, EventArgs e)
        {
            // Check if id has been initialized
            if (id != 0)
            {
                Student studentToEdit = Singleton.Students.Find(s => s.Id == id);

                if (studentToEdit != null)
                {
                    idt.Text = studentToEdit.Id.ToString();
                    namet.Text = studentToEdit.Name;

                }
            }
            else
            {
                MessageBox.Show("Student ID is not initialized.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            frm.Show();
            this.Hide();
        }
    }
}
