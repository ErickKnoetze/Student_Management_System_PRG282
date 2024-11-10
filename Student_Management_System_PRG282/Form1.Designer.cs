using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System_PRG282
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.GroupBox groupStudentInfo;
        public System.Windows.Forms.GroupBox groupSummary;
        public System.Windows.Forms.Label labelStudentID;
        public System.Windows.Forms.TextBox txtStudentID;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label labelSurname;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.Label labelAge;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.Label labelCourse;
        public System.Windows.Forms.ComboBox comboBoxCourse;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Label labelTotalStudents;
        public System.Windows.Forms.Label labelAverageAge;
        public System.Windows.Forms.TextBox textBoxFilter;
        public System.Windows.Forms.ComboBox comboBoxFilterCourses;
        public System.Windows.Forms.Button buttonApplyFilter;
        public System.Windows.Forms.DataGridView dataGridView;


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupStudentInfo = new GroupBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            txtAge = new TextBox();
            comboBoxCourse = new ComboBox();
            labelStudentID = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelAge = new Label();
            labelCourse = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            groupSummary = new GroupBox();
            labelTotalStudents = new Label();
            labelAverageAge = new Label();
            textBoxFilter = new TextBox();
            comboBoxFilterCourses = new ComboBox();
            buttonApplyFilter = new Button();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupStudentInfo.SuspendLayout();
            groupSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupStudentInfo
            // 
            groupStudentInfo.Controls.Add(txtSurname);
            groupStudentInfo.Controls.Add(txtName);
            groupStudentInfo.Controls.Add(txtStudentID);
            groupStudentInfo.Controls.Add(txtAge);
            groupStudentInfo.Controls.Add(comboBoxCourse);
            groupStudentInfo.Controls.Add(labelStudentID);
            groupStudentInfo.Controls.Add(labelName);
            groupStudentInfo.Controls.Add(labelSurname);
            groupStudentInfo.Controls.Add(labelAge);
            groupStudentInfo.Controls.Add(labelCourse);
            groupStudentInfo.Controls.Add(buttonAdd);
            groupStudentInfo.Controls.Add(buttonUpdate);
            groupStudentInfo.Controls.Add(buttonDelete);
            groupStudentInfo.Font = new Font("Segoe UI", 10F);
            groupStudentInfo.Location = new Point(10, 10);
            groupStudentInfo.Name = "groupStudentInfo";
            groupStudentInfo.Size = new Size(258, 220);
            groupStudentInfo.TabIndex = 0;
            groupStudentInfo.TabStop = false;
            groupStudentInfo.Text = "Student Information";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Location = new Point(100, 82);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(140, 25);
            txtSurname.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(100, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 25);
            txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Location = new Point(100, 22);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(140, 25);
            txtStudentID.TabIndex = 2;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(100, 112);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(140, 25);
            txtAge.TabIndex = 3;
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourse.FlatStyle = FlatStyle.Flat;
            comboBoxCourse.Items.AddRange(new object[] { "Bachelor of Computing", "Bachelor of Information Technology", "Part-Time Bachelor of Information Technology",
                "Diploma in Information Technology", "Diploma for De af Students", "National Certificate: IT (Systems Development)", "Certificate: IT (Database Development)" });
            comboBoxCourse.Location = new Point(100, 142);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(140, 25);
            comboBoxCourse.TabIndex = 4;
            // 
            // labelStudentID
            // 
            labelStudentID.Font = new Font("Segoe UI", 10F);
            labelStudentID.Location = new Point(10, 25);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(100, 23);
            labelStudentID.TabIndex = 5;
            labelStudentID.Text = "Student ID:";
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(10, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 6;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.Font = new Font("Segoe UI", 10F);
            labelSurname.Location = new Point(10, 85);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(100, 23);
            labelSurname.TabIndex = 7;
            labelSurname.Text = "Surname:";
            // 
            // labelAge
            // 
            labelAge.Font = new Font("Segoe UI", 10F);
            labelAge.Location = new Point(10, 115);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(100, 23);
            labelAge.TabIndex = 8;
            labelAge.Text = "Age:";
            // 
            // labelCourse
            // 
            labelCourse.Font = new Font("Segoe UI", 10F);
            labelCourse.Location = new Point(10, 145);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(100, 23);
            labelCourse.TabIndex = 9;
            labelCourse.Text = "Course:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightGreen;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.Location = new Point(10, 180);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(65, 26);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightBlue;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F);
            buttonUpdate.Location = new Point(85, 180);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(65, 26);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.Location = new Point(160, 180);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(65, 26);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupSummary
            // 
            groupSummary.Controls.Add(labelTotalStudents);
            groupSummary.Controls.Add(labelAverageAge);
            groupSummary.Font = new Font("Segoe UI", 10F);
            groupSummary.Location = new Point(290, 15);
            groupSummary.Name = "groupSummary";
            groupSummary.Size = new Size(143, 70);
            groupSummary.TabIndex = 1;
            groupSummary.TabStop = false;
            groupSummary.Text = "Summary";
            // 
            // labelTotalStudents
            // 
            labelTotalStudents.Font = new Font("Segoe UI", 10F);
            labelTotalStudents.Location = new Point(6, 20);
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.Size = new Size(100, 23);
            labelTotalStudents.TabIndex = 0;
            labelTotalStudents.Text = "Total Students: 0";
            // 
            // labelAverageAge
            // 
            labelAverageAge.Font = new Font("Segoe UI", 10F);
            labelAverageAge.Location = new Point(6, 43);
            labelAverageAge.Name = "labelAverageAge";
            labelAverageAge.Size = new Size(100, 23);
            labelAverageAge.TabIndex = 1;
            labelAverageAge.Text = "Average Age: 0";
            // 
            // textBoxFilter
            // 
            textBoxFilter.BorderStyle = BorderStyle.FixedSingle;
            textBoxFilter.Location = new Point(10, 240);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(115, 23);
            textBoxFilter.TabIndex = 2;
            // 
            // comboBoxFilterCourses
            // 
            comboBoxFilterCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterCourses.FlatStyle = FlatStyle.Flat;
            comboBoxFilterCourses.Items.AddRange(new object[] { "All Courses", "Bachelor of Computing", "Bachelor of Information Technology", "Part-Time Bachelor of Information Technology",
                "Diploma in Information Technology", "Diploma for Deaf Students", "National Certificate: IT (Systems Development)", "Certificate: IT (Database Development)"});
            comboBoxFilterCourses.Location = new Point(130, 240);
            comboBoxFilterCourses.Name = "comboBoxFilterCourses";
            comboBoxFilterCourses.Size = new Size(115, 23);
            comboBoxFilterCourses.TabIndex = 3;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.Location = new Point(250, 240);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(85, 23);
            buttonApplyFilter.TabIndex = 4;
            buttonApplyFilter.Text = "Apply Filter";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.LightGray;
            dataGridView.Location = new Point(10, 270);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(580, 300);
            dataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Surname";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Age";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Course";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            ClientSize = new Size(600, 600);
            Controls.Add(groupStudentInfo);
            Controls.Add(groupSummary);
            Controls.Add(textBoxFilter);
            Controls.Add(comboBoxFilterCourses);
            Controls.Add(buttonApplyFilter);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Student Management System";
            groupStudentInfo.ResumeLayout(false);
            groupStudentInfo.PerformLayout();
            groupSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
            txtName.Text = "";
        }

        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}