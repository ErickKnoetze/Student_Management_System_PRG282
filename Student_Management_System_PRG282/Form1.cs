using System.Xml.Linq;

namespace Student_Management_System_PRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView if they aren't already added
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("StudentID", "Student ID");
                dataGridView.Columns.Add("Name", "Name");
                dataGridView.Columns.Add("Surname", "Surname");
                dataGridView.Columns.Add("Age", "Age");
                dataGridView.Columns.Add("Course", "Course");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandeler dataHandler = new DataHandeler();
                
                // Validate age input
                if (!int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid age", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Student newStudent = dataHandler.CreateNewStudent(
                    txtStudentID.Text,
                    txtName.Text,
                    txtSurname.Text,
                    age,
                    comboBoxCourse.Text
                );

                // Save the student
                dataHandler.SaveStudent(newStudent);

                MessageBox.Show("Student added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form after successful addition
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to clear the form
        private void ClearForm()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            comboBoxCourse.SelectedIndex = -1;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        public string StudentID
        {
            get { return txtStudentID.Text; }
            set { txtStudentID.Text = value; }
        }

        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Surname
        {
            get { return txtSurname.Text; }
            set { txtSurname.Text = value; }
        }

        public string Age
        {
            get { return txtAge.Text; }
            set { txtAge.Text = value; }
        }

        public string Course
        {
            get { return comboBoxCourse.Text; }
            set { comboBoxCourse.Text = value; }
        }
    }

}