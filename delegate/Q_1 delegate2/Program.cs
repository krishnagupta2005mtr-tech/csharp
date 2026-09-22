

/*ans1 Delegate C# mein ek type hai jo method ka reference store karta hai. Iska use method ko variable ki tarah pass aur call karne ke liye hota hai.

Simple words mein:

Delegate = Method ka reference

Purpose
Methods ko indirectly call karna

Callback implement karna

Event handling

Multiple methods ko ek saath call karna using multicast delegate
using System;

class Program
{
    delegate void MyDelegate();

    static void Message()
    {
        Console.WriteLine("Hello C#");
    }

    static void Main()
    {
        MyDelegate d = Message;
        d();
    }
}


answer 2: using System;

class Program
{
    delegate int AddDelegate(int a, int b);

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        AddDelegate d = Add;

        int result = d(10, 20);

        Console.WriteLine("Sum = " + result);
    }
}

answer 3:Unicast Delegate
Ek delegate mein sirf ek method store hota hai.


Delegate → Method1
Multicast Delegate
Ek delegate mein multiple methods store ho sakte hain.


Delegate → Method1
        → Method2
        → Method3
using System;

class Program
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    static void Main()
    {
        // Unicast
        MyDelegate d1 = Method1;
        d1();

        Console.WriteLine();

        // Multicast
        MyDelegate d2 = Method1;
        d2 += Method2;

        d2();
    }
}

answer 4:using System;

class Program
{
    delegate double Calculator(double a, double b);

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        double a = 20;
        double b = 5;

        Calculator c;

        c = Add;
        Console.WriteLine("Addition = " + c(a, b));

        c = Subtract;
        Console.WriteLine("Subtraction = " + c(a, b));

        c = Multiply;
        Console.WriteLine("Multiplication = " + c(a, b));

        c = Divide;
        Console.WriteLine("Division = " + c(a, b));
    }
}

answer 5:using System;

class Program
{
    delegate void Notification();

    static void Email()
    {
        Console.WriteLine("Email notification sent.");
    }

    static void SMS()
    {
        Console.WriteLine("SMS notification sent.");
    }

    static void WhatsApp()
    {
        Console.WriteLine("WhatsApp notification sent.");
    }

    static void Main()
    {
        Notification notify = Email;

        notify += SMS;
        notify += WhatsApp;

        notify();
    }
}

answer 6:using System;

class Program
{
    delegate double SalaryDelegate(double basic);

    static double BasicSalary(double basic)
    {
        return basic;
    }

    static double HRA(double basic)
    {
        return basic * 0.20;
    }

    static double DA(double basic)
    {
        return basic * 0.10;
    }

    static double Bonus(double basic)
    {
        return basic * 0.15;
    }

    static void Main()
    {
        double basic = 50000;

        SalaryDelegate salary = BasicSalary;
        salary += HRA;
        salary += DA;
        salary += Bonus;

        foreach (SalaryDelegate method in salary.GetInvocationList())
        {
            Console.WriteLine(
                method.Method.Name + " = " + method(basic)
            );
        }
    }
}

answer 7:using System;

class Program
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Hello");
    }

    static void Method2()
    {
        Console.WriteLine("Welcome");
    }

    static void Method3()
    {
        Console.WriteLine("Good Morning");
    }

    static void Main()
    {
        MyDelegate d = Method1;
        d += Method2;
        d += Method3;

        foreach (MyDelegate method in d.GetInvocationList())
        {
            Console.WriteLine("Method Name: " + method.Method.Name);
            method();
        }
    }
}

answer 8:Action C# ka built-in delegate hai.

Iska return type void hota hai.

Example:

C#

Action<string>
iska matlab method:

1 string parameter lega

kuch return nahi karega

Syntax
C#

Action<parameters> variable = method;

using System;

class Program
{
    static void Hello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Welcome(string name)
    {
        Console.WriteLine("Welcome " + name);
    }

    static void Main()
    {
        // Unicast
        Action<string> a1 = Hello;
        a1("Krishna");

        Console.WriteLine();

        // Multicast
        Action<string> a2 = Hello;
        a2 += Welcome;

        a2("Krishna");
    }
}

answer 9:Func C# ka built-in delegate hai jo value return karta hai.

Example:

C#

Func<int, int, int>
Meaning:


2 int input → 1 int output

using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        // Unicast
        Func<int, int, int> f1 = Add;

        Console.WriteLine("Addition = " + f1(10, 20));

        // Multicast
        Func<int, int, int> f2 = Add;
        f2 += Multiply;

        Console.WriteLine("\nMulticast results:");

        foreach (Func<int, int, int> method in f2.GetInvocationList())
        {
            int result = method(10, 20);

            Console.WriteLine(
                method.Method.Name + " = " + result
            );
        }
    }
}

answer 10: using System;

class Program
{
    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    static bool IsPositive(int n)
    {
        return n > 0;
    }

    static bool GreaterThan100(int n)
    {
        return n > 100;
    }

    static void Main()
    {
        int number = 120;

        Predicate<int> p = IsEven;
        p += IsPositive;
        p += GreaterThan100;

        foreach (Predicate<int> method in p.GetInvocationList())
        {
            bool result = method(number);

            Console.WriteLine(
                method.Method.Name + " = " + result
            );
        }
    }
}