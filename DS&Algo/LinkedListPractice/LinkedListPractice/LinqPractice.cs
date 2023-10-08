using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    internal class LinqPractice
    {
        public static void MainFunction()
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Clothing" },
                new Category { CategoryId = 3, CategoryName = "Books" }
            };

            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Smartphone",
                    Price = 599.99,
                    ManufactureDate = DateTime.Parse("2022-03-15"),
                    InStock = true,
                    Category = categories[0] // Assuming Electronics category
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Laptop",
                    Price = 1299.99,
                    ManufactureDate = DateTime.Parse("2022-02-20"),
                    InStock = true,
                    Category = categories[0] // Assuming Electronics category
                },
                new Product
                {
                    ProductId = 3,
                    Name = "T-shirt",
                    Price = 19.99,
                    ManufactureDate = DateTime.Parse("2023-01-05"),
                    InStock = true,
                    Category = categories[1] // Assuming Clothing category
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Jeans",
                    Price = 39.99,
                    ManufactureDate = DateTime.Parse("2023-04-10"),
                    InStock = false,
                    Category = categories[1] // Assuming Clothing category
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Programming Book",
                    Price = 29.99,
                    ManufactureDate = DateTime.Parse("2023-11-30"),
                    InStock = true,
                    Category = categories[2] // Assuming Books category
                }
            };

            // 1. Find the category with the highest average product price.
            var query1 = products.GroupBy(x => x.Category)
                .Select(x => new
                {
                    Category = x.Key,
                    Price = x.Average(y => y.Price)
                })
                .OrderByDescending(x => x.Price)
                .FirstOrDefault();

            // 2. Find the products with the earliest and latest manufacture dates.
            var query2 = products.OrderBy(x => x.ManufactureDate).FirstOrDefault();
            var query3 = products.OrderByDescending(x => x.ManufactureDate).FirstOrDefault();

            // 3.Find the categories with products in stock and calculate the total value of those products.
            var query4 = products.Where(x => x.InStock)
                .GroupBy(x => x.Category)
                .Select(x => new
                {
                    CategoryName = x.Key,
                    TotalValue = x.Sum(y => y.Price)
                }).ToList();

            // 4. Find the products with names containing at least three vowels.
            var query5 = products.Where(x => x.Name.Count(y => "AEIOUaeiou".Contains(y)) > 3).ToList();

            // 5. Find the products that are in the same category as the most expensive product.
            var mostExpensiveProducts = products.OrderByDescending(x => x.Price).FirstOrDefault();
            var productsInSameCategory = products.Where(x => x.Category.CategoryId == mostExpensiveProducts.Category.CategoryId).ToList();

            // 6. Find the categories that have at least one product with a price above $1000.
            var query6 = categories.Where(x => products.Any(y => y.Category.CategoryId == x.CategoryId && y.Price > 1000)).ToList();

            // 7. Find the products that are either out of stock or have a price less than $50.
            var query7 = products.Where(x => !x.InStock || x.Price < 50).ToList();

            // 8. Find the average price of products manufactured in the last quarter of the year.
            var query8 = products.Where(x => x.ManufactureDate.Month > 10 && x.ManufactureDate.Month < 12).Average(x => x.Price);

            // 9. Find the categories with products sorted by their average price in descending order.
            var query9 = categories.OrderByDescending(c => products.Where(x => x.Category.CategoryId == c.CategoryId).Average(x => x.Price)).ToList();

            // 10. Find the products with names that have the same characters as the word "apple."
            var query10 = products.Where(x => x.Name.OrderBy(n => n).SequenceEqual("Programming Book".OrderBy(c => c))).ToList();
        }

        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public DateTime ManufactureDate { get; set; }
            public bool InStock { get; set; }
            public Category Category { get; set; }
        }

        public class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}