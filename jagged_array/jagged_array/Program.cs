//display zegged array
using System;

class Program
{
    static void Main()
    {
        int[][] arr = new int[3][];

        arr[0] = new int[] { 10, 20 };
        arr[1] = new int[] { 30, 40, 50 };
        arr[2] = new int[] { 60, 70, 80, 90 };

        Console.WriteLine("Jagged Array:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}

//to take input in zegged array
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write("Enter number of elements in row " + (i + 1) + ": ");
            int size = Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[size];

            for (int j = 0; j < size; j++)
            {
                Console.Write("Enter element: ");
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}*/

//sum of all element

/*using System;

class Program
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70 }
        };

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                sum = sum + arr[i][j];
            }
        }

        Console.WriteLine("Sum = " + sum);
    }
}*/

//largest array 

/*using System;

class Program
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 10, 50 },
            new int[] { 20, 5, 80 },
            new int[] { 30, 40, 15 }
        };

        int largest = arr[0][0];
        int smallest = arr[0][0];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] > largest)
                {
                    largest = arr[i][j];
                }

                if (arr[i][j] < smallest)
                {
                    smallest = arr[i][j];
                }
            }
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}*/

//each row respected row no

/*using System;

class Program
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70, 80, 90 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");

            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}*/

//

/*using System;

class Program
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70, 80, 90 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                sum = sum + arr[i][j];
            }

            Console.WriteLine("Row " + (i + 1));
            Console.WriteLine("Number of elements = " + arr[i].Length);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine();
        }
    }
}*/

//search any element

/*using System;

class Program
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70, 80 }
        };

        Console.Write("Enter element to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == search)
                {
                    Console.WriteLine("Element found at Row " + (i + 1));
                    found = true;
                }
            }
        }

        if (found == false)
        {
            Console.WriteLine("Element not found");
        }
    }
}*/

//store student marks

/*using System;

class Program
{
    static void Main()
    {
        int[][] marks = new int[3][];

        
        marks[0] = new int[3];

        
        marks[1] = new int[4];

        
        marks[2] = new int[5];

        
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1));

            for (int j = 0; j < marks[i].Length; j++)
            {
                Console.Write("Subject " + (j + 1) + ": ");
                marks[i][j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
        }

        
        for (int i = 0; i < marks.Length; i++)
        {
            int total = 0;

            for (int j = 0; j < marks[i].Length; j++)
            {
                total = total + marks[i][j];
            }

            double percentage = (double)total / marks[i].Length;

            Console.WriteLine("Student " + (i + 1));
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + percentage + "%");
            Console.WriteLine();
        }
    }
}*/

//string

/*using System;

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
}*/