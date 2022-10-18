using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Categories.Queries;
using Diplom.Domain.Repositories.Abstracts;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Categories.Queries;

/// <summary>
/// Обработчик запроса получения списка категорий.
/// </summary>
public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<CategoryResponseDto>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Хэндлер.
    /// </summary>
    /// <param name="request"><see cref="GetCategoriesQuery"/></param>
    /// <param name="cancellationToken"></param>
    /// <returns><see cref="Task{List{T}}">Task&lt;List&lt;CategoryResponseDto&gt;&gt;</see></returns>
    public async Task<List<CategoryResponseDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAllAsync(cancellationToken);

        return _mapper.Map<List<CategoryResponseDto>>(categories);
    }
}
