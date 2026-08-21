using System;

namespace Q6_StudentRecord
{
    public record Student(
        int RollNumber,
        string Name,
        string Course,
        int Semester);

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 =
                new Student(101, "Krishna", "MCA", 2);

            Student student2 =
                new Student(101, "Krishna", "MCA", 2);

            Console.WriteLine("Student 1:");
            Console.WriteLine(student1);

            Console.WriteLine("\nStudent 2:");
            Console.WriteLine(student2);

            Console.WriteLine("\nAre both students equal?");
            Console.WriteLine(student1 == student2);

            Console.ReadKey();
        }
    }
}