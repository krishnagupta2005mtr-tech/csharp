using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AccessModifiers
{
    public class Student
    {
        public string Name = "Krishna";

        private int Age = 22;

        protected string Department = "MCA";

        internal double CGPA = 8.5;

        protected internal string College = "GLA University";

        private protected string Address = "Mathura";

        public void Display()
        {
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("CGPA       : " + CGPA);
            Console.WriteLine("College    : " + College);
            Console.WriteLine("Address    : " + Address);
        }
    }
}
