using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.CategoryManager
{
    /// <summary>
    /// Менеджер категорий.
    /// </summary>
    public interface ICategoryManager
    {
        /// <summary>
        /// Запрос на получение всех категорий.
        /// </summary>
        Task<List<CategoryResponseDto>> GetAll();
    }
}
