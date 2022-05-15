using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Diplom.Server.Controllers
{
    /// <summary>
    /// Контроллер для продуктов.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Получить все продукты.
        /// </summary>
        /// <returns>List<<see cref="ProductResponseDto"/>>.</returns>
        [Authorize]
        [HttpGet("getAll")]
        public async Task<ActionResult<List<ProductResponseDto>>> GetAll()
        {
            var result = await _mediator.Send(new GetProductsQuery());

            return Ok(result);
        }

        /// <summary>
        /// Получить продукт по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns><see cref="ProductResponseDto"/>.</returns>
        [HttpGet]
        public async Task<ActionResult<ProductResponseDto>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetProductQuery() { Id = id });

            return Ok(result);
        }

        /// <summary>
        /// Получить продукты по идентификатору категории.
        /// </summary>
        /// <param name="categoryId">Идентификатор категории.</param>
        /// <returns>List<<see cref="ProductResponseDto"/>>.</returns>
        [HttpGet("category")]
        public async Task<ActionResult<List<ProductResponseDto>>> GetAllByCategoryId(Guid categoryId)
        {
            var result = await _mediator.Send(
                new GetProductsFromCategoryQuery()
                {
                    CategoryId = categoryId
                }
                );

            return Ok(result);
        }
    }
}
