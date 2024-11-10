using System;
using System.IO;

namespace Student_Management_System_PRG282
{
    internal class DataHandeler
    {
        public Student CreateNewStudent(string studentID, string name, string surname, 
            int age, string course)
        {
            try
            {
                Student newStudent = new Student(
                    studentID,
                    name,
                    surname,
                    age,
                    course
                );

                return newStudent;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating student: {ex.Message}");
            }
        }

        public void SaveStudent(Student student)
        {
            try
            {
                string studentData = $"{student.StudentID},{student.Name},{student.Surname}," +
                    $"{student.Age},{student.Course}";

                File.AppendAllText("students.txt", studentData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving student: {ex.Message}");
            }
        }
    }
}

