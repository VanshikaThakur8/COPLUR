using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Dictionary<string, double> productPrices = new Dictionary<string, double>();

            productPrices.Add("Shirt", 449);
            productPrices.Add("Jeans", 999);
            productPrices.Add("Kurti", 669);
            productPrices.Add("Tshirt", 349);
            productPrices.Add("Joggers", 1299);

            Console.WriteLine("Product Prices:");
            foreach (var product in productPrices)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            double averagePrice = productPrices.Values.Average();
            Console.WriteLine($"\nAverage Price: {averagePrice}");

            var mostExpensiveProduct = productPrices.OrderByDescending(x => x.Value).First();

            Console.WriteLine($"\nMost Expensive Product: {mostExpensiveProduct.Key} - {mostExpensiveProduct.Value}");
        }
    }
}