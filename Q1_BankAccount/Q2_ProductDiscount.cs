using System;

namespace Q2_ProductDiscount
{
    class Product
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public double DiscountPrice
        {
            get
            {
                if (Price >= 10000)
                {
                    return Price - (Price * 20 / 100);
                }
                else if (Price >= 5000)
                {
                    return Price - (Price * 10 / 100);
                }
                else
                {
                    return Price;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.ProductName = "Laptop";
            product.Price = 12000;

            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Original Price: " + product.Price);
            Console.WriteLine("Final Price: " + product.DiscountPrice);

            Console.ReadKey();
        }
    }
}