using Diplom.Application.Abstracts.IServices;
using Diplom.Domain.Entities;

namespace Diplom.Application
{
    public class InitialData
    {
        public async Task Initial()
        {
            await InitialCategories();
            await InitialProducts();
            
        }
        public InitialData(IDiplomContext context)
        {
            _context = context;
        }
        private readonly IDiplomContext _context;

        public async Task InitialCategories()
        {
            List<Category> Categories = new()
            {
                new Category()
                {
                    Name = "Телефоны"
                },
                new Category()
                {
                    Name = "Телевизоры"
                },
                new Category()
                {
                    Name = "Наушники"
                },
            };

            await _context.Categories.AddRangeAsync(Categories);
            await _context.SaveChangesAsync(new CancellationToken());
        }
        public async Task InitialProducts()
        {
            List<Product> Products = new()
            {
                // Телефоны
                new Product()
                {
                    Name = "IPhon",
                    Description = "смартфон",
                    PurchasePrice = 400,
                    Price = 600,
                    Category = _context.Categories.Where(c => c.Name == "Телефоны").First()
                },
                new Product()
                {
                    Name = "Samsung",
                    Description = "смартфон",
                    PurchasePrice = 300,
                    Price = 500,
                    Category = _context.Categories.Where(c => c.Name == "Телефоны").First()
                },
                new Product()
                {
                    Name = "ZTE",
                    Description = "смартфон",
                    PurchasePrice = 600,
                    Price = 750,
                    Category = _context.Categories.Where(c => c.Name == "Телефоны").First()
                },
                // Телевизоры
                new Product()
                {
                    Name = "LG",
                    Description = "телевизор",
                    PurchasePrice = 200,
                    Price = 350,
                    Category = _context.Categories.Where(c => c.Name == "Телевизоры").First()
                },
                new Product()
                {
                    Name = "Samsung",
                    Description = "телевизор",
                    PurchasePrice = 400,
                    Price = 600,
                    Category = _context.Categories.Where(c => c.Name == "Телевизоры").First()
                },
                new Product()
                {
                    Name = "LG media",
                    Description = "телевизор",
                    PurchasePrice = 800,
                    Price = 350,
                    Category = _context.Categories.Where(c => c.Name == "Телевизоры").First()
                },

                // Наушники
                new Product()
                {
                    Name = "LG",
                    Description = "наушники",
                    PurchasePrice = 20,
                    Price = 35,
                    Category = _context.Categories.Where(c => c.Name == "Наушники").First()
                },
                new Product()
                {
                    Name = "Samsung",
                    Description = "наушники",
                    PurchasePrice = 40,
                    Price = 60,
                    Category = _context.Categories.Where(c => c.Name == "Наушники").First()
                },
                new Product()
                {
                    Name = "LG media",
                    Description = "наушники",
                    PurchasePrice = 15,
                    Price = 22,
                    Category = _context.Categories.Where(c => c.Name == "Наушники").First()
                }
            };


            await _context.Products.AddRangeAsync(Products);
            await _context.SaveChangesAsync(new CancellationToken());
        }

    }
}
