using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.CategoryManager
{
    public interface ICategoryManager
    {
        Task<List<CategoryResponseDto>> GetAll();
    }
}
