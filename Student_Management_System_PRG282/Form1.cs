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
            string course = txtCourse.Text;

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
                txtCourse.Clear();
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
            string course = txtCourse.Text;

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
                btnDisplayAllStudents_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the student: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;

            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please enter a Student ID.");
                return;
            }

            try
            {
                handler.RemoveStudent(studentID);
                MessageBox.Show("Student deleted successfully!");
                btnDisplayAllStudents_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
            }
        }
     
        private void btnDisplayAllStudents_Click(object sender, EventArgs e)
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
    }
}