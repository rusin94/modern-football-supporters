using MediatR;
using MFS.Application.Features.Communities.CreateCommunity;
using MFS.Application.Features.Communities.DeleteCommunity;
using MFS.Application.Features.Communities.EditCommunity;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommunityController : ControllerBase
{
    private readonly IMediator _mediator;

    public CommunityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCommunity(CreateCommunityCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> EditCommunity(EditCommunityCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCommunity(DeleteCommunityCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

}