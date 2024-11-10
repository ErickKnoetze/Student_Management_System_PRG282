using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_PRG282.DataLayer
{
    internal class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Course { get; set; }

        public Students(int studentID, string name, string lastName, string age, string course)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Course = course;
        }
    }
}
