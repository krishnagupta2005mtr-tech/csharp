using System;

namespace Q3_EmployeeBonus
{
    class Employee
    {
        public string Name { get; set; }

        public double BasicSalary { get; set; }

        public int Experience { get; set; }

        public double Bonus
        {
            get
            {
                if (Experience >= 10)
                {
                    return BasicSalary * 20 / 100;
                }
                else if (Experience >= 5)
                {
                    return BasicSalary * 10 / 100;
                }
                else
                {
                    return BasicSalary * 5 / 100;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Rahul";
            employee.BasicSalary = 50000;
            employee.Experience = 6;

            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Basic Salary: " + employee.BasicSalary);
            Console.WriteLine("Experience: " + employee.Experience + " years");
            Console.WriteLine("Bonus: " + employee.Bonus);

            Console.ReadKey();
        }
    }
}