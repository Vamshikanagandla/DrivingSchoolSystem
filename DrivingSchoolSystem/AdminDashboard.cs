using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            studentst.Text = Singleton.Students.Count < 10 ? "0" + Singleton.Students.Count.ToString() : Singleton.Students.Count.ToString();
            coursest.Text = Singleton.Courses.Count < 10 ? "0" + Singleton.Courses.Count.ToString() : Singleton.Courses.Count.ToString();
            instructorst.Text = Singleton.Instructors.Count < 10 ? "0" + Singleton.Instructors.Count.ToString() : Singleton.Instructors.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCourses frm = new ManageCourses();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageInstructors frm = new ManageInstructors();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
