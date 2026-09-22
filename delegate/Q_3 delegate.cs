delegate void Message();

class Program
{
    static void Hello()
    {
        Console.WriteLine("Hello World");
    }

    static void Main()
    {
        Message msg = Hello;  

        msg();                
    }
}