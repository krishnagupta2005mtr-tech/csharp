using System;
using StudentLibrary;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Name: " + s.Name);

            // Ye sab ERROR denge:

            // Console.WriteLine("Age: " + s.Age);
            // Console.WriteLine("Department: " + s.Department);
            // Console.WriteLine("CGPA: " + s.CGPA);
            // Console.WriteLine("College: " + s.College);
            // Console.WriteLine("Address: " + s.Address);

            Console.ReadKey();
        }
    }
}