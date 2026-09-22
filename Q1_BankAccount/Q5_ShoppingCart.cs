using System;

namespace Q5_ShoppingCart
{
    class Product
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public double Discount
        {
            get
            {
                if (TotalPrice >= 10000)
                {
                    return TotalPrice * 15 / 100;
                }
                else if (TotalPrice >= 5000)
                {
                    return TotalPrice * 10 / 100;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double FinalPrice
        {
            get
            {
                return TotalPrice - Discount;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.ProductName = "Shoes";
            product.Price = 2500;
            product.Quantity = 4;

            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Quantity: " + product.Quantity);

            Console.WriteLine("Total Price: " + product.TotalPrice);
            Console.WriteLine("Discount: " + product.Discount);
            Console.WriteLine("Final Price: " + product.FinalPrice);

            Console.ReadKey();
        }
    }
}