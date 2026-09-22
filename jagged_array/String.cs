using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        
        bool isEmpty = String.IsNullOrEmpty(str);

        Console.WriteLine($"Is string null or empty? {isEmpty}");

        if (!isEmpty)
        {
           
            bool starts = str.StartsWith("Hello");
            bool ends = str.EndsWith("C#");

            Console.WriteLine($"Starts with 'Hello': {starts}");
            Console.WriteLine($"Ends with 'C#': {ends}");

          
            int position = str.IndexOf('a');

            Console.WriteLine($"Position of first 'a': {position}");

            
            if (str.Length >= 5)
            {
                string firstFive = str.Substring(0, 5);
                Console.WriteLine($"First 5 characters: {firstFive}");
            }
            else
            {
                Console.WriteLine("String has less than 5 characters.");
            }

           
            string replaced = str.Replace("Java", "C#");
            Console.WriteLine($"After replacing Java with C#: {replaced}");

            
            Console.WriteLine("Enter comma-separated words:");
            string input = Console.ReadLine();

            string[] words = input.Split(',');

            Console.WriteLine("Individual words:");

            foreach (string word in words)
            {
                Console.WriteLine(word.Trim());
            }

            
            Console.Write("Enter first string for comparison: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string for comparison: ");
            string str2 = Console.ReadLine();

            bool equal = str1 == str2;

            Console.WriteLine($"Are both strings equal? {equal}");
        }
    }
}