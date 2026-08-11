/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Positive");
        else if (n < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("Eligible for voting");
        else
            Console.WriteLine("Not eligible for voting");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 40)
            Console.WriteLine("Pass");
        else
            Console.WriteLine("Fail");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90)
            Console.WriteLine("Grade A");
        else if (marks >= 80)
            Console.WriteLine("Grade B");
        else if (marks >= 70)
            Console.WriteLine("Grade C");
        else if (marks >= 60)
            Console.WriteLine("Grade D");
        else if (marks >= 40)
            Console.WriteLine("Grade E");
        else
            Console.WriteLine("Fail");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 5 == 0 && n % 11 == 0)
            Console.WriteLine("Divisible by both 5 and 11");
        else
            Console.WriteLine("Not divisible by both");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' ||
            ch == 'o' || ch == 'u')
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 100 && n <= 999)
            Console.WriteLine("Three digit number");
        else
            Console.WriteLine("Not a three digit number");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter cost price: ");
        int cp = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter selling price: ");
        int sp = Convert.ToInt32(Console.ReadLine());

        if (sp > cp)
            Console.WriteLine("Profit = " + (sp - cp));
        else if (cp > sp)
            Console.WriteLine("Loss = " + (cp - sp));
        else
            Console.WriteLine("No Profit No Loss");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        if (op == '+')
            Console.WriteLine(a + b);
        else if (op == '-')
            Console.WriteLine(a - b);
        else if (op == '*')
            Console.WriteLine(a * b);
        else if (op == '/')
            Console.WriteLine(a / b);
        else
            Console.WriteLine("Invalid operator");
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string user = Console.ReadLine();

        Console.Write("Enter password: ");
        string pass = Console.ReadLine();

        if (user == "admin")
        {
            if (pass == "1234")
                Console.WriteLine("Login Successful");
            else
                Console.WriteLine("Wrong Password");
        }
        else
        {
            Console.WriteLine("Wrong Username");
            Console.ReadKey();
        }
    }
}*/


/* looping*/

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
            Console.WriteLine(i);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 10; i >= 1; i--)
            Console.WriteLine(i);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 2; i <= 20; i += 2)
            Console.WriteLine(i);
     Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
            sum += i;

        Console.WriteLine("Sum = " + sum);
        Console.ReadKey();
    }
}*/