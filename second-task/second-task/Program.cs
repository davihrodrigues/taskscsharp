using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    public class Product
    {
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product { Name = "Product A", Price = 100, Stock = 5 },
                new Product { Name = "Product B", Price = 200, Stock = 3 },
                new Product { Name = "Product C", Price = 50, Stock = 10 },
            };

            Console.WriteLine("Enter the filter type (name, price, stock):");
            string filterType = Console.ReadLine()?.ToLower();

            Console.WriteLine("Enter the order (asc for ascending, desc for descending):");
            string orderType = Console.ReadLine()?.ToLower();

            List<Product> sortedProducts = null;

            switch (filterType)
            {
                case "name":
                    sortedProducts = orderType == "desc"
                        ? products.OrderByDescending(p => p.Name).ToList()
                        : products.OrderBy(p => p.Name).ToList();
                    PrintProducts(sortedProducts, $"Sorted by Name ({GetOrderText(orderType)})");
                    break;

                case "price":
                    sortedProducts = orderType == "desc"
                        ? products.OrderByDescending(p => p.Price).ToList()
                        : products.OrderBy(p => p.Price).ToList();
                    PrintProducts(sortedProducts, $"Sorted by Price ({GetOrderText(orderType)})");
                    break;

                case "stock":
                    sortedProducts = orderType == "desc"
                        ? products.OrderByDescending(p => p.Stock).ToList()
                        : products.OrderBy(p => p.Stock).ToList();
                    PrintProducts(sortedProducts, $"Sorted by Stock ({GetOrderText(orderType)})");
                    break;

                default:
                    Console.WriteLine("Invalid filter type.");
                    break;
            }
        }

        static void PrintProducts(List<Product> productList, string title)
        {
            Console.WriteLine(title);
            foreach (var product in productList)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
            Console.WriteLine();
        }

        static string GetOrderText(string orderType)
        {
            return orderType == "desc" ? "Descending" : "Ascending";
        }
    }
}