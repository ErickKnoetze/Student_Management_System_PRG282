using Student_Management_System_PRG282.DataLayer;
using System.Xml.Linq;
using System.IO;

namespace Student_Management_System_PRG282
{
    public partial class Form1 : Form
    {
        DataHandler handler = new DataHandler(); // Manages student data interactions

        public Form1()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            LoadStudents(); // Load and display students on form load
            LoadFilterComboBox(); // Populate filter options for courses
        }

        // Clears the DataGridView and reloads it with current student data
        private void LoadStudents()
        {
            dataGridView.Rows.Clear();
            var students = handler.ViewStudents();

            foreach (var student in students)
            {
                if (student.Length == 5) // Ensure complete student data
                {
                    dataGridView.Rows.Add(student[0], student[1], student[2], student[3], student[4]);
                }
            }

            // Clear all input fields after loading data
            txtStudentID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            comboBoxCourse.SelectedIndex = -1;
        }

        private void btnDisplayFromTextFile_Click(object sender, EventArgs e)
        {
            // Placeholder for a function to display data from a text file (if needed)
        }

        // Adds a new student entry after validating input fields
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string age = txtAge.Text;
            string course = comboBoxCourse.Text;

            // Ensure all fields are filled before adding
            if (string.IsNullOrWhiteSpace(studentID) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(age) ||
                string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate age input
            if (!int.TryParse(age, out int Age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            // Check for unique student ID
            if (handler.StudentExists(studentID))
            {
                MessageBox.Show("A student with this ID already exists.");
                return;
            }

            try
            {
                handler.AddStudent(studentID, firstName, lastName, Age, course); // Add new student to data file
                MessageBox.Show("Student added successfully!");

                // Clear input fields and reload updated data
                txtStudentID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtAge.Clear();
                comboBoxCourse.SelectedIndex = -1;

                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Updates student details if they already exist in the system
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string ageText = txtAge.Text;
            string course = comboBoxCourse.Text;

            // Validate all input fields
            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Ensure age is a valid number
            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            try
            {
                handler.UpdateStudent(studentID, firstName, lastName, age, course); // Update student data
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the student: " + ex.Message);
            }
        }

        // Deletes a selected student after confirmation
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            // Get student ID from selected row
            string studentID = dataGridView.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;

            // Confirm deletion action
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    handler.RemoveStudent(studentID); // Remove student from data file
                    MessageBox.Show("Student deleted successfully!");
                    LoadStudents(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
                }
            }
        }

        // Generates a summary report and displays total and average age
        private void btnSumamry_Click(object sender, EventArgs e)
        {
            try
            {
                var (totalStudents, averageAge) = handler.GenerateSummary();

                // Display summary data
                txtTotalStudent.Text = totalStudents.ToString();
                txtAverageAge.Text = averageAge.ToString("F2");

                MessageBox.Show("Summary generated successfully! Check summary.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the summary: " + ex.Message);
            }
        }

        // Populates text fields with data from the selected row in DataGridView
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                txtStudentID.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtSurname.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtAge.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                comboBoxCourse.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            }
        }

        // Initializes course filter options in the combo box
        private void LoadFilterComboBox()
        {
            comboBoxFilter.Items.Add("All Courses"); // Default filter option

            // Add each available course to the filter
            foreach (var item in comboBoxCourse.Items)
            {
                comboBoxFilter.Items.Add(item);
            }

            comboBoxFilter.SelectedIndex = 0; // Set default selection to "All Courses"
        }

        // Filters students by ID and course selection as user types in search box
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            
            if (string.IsNullOrEmpty(searchText))
            {
                ApplyCourseFilter(); // Apply course filter if search box is empty
                return;
            }

            string selectedCourse = comboBoxFilter.SelectedItem.ToString();

            // Display only rows that match search criteria
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                bool idMatch = row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString()
                    .Contains(searchText, StringComparison.OrdinalIgnoreCase) ?? false;
                
                bool courseMatch = selectedCourse == "All Courses" || 
                    row.Cells["dataGridViewTextBoxColumn5"].Value?.ToString() == selectedCourse;

                row.Visible = idMatch && courseMatch;
            }
        }

        // Applies selected course filter
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCourseFilter();
        }

        // Filters students based on course and ID input, updating row visibility
        private void ApplyCourseFilter()
        {
            string selectedCourse = comboBoxFilter.SelectedItem?.ToString() ?? "All Courses";
            string searchText = txtSearch.Text.Trim();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                bool courseMatch = selectedCourse == "All Courses" || 
                    row.Cells["dataGridViewTextBoxColumn5"].Value?.ToString() == selectedCourse;
                
                bool idMatch = string.IsNullOrEmpty(searchText) || 
                    (row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString()
                        ?.Contains(searchText, StringComparison.OrdinalIgnoreCase) ?? false);

                row.Visible = courseMatch && idMatch;
            }
        }

        // Resets the search and filter fields, displaying all students
        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            comboBoxFilter.SelectedIndex = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
