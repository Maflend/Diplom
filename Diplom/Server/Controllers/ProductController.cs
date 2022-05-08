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

        [HttpGet("{id}")]
        public Task<ActionResult> Get([FromBody]Guid id)
        {
            throw new NotImplementedException();
           // return Ok("ok");
        }
    }
}
