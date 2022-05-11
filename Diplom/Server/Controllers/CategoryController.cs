using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Categories.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<List<CategoryResponseDto>>> GetAll()
        {
            var result = await _mediator.Send(new GetCategoriesQuery());

            return Ok(result);
        }
    }
}
