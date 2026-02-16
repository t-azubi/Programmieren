using System;
using System.Collections.Generic;
using System.Linq;

var orders = new List<Order>
{
    new("A001", "Alex", "Hardware", 149.99m, 2),
    new("A002", "Kim", "Books", 29.90m, 1),
    new("A003", "Sam", "Hardware", 399.00m, 1),
    new("A004", "Alex", "Food", 8.50m, 5),
    new("A005", "Mina", "Books", 15.00m, 3),
    new("A006", "Kim", "Food", 3.20m, 8),
    new("A007", "Sam", "Hardware", 89.99m, 1)
};

Console.WriteLine("=== LINQ Playground ===");
Console.WriteLine();

var expensiveOrders = orders
    .Where(order => order.Total >= 100m)
    .OrderByDescending(order => order.Total)
    .ToList();

Console.WriteLine("1) Teure Bestellungen (>= 100)");
foreach (var order in expensiveOrders)
{
    Console.WriteLine($"- {order.OrderId} | {order.Customer} | {order.Total:C}");
}
Console.WriteLine();

var orderSummaries = orders
    .Select(order => new
    {
        order.OrderId,
        order.Customer,
        Summary = $"{order.Quantity}x {order.Category}"
    })
    .ToList();

Console.WriteLine("2) Projektion mit Select");
foreach (var summary in orderSummaries.Take(4))
{
    Console.WriteLine($"- {summary.OrderId}: {summary.Customer} -> {summary.Summary}");
}
Console.WriteLine("...");
Console.WriteLine();

var categoryStats = orders
    .GroupBy(order => order.Category)
    .Select(group => new
    {
        Category = group.Key,
        Count = group.Count(),
        Revenue = group.Sum(order => order.Total),
        Average = group.Average(order => order.Total)
    })
    .OrderByDescending(stat => stat.Revenue)
    .ToList();

Console.WriteLine("3) Gruppierung nach Kategorie");
foreach (var stat in categoryStats)
{
    Console.WriteLine($"- {stat.Category}: {stat.Count} Orders | Umsatz {stat.Revenue:C} | Ø {stat.Average:C}");
}
Console.WriteLine();

var topCustomer = orders
    .GroupBy(order => order.Customer)
    .Select(group => new
    {
        Customer = group.Key,
        Revenue = group.Sum(order => order.Total)
    })
    .OrderByDescending(result => result.Revenue)
    .First();

Console.WriteLine("4) Aggregation");
Console.WriteLine($"Top-Kunde: {topCustomer.Customer} mit {topCustomer.Revenue:C}");

public sealed record Order(
    string OrderId,
    string Customer,
    string Category,
    decimal UnitPrice,
    int Quantity)
{
    public decimal Total => UnitPrice * Quantity;
}
