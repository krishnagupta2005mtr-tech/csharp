using System;

namespace Q7_EmployeePayroll
{
    class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public double BasicSalary { get; set; }

        public double HRA
        {
            get
            {
                return BasicSalary * 20 / 100;
            }
        }

        public double DA
        {
            get
            {
                return BasicSalary * 10 / 100;
            }
        }

        public double GrossSalary
        {
            get
            {
                return BasicSalary + HRA + DA;
            }
        }

        public double Tax
        {
            get
            {
                if (GrossSalary > 100000)
                {
                    return GrossSalary * 20 / 100;
                }
                else if (GrossSalary > 50000)
                {
                    return GrossSalary * 10 / 100;
                }
                else
                {
                    return GrossSalary * 5 / 100;
                }
            }
        }

        public double NetSalary
        {
            get
            {
                return GrossSalary - Tax;
            }
        }

        public void DisplaySalary()
        {
            Console.WriteLine("----- Employee Salary Statement -----");

            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Gross Salary: " + GrossSalary);
            Console.WriteLine("Tax: " + Tax);
            Console.WriteLine("Net Salary: " + NetSalary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.EmployeeId = 101;
            employee.Name = "Krishna";
            employee.BasicSalary = 60000;

            employee.DisplaySalary();

            Console.ReadKey();
        }
    }
}