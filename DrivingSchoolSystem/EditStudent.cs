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
    public partial class EditStudent : Form
    {
        int id;
        public EditStudent(int studentID)
        {
            id = studentID;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Student studentToUpdate = Singleton.Students.Find(s => s.Id == id);

            string name = namet.Text.Trim();
            string email = emailt.Text.Trim();
            string contact = contactt.Text.Trim();
            DateTime dob = datet.Value;
            string gender = gendert.SelectedItem?.ToString();

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

            studentToUpdate.Name = name;
            studentToUpdate.Email = email;
            studentToUpdate.Phone = contact;
            studentToUpdate.Gender = gender;
            studentToUpdate.Dob = dob;

            MessageBox.Show("Student details updated successfully.");
        }


        private void EditStudent_Load(object sender, EventArgs e)
        {

            Student studentToEdit = Singleton.Students.Find(s => s.Id == id);

            if (studentToEdit != null)
            {
                idt.Text = studentToEdit.Id.ToString();
                enrollt.Text = studentToEdit.EnrollmentDate.ToString();
                namet.Text = studentToEdit.Name;
                emailt.Text = studentToEdit.Email;
                contactt.Text = studentToEdit.Phone;
                gendert.SelectedItem = studentToEdit.Gender;
                datet.Value = studentToEdit.Dob;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
