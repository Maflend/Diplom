using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace Diplom.Client.Infrastructure.Managers.ProductManager;

/// <summary>
/// Менеджер для продукта.
/// </summary>
public class ProductManager : IProductManager
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductManager(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    /// <summary>
    /// Запрос получения продукта по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор продукта.</param>
    /// <returns>Task <see cref="ProductResponseDto"/></returns>
    public async Task<ProductResponseDto> GetById(Guid id)
    {
        var http = _httpClientFactory.CreateClient("ApiClient");
        var query = new Dictionary<string, string>()
        {
            ["Id"] = $"{id}"
        };

        var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetById, query);
        var httpResponse = await http.GetAsync(uri);
        var httpResponseMessageHelper = new HttpResponseMessageHelper<ProductResponseDto>();
        var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

        return response;
    }

    /// <summary>
    /// Запрос получения всех продуктов.
    /// </summary>
    /// <returns>Task List <see cref="ProductResponseDto"/></returns>
    public async Task<List<ProductResponseDto>> GetAll()
    {
        var http = _httpClientFactory.CreateClient("ApiClient");
        var httpResponse = await http.GetAsync(Routes.ProductEndpoints.GetAll);
        var httpResponseMessageHelper = new HttpResponseMessageHelper<List<ProductResponseDto>>();
        var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

        return response;
    }

    /// <summary>
    /// Запрос получения продуктов по идентификатору категории.
    /// </summary>
    /// <param name="categoryid">Идентификатор категории.</param>
    /// <returns>Task List <see cref="ProductResponseDto"/></returns>
    public async Task<List<ProductResponseDto>> GetByCategoryId(Guid categoryid)
    {
        var http = _httpClientFactory.CreateClient("ApiClient");
        var query = new Dictionary<string, string>()
        {
            ["categoryId"] = $"{categoryid}"
        };

        var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetByCategoryId, query);
        var httpResponse = await http.GetAsync(uri);
        var httpResponseMessageHelper = new HttpResponseMessageHelper<List<ProductResponseDto>>();
        var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

        return response;
    }

}
