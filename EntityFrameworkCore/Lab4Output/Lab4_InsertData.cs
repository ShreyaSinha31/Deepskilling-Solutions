using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

var electronics = new Category
{
    Name = "Electronics"
};

var groceries = new Category
{
    Name = "Groceries"
};

context.Categories.AddRange(electronics, groceries);

var laptop = new Product
{
    Name = "Laptop",
    Price = 75000,
    Category = electronics
};

var riceBag = new Product
{
    Name = "Rice Bag",
    Price = 1200,
    Category = groceries
};

context.Products.AddRange(laptop, riceBag);

context.SaveChanges();

Console.WriteLine("Sample data inserted successfully.");