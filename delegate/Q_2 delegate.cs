delegate int Calculate(int a, int b);

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
        Calculate c1 = Add;
        Calculate c2 = Multiply;

        Console.WriteLine(c1(10, 20));  
        Console.WriteLine(c2(10, 20));  
    }
}