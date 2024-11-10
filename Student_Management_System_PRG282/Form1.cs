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


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Retrieve input from the form fields using properties
            string studentID = this.StudentID;
            string name = this.Name;
            string surname = this.Surname;
            string age = this.Age;
            string course = this.Course;

            // Check if all fields are filled out
            if (!string.IsNullOrEmpty(studentID) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname)
                && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(course))
            {
                try
                {
                    // Append student details to the students.txt file
                    using (StreamWriter sw = new StreamWriter("students.txt", true))
                    {
                        sw.WriteLine($"{studentID},{name},{surname},{age},{course}");
                    }

                    // Show success message
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after adding
                    ClearFields();
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show($"Failed to add student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show warning message if any field is empty
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            comboBoxFilterCourses.SelectedIndex = -1; // Reset course selection
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