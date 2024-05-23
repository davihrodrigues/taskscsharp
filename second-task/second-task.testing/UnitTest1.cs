using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Second_task;

namespace Second_task.test
{ 
public class ProductTests
{
    [Fact]
    public void TestSorting()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 },
        };

        // Act
        var sortedByName = products.OrderBy(p => p.Name).ToList();
        var sortedByPrice = products.OrderBy(p => p.Price).ToList();
        var sortedByStock = products.OrderBy(p => p.Stock).ToList();

        // Assert
        Assert.True(IsSorted(sortedByName, p => p.Name));
        Assert.True(IsSorted(sortedByPrice, p => p.Price));
        Assert.True(IsSorted(sortedByStock, p => p.Stock));
    }

    private bool IsSorted<T, TKey>(List<T> list, Func<T, TKey> keySelector)
    {
        return list.Zip(list.Skip(1), (a, b) => Comparer<TKey>.Default.Compare(keySelector(a), keySelector(b)) <= 0).All(x => x);
    }
}
}
