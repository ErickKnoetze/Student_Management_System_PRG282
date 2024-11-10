using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System_PRG282
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.GroupBox groupStudentInfo;
        private System.Windows.Forms.GroupBox groupSummary;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonReset;


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupStudentInfo = new GroupBox();
            comboBoxCourse = new ComboBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            txtAge = new TextBox();
            labelStudentID = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelAge = new Label();
            labelCourse = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            groupSummary = new GroupBox();
            btnSumamry = new Button();
            txtAverageAge = new TextBox();
            txtTotalStudent = new TextBox();
            lblAverage = new Label();
            lblTotal = new Label();
            dataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupStudentInfo.SuspendLayout();
            groupSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupSearch = new GroupBox();
            txtSearch = new TextBox();
            labelSearch = new Label();
            comboBoxFilter = new ComboBox();
            labelFilter = new Label();
            buttonReset = new Button();
            groupSearch.SuspendLayout();
            SuspendLayout();
            // 
            // groupStudentInfo
            // 
            groupStudentInfo.Controls.Add(comboBoxCourse);
            groupStudentInfo.Controls.Add(txtSurname);
            groupStudentInfo.Controls.Add(txtName);
            groupStudentInfo.Controls.Add(txtStudentID);
            groupStudentInfo.Controls.Add(txtAge);
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
            groupStudentInfo.Size = new Size(273, 220);
            groupStudentInfo.TabIndex = 0;
            groupStudentInfo.TabStop = false;
            groupStudentInfo.Text = "Student Information";
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourse.FlatStyle = FlatStyle.Flat;
            comboBoxCourse.Items.AddRange(new object[] { "Bachelor of Computing", "Bachelor of Information Technology", "Part-Time Bachelor of Information Technology", "Diploma in Information Technology", "Diploma for De af Students", "National Certificate: IT (Systems Development)", "Certificate: IT (Database Development)" });
            comboBoxCourse.Location = new Point(100, 142);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(140, 25);
            comboBoxCourse.TabIndex = 4;
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
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(100, 112);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(140, 25);
            txtAge.TabIndex = 3;
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
            buttonAdd.Size = new Size(74, 34);
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
            buttonUpdate.Location = new Point(90, 180);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(78, 34);
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
            buttonDelete.Location = new Point(183, 180);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 34);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupSummary
            // 
            groupSummary.Controls.Add(btnSumamry);
            groupSummary.Controls.Add(txtAverageAge);
            groupSummary.Controls.Add(txtTotalStudent);
            groupSummary.Controls.Add(lblAverage);
            groupSummary.Controls.Add(lblTotal);
            groupSummary.Font = new Font("Segoe UI", 10F);
            groupSummary.Location = new Point(378, 10);
            groupSummary.Name = "groupSummary";
            groupSummary.Size = new Size(308, 161);
            groupSummary.TabIndex = 1;
            groupSummary.TabStop = false;
            groupSummary.Text = "Summary";
            // 
            // btnSumamry
            // 
            btnSumamry.Location = new Point(101, 103);
            btnSumamry.Name = "btnSumamry";
            btnSumamry.Size = new Size(107, 44);
            btnSumamry.TabIndex = 6;
            btnSumamry.Text = "Summary";
            btnSumamry.UseVisualStyleBackColor = true;
            btnSumamry.Click += btnSumamry_Click;
            // 
            // txtAverageAge
            // 
            txtAverageAge.Location = new Point(145, 55);
            txtAverageAge.Name = "txtAverageAge";
            txtAverageAge.Size = new Size(125, 25);
            txtAverageAge.TabIndex = 5;
            // 
            // txtTotalStudent
            // 
            txtTotalStudent.Location = new Point(145, 22);
            txtTotalStudent.Name = "txtTotalStudent";
            txtTotalStudent.Size = new Size(125, 25);
            txtTotalStudent.TabIndex = 4;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(13, 58);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(94, 19);
            lblAverage.TabIndex = 3;
            lblAverage.Text = "Average Age: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 26);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(103, 19);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Students: ";
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
            dataGridView.ColumnHeadersHeight = 29;
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
            dataGridView.Location = new Point(8, 236);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(861, 310);
            dataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Surname";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Age";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Course";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupSearch
            // 
            groupSearch.Controls.Add(comboBoxFilter);
            groupSearch.Controls.Add(txtSearch);
            groupSearch.Controls.Add(labelSearch);
            groupSearch.Controls.Add(labelFilter);
            groupSearch.Controls.Add(buttonReset);
            groupSearch.Font = new Font("Segoe UI", 10F);
            groupSearch.Location = new Point(692, 10);
            groupSearch.Name = "groupSearch";
            groupSearch.Size = new Size(177, 161);
            groupSearch.TabIndex = 2;
            groupSearch.TabStop = false;
            groupSearch.Text = "Search & Filter";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(10, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(157, 25);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(10, 23);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(100, 19);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search by ID:";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FlatStyle = FlatStyle.Flat;
            comboBoxFilter.Location = new Point(10, 95);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(157, 25);
            comboBoxFilter.TabIndex = 2;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(10, 73);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(100, 19);
            labelFilter.TabIndex = 3;
            labelFilter.Text = "Filter by Course:";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.LightGray;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(10, 125);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(157, 30);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(881, 558);
            Controls.Add(groupStudentInfo);
            Controls.Add(groupSummary);
            Controls.Add(dataGridView);
            Controls.Add(groupSearch);
            Name = "Form1";
            Text = "Student Management System";
            groupStudentInfo.ResumeLayout(false);
            groupStudentInfo.PerformLayout();
            groupSummary.ResumeLayout(false);
            groupSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupSearch.ResumeLayout(false);
            groupSearch.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lblAverage;
        private Label lblTotal;
        private TextBox txtAverageAge;
        private TextBox txtTotalStudent;
        private Button btnSumamry;

    }
}
