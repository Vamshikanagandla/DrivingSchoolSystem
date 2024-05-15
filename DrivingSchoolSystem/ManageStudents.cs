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
    public partial class ManageStudents : Form
    {
        

        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Phone";
            dataGridView1.Columns[4].Name = "Gender";
            dataGridView1.Columns[5].Name = "DOB";
            dataGridView1.Columns[6].Name = "Enrollment Date";

            foreach (var student in Singleton.Students)
            {
                dataGridView1.Rows.Add(
                    student.Id,
                    student.Name,
                    student.Email,
                    student.Phone,
                    student.Gender,
                    student.Dob.ToShortDateString(),
                    student.EnrollmentDate.ToShortDateString()
                );
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                Student studentToRemove = Singleton.Students.Find(student => student.Id == selectedId);
                if (studentToRemove != null)
                {
                    Singleton.Students.Remove(studentToRemove);
                }

                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            StudentForm f1 = new StudentForm();
            f1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                EditStudent editForm = new EditStudent(selectedId);
                editForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageCourses frm = new ManageCourses();
            frm.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManageInstructors frm = new ManageInstructors();
            frm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                Booklesson bookForm = new Booklesson(selectedId);
                bookForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
