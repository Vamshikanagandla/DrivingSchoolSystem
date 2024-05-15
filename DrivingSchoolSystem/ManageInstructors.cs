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
    public partial class ManageInstructors : Form
    {
        public ManageInstructors()
        {
            InitializeComponent();
        }

        private void ManageInstructors_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Phone";
            dataGridView1.Columns[4].Name = "Specialization";

            foreach (var instructor in Singleton.Instructors)
            {
                dataGridView1.Rows.Add(
                    instructor.Id,
                    instructor.Name,
                    instructor.Email,
                    instructor.Phone,
                    instructor.Specialization
                );
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                Instructor instructorToRemove = Singleton.Instructors.Find(instructor => instructor.Id == selectedId);
                if (instructorToRemove != null)
                {
                    Singleton.Instructors.Remove(instructorToRemove);
                }

                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Instructor deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            frm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManageCourses frm = new ManageCourses();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentForm f1 = new StudentForm();
            f1.Show();
            this.Hide();
        }
    }
    }

