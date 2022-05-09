using Diplom.Application.Abstracts.Mediator.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetProductsQuery());

            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetProductQuery() { Id = id });

            return Ok(result);
        }
    }
}
