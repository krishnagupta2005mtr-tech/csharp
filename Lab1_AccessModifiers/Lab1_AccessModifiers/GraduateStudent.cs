using System;

namespace Lab1_AccessModifiers
{
    public class GraduateStudent : Student
    {
        public void ShowData()
        {
            // ===== 1. Inheritance ke through access =====

            Console.WriteLine("Inheritance ke through:");

            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("CGPA       : " + CGPA);
            Console.WriteLine("College    : " + College);
            Console.WriteLine("Address    : " + Address);

            // Age private hai, isliye access nahi hoga
            // Console.WriteLine("Age : " + Age);


            // ===== 2. Student object ke through access =====

            Console.WriteLine("\nStudent object ke through:");

            Student s = new Student();

            Console.WriteLine("Name       : " + s.Name);

            // Age private hai
            // Console.WriteLine("Age : " + s.Age);

            // Department protected hai
            // Object ke through access nahi hoga
            // Console.WriteLine("Department : " + s.Department);

            // CGPA internal hai, same assembly mein accessible hai
            Console.WriteLine("CGPA       : " + s.CGPA);

            // protected internal - same assembly ki wajah se accessible
            Console.WriteLine("College    : " + s.College);

            // private protected - object ke through access nahi hoga
            // Console.WriteLine("Address : " + s.Address);
        }
    }
}