using System;

delegate int Calculate(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Calculate c = Add;

        int result = c(10, 20);

        Console.WriteLine(result);
    }
}