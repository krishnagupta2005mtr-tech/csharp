public delegate int PerformCalculation(int x, int y);

class Program
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static void Main()
    {
        PerformCalculation p = Add;

        Console.WriteLine(p(10, 20));
    }
}