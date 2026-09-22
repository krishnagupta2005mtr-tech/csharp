/* using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a numeric value.");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter index (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value = " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index is out of range.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Enter a valid integer.");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = " + (a / b));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception)
        {
            Console.WriteLine("Some other error occurred.");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new Exception("Insufficient balance.");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance = " + balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using ATM.");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());

                if (marks[i] < 0 || marks[i] > 100)
                {
                    throw new Exception("Marks must be between 0 and 100.");
                }
            }

            Console.WriteLine("Marks entered successfully.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numeric marks.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}*/

/*using System;

class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username != "admin" || password != "1234")
            {
                throw new InvalidLoginException("Invalid username or password.");
            }

            Console.WriteLine("Login successful.");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}*/

/*using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Insufficient balance."
            );
        }

        balance = balance - amount;
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining balance = " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}*/

/*using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string file = "student.txt";

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter course: ");
            string course = Console.ReadLine();

            Console.Write("Enter roll number: ");
            string roll = Console.ReadLine();

            // Write data
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine("Student Name: " + name);
                writer.WriteLine("Course: " + course);
                writer.WriteLine("Roll Number: " + roll);
            }

            // Read data
            Console.WriteLine("\nStudent Details:");

            using (StreamReader reader = new StreamReader(file))
            {
                string data = reader.ReadToEnd();
                Console.WriteLine(data);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string file = "marks.txt";

            string[] lines = File.ReadAllLines(file);

            int total = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            foreach (string line in lines)
            {
                int mark = Convert.ToInt32(line);

                total += mark;

                if (mark > highest)
                    highest = mark;

                if (mark < lowest)
                    lowest = mark;
            }

            double average = (double)total / lines.Length;

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Highest = " + highest);
            Console.WriteLine("Lowest = " + lowest);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: File contains invalid marks.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}