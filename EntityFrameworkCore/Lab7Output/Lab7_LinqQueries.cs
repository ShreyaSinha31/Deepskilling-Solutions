using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

Console.WriteLine("Products with Price > 1000");

var filteredProducts = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

foreach (var p in filteredProducts)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine("\nProduct DTO:");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var p in productDTOs)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}