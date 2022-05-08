using Diplom.API.Dto.Responses;

namespace Diplom.Application.Abstracts.IServices
{
    public interface IProductService
    {
        Task<ProductResponseDto> GetById(Guid id);
        Task<List<ProductResponseDto>> GetList();
        Task<List<ProductResponseDto>> GetListByCategoryId(Guid id);
    }
}
