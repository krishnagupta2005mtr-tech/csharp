delegate int Calculate(int x, int y);

class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

class Program
{
    static void Main()
    {
        Calculate c = Calculator.Add;

        Console.WriteLine(c(10, 20));
    }
}