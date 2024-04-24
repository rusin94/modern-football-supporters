using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        protected async Task<IActionResult> DispatchAsync<T>(T command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
