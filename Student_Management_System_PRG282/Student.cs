using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_PRG282
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string studentID, string name, string surname, int age, string course)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Age = age;
            Course = course;
        }
    }
}
