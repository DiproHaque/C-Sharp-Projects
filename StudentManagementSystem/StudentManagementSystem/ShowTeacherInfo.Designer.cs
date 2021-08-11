
namespace StudentManagementSystem
{
    partial class ShowTeacherInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tcTeacherMarks = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarkID = new System.Windows.Forms.TextBox();
            this.btnMarkSubmit = new System.Windows.Forms.Button();
            this.txtEnterIDStudent = new System.Windows.Forms.TextBox();
            this.cmbSubjectSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddMarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvTeacherOwnInfo = new System.Windows.Forms.DataGridView();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tcTeacherMarks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherOwnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnAddMarks);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 210);
            this.panel1.TabIndex = 0;
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarks.Location = new System.Drawing.Point(19, 117);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(75, 71);
            this.btnAddMarks.TabIndex = 1;
            this.btnAddMarks.Text = "Add Marks";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(19, 18);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 71);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tcTeacherMarks
            // 
            this.tcTeacherMarks.Controls.Add(this.tabPage1);
            this.tcTeacherMarks.Controls.Add(this.tabPage2);
            this.tcTeacherMarks.Location = new System.Drawing.Point(218, 167);
            this.tcTeacherMarks.Name = "tcTeacherMarks";
            this.tcTeacherMarks.SelectedIndex = 0;
            this.tcTeacherMarks.Size = new System.Drawing.Size(937, 496);
            this.tcTeacherMarks.TabIndex = 1;
            this.tcTeacherMarks.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Marks";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMarkID);
            this.panel2.Controls.Add(this.btnMarkSubmit);
            this.panel2.Controls.Add(this.txtEnterIDStudent);
            this.panel2.Controls.Add(this.cmbSubjectSelect);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAddMarks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 313);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark ID";
            // 
            // txtMarkID
            // 
            this.txtMarkID.Location = new System.Drawing.Point(130, 28);
            this.txtMarkID.Name = "txtMarkID";
            this.txtMarkID.ReadOnly = true;
            this.txtMarkID.Size = new System.Drawing.Size(100, 22);
            this.txtMarkID.TabIndex = 7;
            // 
            // btnMarkSubmit
            // 
            this.btnMarkSubmit.Location = new System.Drawing.Point(190, 224);
            this.btnMarkSubmit.Name = "btnMarkSubmit";
            this.btnMarkSubmit.Size = new System.Drawing.Size(75, 71);
            this.btnMarkSubmit.TabIndex = 6;
            this.btnMarkSubmit.Text = "Marks Submit";
            this.btnMarkSubmit.UseVisualStyleBackColor = true;
            this.btnMarkSubmit.Click += new System.EventHandler(this.btnMarkSubmit_Click);
            // 
            // txtEnterIDStudent
            // 
            this.txtEnterIDStudent.Location = new System.Drawing.Point(130, 72);
            this.txtEnterIDStudent.Name = "txtEnterIDStudent";
            this.txtEnterIDStudent.Size = new System.Drawing.Size(100, 22);
            this.txtEnterIDStudent.TabIndex = 5;
            // 
            // cmbSubjectSelect
            // 
            this.cmbSubjectSelect.FormattingEnabled = true;
            this.cmbSubjectSelect.Items.AddRange(new object[] {
            "sub1",
            "sub2",
            "sub3",
            "sub4",
            "sub5",
            "sub6",
            "sub7",
            "sub8",
            "sub9",
            "sub10",
            "sub11",
            "sub12"});
            this.cmbSubjectSelect.Location = new System.Drawing.Point(144, 138);
            this.cmbSubjectSelect.Name = "cmbSubjectSelect";
            this.cmbSubjectSelect.Size = new System.Drawing.Size(121, 24);
            this.cmbSubjectSelect.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Subject ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Student ID";
            // 
            // txtAddMarks
            // 
            this.txtAddMarks.Location = new System.Drawing.Point(119, 183);
            this.txtAddMarks.Name = "txtAddMarks";
            this.txtAddMarks.Size = new System.Drawing.Size(100, 22);
            this.txtAddMarks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(14, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Marks";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Salmon;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvTeacherOwnInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Location = new System.Drawing.Point(24, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(26, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 71);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvTeacherOwnInfo
            // 
            this.dgvTeacherOwnInfo.AllowUserToAddRows = false;
            this.dgvTeacherOwnInfo.AllowUserToDeleteRows = false;
            this.dgvTeacherOwnInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherOwnInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacher_name,
            this.teacher_id,
            this.teacher_password});
            this.dgvTeacherOwnInfo.Location = new System.Drawing.Point(50, 173);
            this.dgvTeacherOwnInfo.Name = "dgvTeacherOwnInfo";
            this.dgvTeacherOwnInfo.ReadOnly = true;
            this.dgvTeacherOwnInfo.RowHeadersWidth = 51;
            this.dgvTeacherOwnInfo.RowTemplate.Height = 24;
            this.dgvTeacherOwnInfo.Size = new System.Drawing.Size(837, 205);
            this.dgvTeacherOwnInfo.TabIndex = 0;
            // 
            // teacher_name
            // 
            this.teacher_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.MinimumWidth = 6;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // teacher_id
            // 
            this.teacher_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "Teacher ID";
            this.teacher_id.MinimumWidth = 6;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            // 
            // teacher_password
            // 
            this.teacher_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_password.DataPropertyName = "teacher_password";
            this.teacher_password.HeaderText = "Teacher Password";
            this.teacher_password.MinimumWidth = 6;
            this.teacher_password.Name = "teacher_password";
            this.teacher_password.ReadOnly = true;
            // 
            // ShowTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1242, 705);
            this.Controls.Add(this.tcTeacherMarks);
            this.Controls.Add(this.panel1);
            this.Name = "ShowTeacherInfo";
            this.Text = "ShowTeacherInfo";
            this.panel1.ResumeLayout(false);
            this.tcTeacherMarks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherOwnInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TabControl tcTeacherMarks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMarkSubmit;
        private System.Windows.Forms.TextBox txtEnterIDStudent;
        private System.Windows.Forms.ComboBox cmbSubjectSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvTeacherOwnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_password;
    }
}