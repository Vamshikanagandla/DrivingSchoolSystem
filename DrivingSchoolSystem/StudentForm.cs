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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string name = namet.Text.Trim();
            string email = emailt.Text.Trim();
            string contact = contactt.Text.Trim();
            DateTime dob = datet.Value;
            string gender = gendert.SelectedItem?.ToString();
            string instructor = instructort.Text.Trim();
            string duration = durationt.Text.Trim();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DateTime today = DateTime.Today;
            DateTime eighteenYearsAgo = today.AddYears(-18);
            if (dob > eighteenYearsAgo)
            {
                MessageBox.Show("Date of Birth must be at least 18 years ago.");
                return;
            }

            

            Random random = new Random();
            int newId = random.Next(1000, 10000);

            if (Singleton.Students.Count > 0)
            {
                int maxId = Singleton.Students.Max(s => s.Id);
                newId = Math.Max(newId, maxId + 1);
            }

            Student newStudent = new Student(newId, name, email, contact, gender, dob, instructor, duration);
            Singleton.Students.Add(newStudent);



            MessageBox.Show("Student added successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void namet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void emailt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contactt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void datet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gendert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void instructort_TextChanged(object sender, EventArgs e)
        {

        }
        private void durationt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
