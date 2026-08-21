using System;
using System.Collections.Generic;

namespace Q7_GenericRepository
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return RollNumber + " - " + Name;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id + " - " + Name;
        }
    }

    class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void DisplayAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Repository<Student> studentRepository =
                new Repository<Student>();

            studentRepository.Add(
                new Student
                {
                    RollNumber = 101,
                    Name = "Krishna"
                });

            studentRepository.Add(
                new Student
                {
                    RollNumber = 102,
                    Name = "Rahul"
                });

            Console.WriteLine("Students:");
            studentRepository.DisplayAll();

            Repository<Employee> employeeRepository =
                new Repository<Employee>();

            employeeRepository.Add(
                new Employee
                {
                    Id = 1,
                    Name = "Amit"
                });

            employeeRepository.Add(
                new Employee
                {
                    Id = 2,
                    Name = "Ravi"
                });

            Console.WriteLine("\nEmployees:");
            employeeRepository.DisplayAll();

            Console.ReadKey();
        }
    }
}