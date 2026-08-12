using System;

namespace Lab1_AccessModifiers
{
    public class TestStudent
    {
        public void Test()
        {
            Student s = new Student();

            Console.WriteLine(s.Name);       // Accessible
            // Console.WriteLine(s.Age);    // ERROR
            // Console.WriteLine(s.Department); // ERROR
            Console.WriteLine(s.CGPA);       // Accessible
            Console.WriteLine(s.College);    // Accessible
            // Console.WriteLine(s.Address); // ERROR
        }
    }
}