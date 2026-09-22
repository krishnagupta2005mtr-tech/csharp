using System;

namespace Q4_Temperature
{
    class Temperature
    {
        private double celsius;

        public double Celsius
        {
            get
            {
                return celsius;
            }

            set
            {
                if (value >= -273.15)
                {
                    celsius = value;
                }
                else
                {
                    Console.WriteLine("Invalid temperature.");
                    Console.WriteLine("Celsius cannot be below -273.15.");
                }
            }
        }

        public double Fahrenheit
        {
            get
            {
                return (Celsius * 9 / 5) + 32;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();

            temp.Celsius = 25;

            Console.WriteLine("Celsius: " + temp.Celsius);
            Console.WriteLine("Fahrenheit: " + temp.Fahrenheit);

            Console.ReadKey();
        }
    }
}