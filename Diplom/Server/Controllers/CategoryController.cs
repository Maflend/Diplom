using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Categories.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
    /// <summary>
    /// Контроллер для категорий.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Получить все категории.
        /// </summary>
        /// <returns>List<<see cref="CategoryResponseDto"/>></returns>
        [HttpGet("getAll")]
        public async Task<ActionResult<List<CategoryResponseDto>>> GetAll()
        {
            var result = await _mediator.Send(new GetCategoriesQuery());

            return Ok(result);
        }
    }
}
