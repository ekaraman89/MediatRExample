using MediatR;
using MediatRExample.Mediatr.Commands;
using MediatRExample.Mediatr.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator mediator;

        public TestController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Index(int Id)
        {
            var request = new GetProductByIdQuery { Id = Id };
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPost()]
        public async Task<IActionResult> Index([FromBody] CreateProductCommand command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}
