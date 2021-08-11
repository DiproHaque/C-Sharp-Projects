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
    public partial class ShowStudentInfo : Form
    {
        Login ll1 ;
        Student ssss;

        private DataAccess da1 = new DataAccess();
        private DataSet Ds2 { get; set; }
        private DataSet Ds3 { get; set; }
        private DataSet Ds4 { get; set; }
     
       
        private string sqlQurey1 { get; set; }
        private string sqlQurey2 { get; set; }
        private string sqlQurey3 { get; set; }

        public ShowStudentInfo(Login l1)
        {
            InitializeComponent();
            this.ll1 = l1;
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 0;
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 1;
              
        }  

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            this.sqlQurey1 = @"select * from studentinfo where id='"+ll1.txtUserID.Text+"';";
            Ds2 = this.da1.ExecuteQuery(sqlQurey1);
           this.dgvShowInfo.AutoGenerateColumns = false;
            this.dgvShowInfo.DataSource = Ds2.Tables[0];
        }

        private void ShowStudentInfo_Load(object sender, EventArgs e)
        {
            txtExample.Text = ll1.txtUserID.Text;
        }

        private void btnShowMarks_Click(object sender, EventArgs e)
        {
            //this.sqlQurey1 = @"
            //                select *
            //              from studentinfo,subject
            //            where studentinfo.class_id=subject.class_id and studentinfo.id='"+this.ll1.txtUserID.Text+"';";

            this.sqlQurey1 = @"select *
                             from studentinfo,subject
                             where studentinfo.class_id=subject.class_id 
                             and studentinfo.id='"+this.ll1.txtUserID.Text+"';";

            Ds2 = this.da1.ExecuteQuery(sqlQurey1);
            this.dgvStudentMarks.AutoGenerateColumns = false;
            this.dgvStudentMarks.DataSource = Ds2.Tables[0];


            this.sqlQurey3 = @"select *
                              from studentinfo,marks
                              where studentinfo.id=marks.id 
                              and studentinfo.id='" + this.ll1.txtUserID.Text + "';";

            Ds4 = this.da1.ExecuteQuery(sqlQurey3);
            this.dgvMark.AutoGenerateColumns = false;
            this.dgvMark.DataSource = Ds4.Tables[0];



            this.sqlQurey2 = @"select * from studentinfo where id='" + ll1.txtUserID.Text + "';";
            Ds3 = this.da1.ExecuteQuery(sqlQurey2);
            this.lblStudentName.Text=Ds3.Tables[0].Rows[0][1].ToString();
           
        }
    }
}
