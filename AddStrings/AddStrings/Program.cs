
using System;


class Program
{
    static string AddStrings(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        string result = "";

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int x = (i >= 0) ? a[i] - '0' : 0;
            int y = (j >= 0) ? b[j] - '0' : 0;

            int sum = x + y + carry;

            result = (sum % 10) + result;
            carry = sum / 10;

            i--;
            j--;
        }

        return result;
    }

    static void Main()
    {

        string a1 = "1234";
        string b1 = "56";

        Console.WriteLine("Example 1:");
        Console.WriteLine(AddStrings(a1, b1));



        string a2 = "56";
        string b2 = "1234";

        Console.WriteLine("\nExample 2:");
        Console.WriteLine(AddStrings(a2, b2));



        string a3 = "12345673212899543219";
        string b3 = "987612673489652";

        Console.WriteLine("\nExample 3:");
        Console.WriteLine(AddStrings(a3, b3));
    }
}


/*
using System;

class Program
{
    static int GetPin(string input1)
    {
        
        string[] words = input1.Split(' ');

        int totalLength = 0;

        
        foreach (string word in words)
        {
            totalLength = totalLength + word.Length;
        }

     
        while (totalLength >= 10)
        {
            int sum = 0;

            while (totalLength > 0)
            {
                sum = sum + totalLength % 10;
                totalLength = totalLength / 10;
            }

            totalLength = sum;
        }

        return totalLength;
    }

    static void Main()
    {
        string input1 = "GLA University";

        Console.WriteLine("PIN = " + GetPin(input1));
    }
}*/



