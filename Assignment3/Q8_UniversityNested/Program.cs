using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_UniversityNested
{
    internal class Program
    {
        static void Main(string[] args)using System;

namespace Q8_UniversityNested
    {
        class University
        {
            public class Department
            {
                public string DepartmentName { get; set; }
                public string HODName { get; set; }
                public int FacultyMembers { get; set; }

                public void DisplayDepartment()
                {
                    Console.WriteLine("Department: " + DepartmentName);
                    Console.WriteLine("HOD: " + HODName);
                    Console.WriteLine(
                        "Faculty Members: " + FacultyMembers);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                University.Department department =
                    new University.Department();

                department.DepartmentName = "Computer Science";
                department.HODName = "Dr. Sharma";
                department.FacultyMembers = 15;

                department.DisplayDepartment();

                Console.ReadKey();
            }
        }
    }
        {
        }
    }
}
