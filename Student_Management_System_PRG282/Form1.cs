using Student_Management_System_PRG282.DataLayer;
using System.Xml.Linq;
using System.IO;

namespace Student_Management_System_PRG282
{
    public partial class Form1 : Form
    {
        DataHandler handler = new DataHandler();

        public Form1()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            // Subscribe to the SelectionChanged event
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            
            // Load students when the form starts
            LoadStudents();
        }

        // New method to load students into DataGridView
        private void LoadStudents()
        {
            dataGridView.Rows.Clear();
            var students = handler.ViewStudents();

            foreach (var student in students)
            {
                if (student.Length == 5)
                {
                    dataGridView.Rows.Add(student[0], student[1], student[2], student[3], student[4]);
                }
            }

            // Clear all the textboxes
            txtStudentID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            comboBoxCourse.SelectedIndex = -1;
        }

        private void btnDisplayFromTextFile_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string age = txtAge.Text;
            string course = comboBoxCourse.Text;

            if (string.IsNullOrWhiteSpace(studentID) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(age) ||
                string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(age, out int Age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            if (handler.StudentExists(studentID))
            {
                MessageBox.Show("A student with this ID already exists.");
                return;
            }

            try
            {
                handler.AddStudent(studentID, firstName, lastName, Age, course);
                MessageBox.Show("Student added successfully!");

                txtStudentID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtAge.Clear();
                comboBoxCourse.SelectedIndex = -1;

                // Update to use LoadStudents()
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string ageText = txtAge.Text;
            string course = comboBoxCourse.Text;

            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            try
            {
                handler.UpdateStudent(studentID, firstName, lastName, age, course);
                MessageBox.Show("Student updated successfully!");
                LoadStudents(); // Update to use LoadStudents()
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the student: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            // Get the student ID from the selected row
            string studentID = dataGridView.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;

            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                try
                {
                    handler.RemoveStudent(studentID);
                    MessageBox.Show("Student deleted successfully!");
                    LoadStudents(); // Update to use LoadStudents()
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
                }
            }
        }

        // Generate and display summary when the Summary button is clicked
        private void btnSumamry_Click(object sender, EventArgs e)
        {
            try
            {
                var (totalStudents, averageAge) = handler.GenerateSummary();

             
                txtTotalStudent.Text = totalStudents.ToString();
                txtAverageAge.Text = averageAge.ToString("F2");

                MessageBox.Show("Summary generated successfully! Check summary.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the summary: " + ex.Message);
            }
        }

        // Add this method to handle the DataGridView selection changed event
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                
                // Populate text boxes with the selected student's data
                txtStudentID.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtSurname.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtAge.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                comboBoxCourse.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            }
        }
    }
}