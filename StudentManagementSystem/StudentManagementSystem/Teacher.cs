using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace StudentManagementSystem
{
    public partial class Teacher : Form
    {
       
        public Teacher()
        {
            InitializeComponent();
            AutoGenarateID();
        }
        private DataAccess Da = new DataAccess();
        private DataSet Ds { get; set; }
        private string SqlQurey { get; set; }

        private bool InvalidToInsert()
        {
            if (String.IsNullOrEmpty(this.txtInputTeacherId.Text) || String.IsNullOrEmpty(this.txtTeacherName.Text) || String.IsNullOrEmpty(this.txtTeacherAge.Text) || String.IsNullOrEmpty(this.txtTeacherEmail.Text) || String.IsNullOrEmpty(this.txtTeacherNumber.Text) || String.IsNullOrEmpty(this.txtTeacherAddress.Text) || String.IsNullOrEmpty(this.txtTeacherSalary.Text) || String.IsNullOrEmpty(this.txtPasswordTeacher.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void AutoGenarateID()
        {
            this.SqlQurey = @"select * from teacher order by teacher_id desc;";
            this.Ds = this.Da.ExecuteQuery(SqlQurey);
            string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('t');
            int serial = Convert.ToInt32(temp[1]);
            string nextID = "t" + (++serial).ToString("000");
            this.txtInputTeacherId.Text = nextID;


        }


        private void btnSubmitTeacherInfo_Click(object sender, EventArgs e)
        {
            try
            {
                bool decision = InvalidToInsert();
                if (decision)
                {
                    this.SqlQurey = @"insert into teacher
values('" + this.txtInputTeacherId.Text + "', '" + this.txtTeacherName.Text + "', '" + this.txtTeacherEmail.Text + "', '" + this.txtTeacherNumber.Text + "', '" + this.txtTeacherAddress.Text + "', '" + this.txtTeacherSalary.Text + "', '" + this.txtTeacherAge.Text + "', '" + this.dtpJoinTeacher.Text + "', '" + this.txtPasswordTeacher.Text + "');";

                    int row = this.Da.ExecuteUpdateQuery(SqlQurey);
                    if (row == 1)
                    {
                        MessageBox.Show("insert Successfull");
                        this.txtTeacherName.Text = "";
                        this.txtTeacherAge.Text = "";

                        this.txtTeacherNumber.Text = "";
                        this.txtTeacherEmail.Text = "";
                        this.txtTeacherAddress.Text = "";
                        this.txtTeacherSalary.Text = "";
                        this.txtPasswordTeacher.Text = "";

                        AutoGenarateID();
                    }
                    else
                    {
                        MessageBox.Show("S Data Insert Error");
                    }

                }
                else
                {
                    MessageBox.Show("Insert All the values");
                }


            }

            catch (Exception eee)

            {
                MessageBox.Show(" Insert all The Values properly " + eee.Message.ToString());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tcTeacherInset.SelectedIndex = 0;
            this.tcTeacherInset.Visible=true;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.tcTeacherInset.SelectedIndex = 1;
            this.tcTeacherInset.Visible = true;
        }

        private void btnAllInfo_Click(object sender, EventArgs e)
        {
            this.SqlQurey = @"select * from teacher;";

            Ds = this.Da.ExecuteQuery(SqlQurey);
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.DataSource = Ds.Tables[0];
        }

        private void btnTeacherSearch_Click(object sender, EventArgs e)
        {
            this.SqlQurey = @"select* from teacher where teacher_id = '" + this.txtInsertIDSearch.Text + "';";
            Ds = this.Da.ExecuteQuery(SqlQurey);
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.DataSource = Ds.Tables[0];
        }
    }
}
