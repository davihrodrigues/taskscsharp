using System;
using System.Collections.Generic;
using System.Linq;

namespace Second_task
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

        var sortedByName = products.OrderBy(p => p.Name).ToList();
        PrintProducts(sortedByName, "Sorted by Name (Ascending)");

        var sortedByNameDescending = products.OrderByDescending(p => p.Name).ToList();
        PrintProducts(sortedByNameDescending, "Sorted by Name (Descending)");

        var sortedByPrice = products.OrderBy(p => p.Price).ToList();
        PrintProducts(sortedByPrice, "Sorted by Price (Ascending)");

        var sortedByPriceDescending = products.OrderByDescending(p => p.Price).ToList();
        PrintProducts(sortedByPriceDescending, "Sorted by Price (Descending)");

        var sortedByStock = products.OrderBy(p => p.Stock).ToList();
        PrintProducts(sortedByStock, "Sorted by Stock (Ascending)");

        var sortedByStockDescending = products.OrderByDescending(p => p.Stock).ToList();
        PrintProducts(sortedByStockDescending, "Sorted by Stock (Descending)");
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
}

}