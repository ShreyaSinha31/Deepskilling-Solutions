using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// Update Product
var laptop = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (laptop != null)
{
    laptop.Price = 70000;
    await context.SaveChangesAsync();

    Console.WriteLine("Laptop price updated.");
}

// Delete Product
var riceBag = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (riceBag != null)
{
    context.Products.Remove(riceBag);
    await context.SaveChangesAsync();

    Console.WriteLine("Rice Bag deleted.");
}