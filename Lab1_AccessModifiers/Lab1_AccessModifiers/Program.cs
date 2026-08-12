using System;

namespace Lab1_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.Display();
            GraduateStudent g = new GraduateStudent();

            g.ShowData();

            Console.ReadKey();
        }
    }
}