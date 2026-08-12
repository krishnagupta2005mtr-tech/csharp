/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        string name;
        int rollNumber;
        double marks;

        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Marks      : " + marks);

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Arithmetic Operations ");
        Console.WriteLine("Sum       : " + (num1 + num2));
        Console.WriteLine("Difference: " + (num1 - num2));
        Console.WriteLine("Product   : " + (num1 * num2));
        Console.WriteLine("Quotient  : " + (num1 / num2));
        Console.WriteLine("Remainder : " + (num1 % num2));

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is Positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }

        Console.ReadKey();
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        int marks;

        Console.Write("Enter student's marks (0-100): ");
        marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 91 && marks <= 100)
        {
            Console.WriteLine("Grade: O");
        }
        else if (marks >= 81 && marks <= 90)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 71 && marks <= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 61 && marks <= 70)
        {
            Console.WriteLine("Grade: B+");
        }
        else if (marks >= 51 && marks <= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 0 && marks < 51)
        {
            Console.WriteLine("Grade: Fail");
        }
        else
        {
            Console.WriteLine("Invalid marks! Enter marks between 0 and 100.");
        }

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        int choice;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n Calculator ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case 4:
                if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter the value of N: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEven numbers:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nOdd numbers:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int n;
        long factorial = 1;

        Console.Write("Enter a positive integer: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + n + " = " + factorial);
        }

        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int num;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(num + " is a Prime Number.");
        }
        else
        {
            Console.WriteLine(num + " is Not a Prime Number.");
        }

        Console.ReadKey();
    }
}*/

/* using System;

class Program
{
    static void Main()
    {
        int num, original, reverse = 0, remainder;

        Console.Write("Enter an integer: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
        }

        if (original == reverse)
        {
            Console.WriteLine(original + " is a Palindrome Number.");
        }
        else
        {
            Console.WriteLine(original + " is Not a Palindrome Number.");
        }

        Console.ReadKey();
    }
}*/

using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1. Check Even/Odd");
            Console.WriteLine("2. Find Largest of Three Numbers");
            Console.WriteLine("3. Calculate Factorial");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int num;

                    Console.Write("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num % 2 == 0)
                        Console.WriteLine(num + " is Even.");
                    else
                        Console.WriteLine(num + " is Odd.");

                    break;

                case 2:
                    int a, b, c, largest;

                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter third number: ");
                    c = Convert.ToInt32(Console.ReadLine());

                    largest = a;

                    if (b > largest)
                        largest = b;

                    if (c > largest)
                        largest = c;

                    Console.WriteLine("Largest number: " + largest);

                    break;

                case 3:
                    int n;
                    long factorial = 1;

                    Console.Write("Enter a positive integer: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Factorial is not possible for negative numbers.");
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            factorial = factorial * i;
                        }

                        Console.WriteLine("Factorial of " + n + " = " + factorial);
                    }

                    break;

                case 4:
                    Console.WriteLine("Program exited.");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        } while (choice != 4);

        Console.ReadKey();
    }
}