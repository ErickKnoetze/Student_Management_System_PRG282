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
        string path = "students.txt";
        string summaryPath = "summary.txt";

        // Constructor to ensure files exist
        public DataHandler()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            if (!File.Exists(summaryPath))
            {
                File.Create(summaryPath).Dispose();
            }
        }

        public void AddStudent(string studentID, string name, string lastName, int age, string course)
        {
            string newStudent = $"{studentID},{name},{lastName},{age},{course}";
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(newStudent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving the student data: " + ex.Message);
            }
        }

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
                        students.Add(line.Split(','));
                    }
                }
            }
            return students;
        }

        public void RemoveStudent(string studentID)
        {
            var allStudents = File.ReadAllLines(path).ToList();
            var newStudents = allStudents.Where(line => line.Split(',')[0] != studentID).ToList();
            File.WriteAllLines(path, newStudents);
        }

        public void UpdateStudent(string studentID, string firstName, string lastName, int age, string course)
        {
            var allStudents = File.ReadAllLines(path).ToList();
            for (int i = 0; i < allStudents.Count; i++)
            {
                var fields = allStudents[i].Split(',');
                if (fields[0] == studentID)
                {
                    allStudents[i] = $"{studentID},{firstName},{lastName},{age},{course}";
                    break;
                }
            }
            File.WriteAllLines(path, allStudents);
        }

        // Generate summary report, save to summary.txt, and return total and average age
        public (int totalStudents, double averageAge) GenerateSummary()
        {
            var students = ViewStudents();
            int totalStudents = students.Count;
            var ages = students.Select(s => int.TryParse(s[3], out int age) ? age : 0).ToList();
            double averageAge = ages.Count > 0 ? ages.Average() : 0;

            var courseCounts = students.GroupBy(s => s[4]) // Group by course
                                       .Select(g => new { Course = g.Key, Count = g.Count() })
                                       .ToList();

            try
            {
                using (StreamWriter sw = new StreamWriter(summaryPath, false))
                {
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

            return (totalStudents, averageAge); // Return both values
        }
        public bool StudentExists(string studentID)
        {
            var allStudents = File.ReadAllLines(path);
            foreach (var student in allStudents)
            {
                var fields = student.Split(',');
                if (fields[0] == studentID) // assuming the ID is the first field
                {
                    return true;
                }
            }
            return false;
        }
    }
}