using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.IServices;
using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IDiplomContext _db;

        public ProductService(IDiplomContext db)
        {
            _db = db;
        }
        public async Task<ProductResponseDto> GetById(Guid id)
        {
            var product = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            ProductResponseDto response = new()
            {
                Name = product?.Name,
               // CategoryName = product?.Category.Name,
                Description = product?.Description,
                Price = product.Price
            };
            return response;

        }

        public async Task<List<ProductResponseDto>> GetList()
        {
            var products = await _db.Products.Include(p => p.Category).ToListAsync();
            if (products == null)
                return new List<ProductResponseDto>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductResponseDto>().ForMember("CategoryName", opt => opt.MapFrom(p => p.Category.Name)));
            // Настройка AutoMapper
            var mapper = new Mapper(config);
            // сопоставление
            var response = mapper.Map<List<ProductResponseDto>>(products);

            return response;
        }
        public async Task<List<ProductResponseDto>> GetListByCategoryId(Guid id)
        {
            var products = await _db.Products.Where(p => p.Category.Id == id).ToListAsync();
            if (products == null)
                return new List<ProductResponseDto>();

         //   var response = products.Select(p => new ProductResponseDto() { Name = p.Name, CategoryName = p.Category.Name, Description = p.Description, Price = p.Price }).ToList();
            var response = products.Select(p => new ProductResponseDto() { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();
        
            return response;
        }


    }
}
