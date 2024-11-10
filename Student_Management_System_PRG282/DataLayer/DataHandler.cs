using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_Management_System_PRG282.DataLayer
{
    internal class DataHandler
    {
        string path = "students.txt"; // File path for storing student data
        string summaryPath = "summary.txt"; // File path for storing summary reports

        // Constructor: Ensures both student and summary files are created if missing
        public DataHandler()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose(); // Create student file if it doesn't exist
            }
            if (!File.Exists(summaryPath))
            {
                File.Create(summaryPath).Dispose(); // Create summary file if it doesn't exist
            }
        }

        // Adds a new student entry to the students file
        public void AddStudent(string studentID, string name, string lastName, int age, string course)
        {
            string newStudent = $"{studentID},{name},{lastName},{age},{course}"; // Format student info
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(newStudent); // Append new student data to file
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving the student data: " + ex.Message);
            }
        }

        // Reads all student entries from the file and returns them as a list of arrays
        public List<string[]> ViewStudents()
        {
            List<string[]> students = new List<string[]>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        students.Add(line.Split(',')); // Split each line by comma to separate fields
                    }
                }
            }
            return students;
        }

        // Removes a student from the file based on student ID
        public void RemoveStudent(string studentID)
        {
            var allStudents = File.ReadAllLines(path).ToList();
            var newStudents = allStudents.Where(line => line.Split(',')[0] != studentID).ToList();
            File.WriteAllLines(path, newStudents); // Overwrite file with updated student list
        }

        // Updates an existing student's info by ID
        public void UpdateStudent(string studentID, string firstName, string lastName, int age, string course)
        {
            var allStudents = File.ReadAllLines(path).ToList();
            for (int i = 0; i < allStudents.Count; i++)
            {
                var fields = allStudents[i].Split(',');
                if (fields[0] == studentID) // Find the student by ID
                {
                    allStudents[i] = $"{studentID},{firstName},{lastName},{age},{course}"; // Update details
                    break;
                }
            }
            File.WriteAllLines(path, allStudents); // Save updated data to file
        }

        // Generates a summary report, saves it to file, and returns total and average age of students
        public (int totalStudents, double averageAge) GenerateSummary()
        {
            var students = ViewStudents();
            int totalStudents = students.Count; // Count total students
            var ages = students.Select(s => int.TryParse(s[3], out int age) ? age : 0).ToList(); // Parse ages
            double averageAge = ages.Count > 0 ? ages.Average() : 0;

            // Count students per course
            var courseCounts = students.GroupBy(s => s[4])
                                       .Select(g => new { Course = g.Key, Count = g.Count() })
                                       .ToList();

            try
            {
                using (StreamWriter sw = new StreamWriter(summaryPath, false))
                {
                    // Write summary details to summary file
                    sw.WriteLine("Summary Report");
                    sw.WriteLine("===============");
                    sw.WriteLine($"Total Students: {totalStudents}");
                    sw.WriteLine($"Average Age: {averageAge:F2}");
                    sw.WriteLine();
                    sw.WriteLine("Students per Course:");
                    foreach (var course in courseCounts)
                    {
                        sw.WriteLine($"{course.Course}: {course.Count}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while generating the summary: " + ex.Message);
            }

            return (totalStudents, averageAge); // Return total students and average age
        }

        // Checks if a student with the given ID exists in the file
        public bool StudentExists(string studentID)
        {
            var allStudents = File.ReadAllLines(path);
            foreach (var student in allStudents)
            {
                var fields = student.Split(',');
                if (fields[0] == studentID) // Compare ID to each student ID
                {
                    return true; // Student exists
                }
            }
            return false; // No matching ID found
        }
    }
}
