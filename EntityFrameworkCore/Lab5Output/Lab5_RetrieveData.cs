using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

Console.WriteLine("All Products:");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

var product = await context.Products.FindAsync(1);

Console.WriteLine($"\nFound Product: {product?.Name}");

var expensive =
    await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive Product: {expensive?.Name}");