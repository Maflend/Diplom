using Diplom.Application.Models.Responses;
using Diplom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponse> GetById(Guid id);
        Task<List<ProductResponse>> GetList();
        Task<List<ProductResponse>> GetListByCategoryId(Guid id);
    }
}
