using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher t1 = new Teacher();
            t1.Visible = true;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student std1 = new Student();
            std1.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin ad1 = new Admin();
            ad1.Visible = true;
        }

        


    }
}
