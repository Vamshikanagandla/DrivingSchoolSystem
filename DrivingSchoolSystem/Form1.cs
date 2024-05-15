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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = idt.Text;
            String pass = passt.Text;

            if(id.Equals("KAN23206161") && pass.Equals("KAN23206161"))
            {
                MessageBox.Show("Login Successfull");
                AdminDashboard frm = new AdminDashboard();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
