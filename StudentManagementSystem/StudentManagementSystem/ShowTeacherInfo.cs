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

namespace StudentManagementSystem
{
    public partial class ShowTeacherInfo : Form
    {
        Login l1;
        Teacher t;
        private DataAccess Da = new DataAccess();
        private DataSet Ds { get; set; }
        private string sqlQurey { get; set; }

        public ShowTeacherInfo(Login ll1)
        {
           
            InitializeComponent();
            this.l1 = ll1;
            AutoGenarateIDMark();
        }

        private bool InvalidToInsert()
        {
            if (String.IsNullOrEmpty(this.txtMarkID.Text) || String.IsNullOrEmpty(this.txtEnterIDStudent.Text) || String.IsNullOrEmpty(this.txtAddMarks.Text) || String.IsNullOrEmpty(this.cmbSubjectSelect.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnMarkSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                bool decision = InvalidToInsert();
                if (decision)
                {
                    this.sqlQurey = @"insert into marks
         values('" + this.txtMarkID.Text + "', '" + this.txtEnterIDStudent.Text + "'," + this.txtAddMarks.Text + ", '" + this.cmbSubjectSelect.Text + "');";

                    int row = this.Da.ExecuteUpdateQuery(sqlQurey);
                    if (row == 1)
                    {
                        MessageBox.Show("Insert Successfull");

                        AutoGenarateIDMark();
                    }
                    else
                    {
                        MessageBox.Show("Data Insert Error");
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


        private void AutoGenarateIDMark()
        {
            this.sqlQurey = @"select * from marks order by mark_id desc;";
            this.Ds = this.Da.ExecuteQuery(sqlQurey);
            string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('m');
            int serial = Convert.ToInt32(temp[1]);
            string nextID = "m" + (++serial).ToString("000");
            this.txtMarkID.Text = nextID;
         

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.tcTeacherMarks.Visible = true;
            this.tcTeacherMarks.SelectedIndex = 1;
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            this.tcTeacherMarks.Visible = true;
            this.tcTeacherMarks.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.sqlQurey = @"select * from teacher where teacher_id='"+this.l1.txtUserID.Text+"';";
            Ds = this.Da.ExecuteQuery(sqlQurey);
            this.dgvTeacherOwnInfo.AutoGenerateColumns = false;
            this.dgvTeacherOwnInfo.DataSource = Ds.Tables[0];
        }
    }
}
