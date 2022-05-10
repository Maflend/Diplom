﻿using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.ProductManager
{
    public interface IProductManager
    {
        Task<List<ProductResponseDto>> GetAll();
        Task<ProductResponseDto> GetById(Guid id);
    }
}
