using AutoMapper;
using Diplom.Application.Interfaces;
using Diplom.Application.Models.Responses;
using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IDiplomContext _db;

        public ProductService(IDiplomContext db)
        {
            _db = db;
        }
        public async Task<ProductResponse> GetById(Guid id)
        {
            var product = await _db.Products.Include(p=>p.Category).FirstOrDefaultAsync(p => p.Id == id);
            ProductResponse response = new()
            {
                Name = product?.Name,
                CategoryName = product?.Category.Name,
                Description = product?.Description,
                Price = product.Price
            };
            return response;

        }

        public async Task<List<ProductResponse>> GetList()
        {
            var products = await _db.Products.Include(p=>p.Category).ToListAsync();
            if (products == null)
                return new List<ProductResponse>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductResponse>().ForMember("CategoryName", opt=>opt.MapFrom(p=>p.Category.Name)));
            // Настройка AutoMapper
            var mapper = new Mapper(config);
            // сопоставление
            var response = mapper.Map<List<ProductResponse>>(products);

            return response;
        }
        public async Task<List<ProductResponse>> GetListByCategoryId(Guid id)
        {
            var products = await _db.Products.Where(p=>p.CategoryId == id).ToListAsync();
            if (products == null)
                return new List<ProductResponse>();

            var response = products.Select(p => new ProductResponse() { Name = p.Name, CategoryName = p.Category.Name, Description = p.Description, Price = p.Price }).ToList();

            return response;
        }

        
    }
}
