
namespace StudentManagementSystem
{
    partial class ShowStudentInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.tcStudentInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardian_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStudentMarks = new System.Windows.Forms.DataGridView();
            this.btnShowMarks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMark = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tcStudentInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMarks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMarks);
            this.panel1.Controls.Add(this.btnStudentInfo);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 241);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information";
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(17, 121);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(75, 64);
            this.btnMarks.TabIndex = 1;
            this.btnMarks.Text = "Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Location = new System.Drawing.Point(17, 37);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(75, 64);
            this.btnStudentInfo.TabIndex = 0;
            this.btnStudentInfo.Text = "Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // tcStudentInfo
            // 
            this.tcStudentInfo.Controls.Add(this.tabPage1);
            this.tcStudentInfo.Controls.Add(this.tabPage2);
            this.tcStudentInfo.Location = new System.Drawing.Point(199, 207);
            this.tcStudentInfo.Name = "tcStudentInfo";
            this.tcStudentInfo.SelectedIndex = 0;
            this.tcStudentInfo.Size = new System.Drawing.Size(989, 482);
            this.tcStudentInfo.TabIndex = 1;
            this.tcStudentInfo.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.txtExample);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.dgvShowInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(145, 23);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(200, 22);
            this.txtExample.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 44);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.AllowUserToAddRows = false;
            this.dgvShowInfo.AllowUserToDeleteRows = false;
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.guardian_name,
            this.number,
            this.address,
            this.join_date,
            this.end_date,
            this.fee,
            this.password});
            this.dgvShowInfo.Location = new System.Drawing.Point(15, 156);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.ReadOnly = true;
            this.dgvShowInfo.RowHeadersWidth = 51;
            this.dgvShowInfo.RowTemplate.Height = 24;
            this.dgvShowInfo.Size = new System.Drawing.Size(960, 226);
            this.dgvShowInfo.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Student ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // guardian_name
            // 
            this.guardian_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guardian_name.DataPropertyName = "gaurdian_name";
            this.guardian_name.HeaderText = "Parents";
            this.guardian_name.MinimumWidth = 6;
            this.guardian_name.Name = "guardian_name";
            this.guardian_name.ReadOnly = true;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // join_date
            // 
            this.join_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.join_date.DataPropertyName = "join_date";
            this.join_date.HeaderText = "Admission Date";
            this.join_date.MinimumWidth = 6;
            this.join_date.Name = "join_date";
            this.join_date.ReadOnly = true;
            this.join_date.Visible = false;
            // 
            // end_date
            // 
            this.end_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Finish Date";
            this.end_date.MinimumWidth = 6;
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Visible = false;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fee.DataPropertyName = "fee";
            this.fee.HeaderText = "Fees";
            this.fee.MinimumWidth = 6;
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            this.fee.Visible = false;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "User PassWord";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Violet;
            this.tabPage2.Controls.Add(this.dgvMark);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgvStudentMarks);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marks";
            // 
            // dgvStudentMarks
            // 
            this.dgvStudentMarks.AllowUserToAddRows = false;
            this.dgvStudentMarks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_name,
            this.student_id,
            this.class_name,
            this.subject,
            this.marks});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentMarks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentMarks.Location = new System.Drawing.Point(441, 88);
            this.dgvStudentMarks.Name = "dgvStudentMarks";
            this.dgvStudentMarks.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentMarks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentMarks.RowHeadersWidth = 51;
            this.dgvStudentMarks.RowTemplate.Height = 24;
            this.dgvStudentMarks.Size = new System.Drawing.Size(158, 243);
            this.dgvStudentMarks.TabIndex = 0;
            // 
            // btnShowMarks
            // 
            this.btnShowMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMarks.Location = new System.Drawing.Point(13, 22);
            this.btnShowMarks.Name = "btnShowMarks";
            this.btnShowMarks.Size = new System.Drawing.Size(75, 64);
            this.btnShowMarks.TabIndex = 4;
            this.btnShowMarks.Text = "Show Marks";
            this.btnShowMarks.UseVisualStyleBackColor = true;
            this.btnShowMarks.Click += new System.EventHandler(this.btnShowMarks_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStudentName);
            this.panel2.Controls.Add(this.btnShowMarks);
            this.panel2.Location = new System.Drawing.Point(20, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 208);
            this.panel2.TabIndex = 5;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.SlateGray;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudentName.Location = new System.Drawing.Point(174, 13);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 25);
            this.lblStudentName.TabIndex = 5;
            // 
            // student_name
            // 
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_name.DataPropertyName = "name";
            this.student_name.HeaderText = "Student Name";
            this.student_name.MinimumWidth = 6;
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Visible = false;
            // 
            // student_id
            // 
            this.student_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_id.DataPropertyName = "id";
            this.student_id.HeaderText = "Student ID";
            this.student_id.MinimumWidth = 6;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Visible = false;
            // 
            // class_name
            // 
            this.class_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.class_name.DataPropertyName = "class_name";
            this.class_name.HeaderText = "Class Name";
            this.class_name.MinimumWidth = 6;
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            this.class_name.Visible = false;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.DataPropertyName = "subject_name";
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // marks
            // 
            this.marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marks.DataPropertyName = "marks";
            this.marks.HeaderText = "Marks";
            this.marks.MinimumWidth = 6;
            this.marks.Name = "marks";
            this.marks.ReadOnly = true;
            this.marks.Visible = false;
            // 
            // dgvMark
            // 
            this.dgvMark.AllowUserToAddRows = false;
            this.dgvMark.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMark.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMark.Location = new System.Drawing.Point(605, 88);
            this.dgvMark.Name = "dgvMark";
            this.dgvMark.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMark.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMark.RowHeadersWidth = 51;
            this.dgvMark.RowTemplate.Height = 24;
            this.dgvMark.Size = new System.Drawing.Size(156, 243);
            this.dgvMark.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "class_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subject_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "marks";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marks";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ShowStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1216, 716);
            this.Controls.Add(this.tcStudentInfo);
            this.Controls.Add(this.panel1);
            this.Name = "ShowStudentInfo";
            this.Text = "ShowStudentInfo";
            this.Load += new System.EventHandler(this.ShowStudentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcStudentInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMarks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.TabControl tcStudentInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardian_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.DataGridView dgvStudentMarks;
        private System.Windows.Forms.Button btnShowMarks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.DataGridView dgvMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
    }
}