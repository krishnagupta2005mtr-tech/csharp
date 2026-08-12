using System;
using StudentLibrary;

namespace StudentClient
{
    public class ResearchStudent : Student
    {
        public void ShowData()
        {
            Console.WriteLine(Name);        // YES

            // Console.WriteLine(Age);     // ERROR

            Console.WriteLine(Department);  // YES

            // Console.WriteLine(CGPA);    // ERROR

            Console.WriteLine(College);     // YES

            // Console.WriteLine(Address); // ERROR
        }
    }
}