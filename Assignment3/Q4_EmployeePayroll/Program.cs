using System;

namespace Q4_EmployeePayroll
{
    sealed class EmployeePayroll
    {
        public double CalculateSalary(double basicSalary)
        {
            double allowance = basicSalary * 0.20;
            return basicSalary + allowance;
        }

        public double CalculateTax(double salary)
        {
            return salary * 0.10;
        }

        public double CalculateNetSalary(double salary, double tax)
        {
            return salary - tax;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeePayroll payroll = new EmployeePayroll();

            double salary = payroll.CalculateSalary(50000);
            double tax = payroll.CalculateTax(salary);
            double netSalary =
                payroll.CalculateNetSalary(salary, tax);

            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net Salary: " + netSalary);

            Console.ReadKey();
        }
    }
}