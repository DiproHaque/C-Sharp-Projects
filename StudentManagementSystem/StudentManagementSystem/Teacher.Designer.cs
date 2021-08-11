
namespace StudentManagementSystem
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcTeacherInset = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.btnSubmitTeacherInfo = new System.Windows.Forms.Button();
            this.txtPasswordTeacher = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTeacherSalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpJoinTeacher = new System.Windows.Forms.DateTimePicker();
            this.txtInputTeacherId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTeacherEmail = new System.Windows.Forms.TextBox();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.txtTeacherNumber = new System.Windows.Forms.TextBox();
            this.txtTeacherAge = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTeacherSearch = new System.Windows.Forms.Button();
            this.btnAllInfo = new System.Windows.Forms.Button();
            this.txtInsertIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_joindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tcTeacherInset.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcTeacherInset);
            this.panel1.Location = new System.Drawing.Point(32, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 517);
            this.panel1.TabIndex = 0;
            // 
            // tcTeacherInset
            // 
            this.tcTeacherInset.Controls.Add(this.tabPage1);
            this.tcTeacherInset.Controls.Add(this.tabPage2);
            this.tcTeacherInset.Location = new System.Drawing.Point(17, 12);
            this.tcTeacherInset.Name = "tcTeacherInset";
            this.tcTeacherInset.SelectedIndex = 0;
            this.tcTeacherInset.Size = new System.Drawing.Size(1005, 474);
            this.tcTeacherInset.TabIndex = 1;
            this.tcTeacherInset.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.pnlStudentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentInfo.Controls.Add(this.btnSubmitTeacherInfo);
            this.pnlStudentInfo.Controls.Add(this.txtPasswordTeacher);
            this.pnlStudentInfo.Controls.Add(this.label17);
            this.pnlStudentInfo.Controls.Add(this.label14);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherSalary);
            this.pnlStudentInfo.Controls.Add(this.label12);
            this.pnlStudentInfo.Controls.Add(this.dtpJoinTeacher);
            this.pnlStudentInfo.Controls.Add(this.txtInputTeacherId);
            this.pnlStudentInfo.Controls.Add(this.label16);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherEmail);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherAddress);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherNumber);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherAge);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherName);
            this.pnlStudentInfo.Controls.Add(this.label7);
            this.pnlStudentInfo.Controls.Add(this.label6);
            this.pnlStudentInfo.Controls.Add(this.label5);
            this.pnlStudentInfo.Controls.Add(this.label9);
            this.pnlStudentInfo.Controls.Add(this.label10);
            this.pnlStudentInfo.Controls.Add(this.label11);
            this.pnlStudentInfo.Location = new System.Drawing.Point(37, 20);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(1001, 441);
            this.pnlStudentInfo.TabIndex = 2;
            // 
            // btnSubmitTeacherInfo
            // 
            this.btnSubmitTeacherInfo.Location = new System.Drawing.Point(701, 338);
            this.btnSubmitTeacherInfo.Name = "btnSubmitTeacherInfo";
            this.btnSubmitTeacherInfo.Size = new System.Drawing.Size(75, 40);
            this.btnSubmitTeacherInfo.TabIndex = 33;
            this.btnSubmitTeacherInfo.Text = "Submit";
            this.btnSubmitTeacherInfo.UseVisualStyleBackColor = true;
            this.btnSubmitTeacherInfo.Click += new System.EventHandler(this.btnSubmitTeacherInfo_Click);
            // 
            // txtPasswordTeacher
            // 
            this.txtPasswordTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordTeacher.Location = new System.Drawing.Point(597, 191);
            this.txtPasswordTeacher.Name = "txtPasswordTeacher";
            this.txtPasswordTeacher.Size = new System.Drawing.Size(121, 26);
            this.txtPasswordTeacher.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Location = new System.Drawing.Point(480, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label14.Location = new System.Drawing.Point(475, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Salary :";
            // 
            // txtTeacherSalary
            // 
            this.txtTeacherSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherSalary.Location = new System.Drawing.Point(597, 54);
            this.txtTeacherSalary.Name = "txtTeacherSalary";
            this.txtTeacherSalary.Size = new System.Drawing.Size(121, 26);
            this.txtTeacherSalary.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Location = new System.Drawing.Point(475, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Join Date:";
            // 
            // dtpJoinTeacher
            // 
            this.dtpJoinTeacher.CustomFormat = "yyyy-MM-dd";
            this.dtpJoinTeacher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoinTeacher.Location = new System.Drawing.Point(597, 115);
            this.dtpJoinTeacher.Name = "dtpJoinTeacher";
            this.dtpJoinTeacher.Size = new System.Drawing.Size(304, 22);
            this.dtpJoinTeacher.TabIndex = 27;
            // 
            // txtInputTeacherId
            // 
            this.txtInputTeacherId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInputTeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTeacherId.Location = new System.Drawing.Point(97, 47);
            this.txtInputTeacherId.Name = "txtInputTeacherId";
            this.txtInputTeacherId.ReadOnly = true;
            this.txtInputTeacherId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInputTeacherId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputTeacherId.Size = new System.Drawing.Size(165, 30);
            this.txtInputTeacherId.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label16.Location = new System.Drawing.Point(7, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "ID :";
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherEmail.Location = new System.Drawing.Point(97, 225);
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Size = new System.Drawing.Size(339, 30);
            this.txtTeacherEmail.TabIndex = 12;
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTeacherAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherAddress.Location = new System.Drawing.Point(99, 286);
            this.txtTeacherAddress.Multiline = true;
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTeacherAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTeacherAddress.Size = new System.Drawing.Size(339, 79);
            this.txtTeacherAddress.TabIndex = 10;
            // 
            // txtTeacherNumber
            // 
            this.txtTeacherNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTeacherNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherNumber.Location = new System.Drawing.Point(99, 159);
            this.txtTeacherNumber.Name = "txtTeacherNumber";
            this.txtTeacherNumber.Size = new System.Drawing.Size(190, 30);
            this.txtTeacherNumber.TabIndex = 9;
            // 
            // txtTeacherAge
            // 
            this.txtTeacherAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTeacherAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherAge.Location = new System.Drawing.Point(355, 31);
            this.txtTeacherAge.Name = "txtTeacherAge";
            this.txtTeacherAge.Size = new System.Drawing.Size(75, 30);
            this.txtTeacherAge.TabIndex = 7;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(97, 98);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTeacherName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTeacherName.Size = new System.Drawing.Size(191, 30);
            this.txtTeacherName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(296, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(3, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(7, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Student\'s Personal Information";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Sienna;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvTeacherInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(32, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 111);
            this.panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Adding";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(151, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.AllowUserToAddRows = false;
            this.dgvTeacherInfo.AllowUserToDeleteRows = false;
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacher_id,
            this.teacher_name,
            this.teacher_email,
            this.teacher_number,
            this.teacher_salary,
            this.teacher_joindate,
            this.teacher_password});
            this.dgvTeacherInfo.Location = new System.Drawing.Point(130, 175);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.ReadOnly = true;
            this.dgvTeacherInfo.RowHeadersWidth = 51;
            this.dgvTeacherInfo.RowTemplate.Height = 24;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(726, 227);
            this.dgvTeacherInfo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtInsertIDSearch);
            this.panel3.Controls.Add(this.btnAllInfo);
            this.panel3.Controls.Add(this.btnTeacherSearch);
            this.panel3.Location = new System.Drawing.Point(107, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnTeacherSearch
            // 
            this.btnTeacherSearch.Location = new System.Drawing.Point(450, 44);
            this.btnTeacherSearch.Name = "btnTeacherSearch";
            this.btnTeacherSearch.Size = new System.Drawing.Size(75, 40);
            this.btnTeacherSearch.TabIndex = 36;
            this.btnTeacherSearch.Text = "Search";
            this.btnTeacherSearch.UseVisualStyleBackColor = true;
            this.btnTeacherSearch.Click += new System.EventHandler(this.btnTeacherSearch_Click);
            // 
            // btnAllInfo
            // 
            this.btnAllInfo.Location = new System.Drawing.Point(694, 44);
            this.btnAllInfo.Name = "btnAllInfo";
            this.btnAllInfo.Size = new System.Drawing.Size(75, 40);
            this.btnAllInfo.TabIndex = 37;
            this.btnAllInfo.Text = "All Info";
            this.btnAllInfo.UseVisualStyleBackColor = true;
            this.btnAllInfo.Click += new System.EventHandler(this.btnAllInfo_Click);
            // 
            // txtInsertIDSearch
            // 
            this.txtInsertIDSearch.Location = new System.Drawing.Point(298, 53);
            this.txtInsertIDSearch.Name = "txtInsertIDSearch";
            this.txtInsertIDSearch.Size = new System.Drawing.Size(100, 22);
            this.txtInsertIDSearch.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(137, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Enter Teacher ID";
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
            // teacher_name
            // 
            this.teacher_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.MinimumWidth = 6;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // teacher_email
            // 
            this.teacher_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_email.DataPropertyName = "teacher_email";
            this.teacher_email.HeaderText = "Mail";
            this.teacher_email.MinimumWidth = 6;
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.ReadOnly = true;
            // 
            // teacher_number
            // 
            this.teacher_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_number.DataPropertyName = "teacher_number";
            this.teacher_number.HeaderText = "Number";
            this.teacher_number.MinimumWidth = 6;
            this.teacher_number.Name = "teacher_number";
            this.teacher_number.ReadOnly = true;
            // 
            // teacher_salary
            // 
            this.teacher_salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_salary.DataPropertyName = "teacher_salary";
            this.teacher_salary.HeaderText = "Salary";
            this.teacher_salary.MinimumWidth = 6;
            this.teacher_salary.Name = "teacher_salary";
            this.teacher_salary.ReadOnly = true;
            // 
            // teacher_joindate
            // 
            this.teacher_joindate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_joindate.DataPropertyName = "teacher_joindate";
            this.teacher_joindate.HeaderText = "Join Date";
            this.teacher_joindate.MinimumWidth = 6;
            this.teacher_joindate.Name = "teacher_joindate";
            this.teacher_joindate.ReadOnly = true;
            // 
            // teacher_password
            // 
            this.teacher_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_password.DataPropertyName = "teacher_password";
            this.teacher_password.HeaderText = "User Password";
            this.teacher_password.MinimumWidth = 6;
            this.teacher_password.Name = "teacher_password";
            this.teacher_password.ReadOnly = true;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.panel1.ResumeLayout(false);
            this.tcTeacherInset.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcTeacherInset;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.Button btnSubmitTeacherInfo;
        private System.Windows.Forms.TextBox txtPasswordTeacher;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTeacherSalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpJoinTeacher;
        private System.Windows.Forms.TextBox txtInputTeacherId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTeacherEmail;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.TextBox txtTeacherNumber;
        private System.Windows.Forms.TextBox txtTeacherAge;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertIDSearch;
        private System.Windows.Forms.Button btnAllInfo;
        private System.Windows.Forms.Button btnTeacherSearch;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_joindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_password;
    }
}