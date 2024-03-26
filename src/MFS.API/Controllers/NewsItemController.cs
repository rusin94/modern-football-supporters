using MediatR;
using MFS.Application.Features.NewsItems.Commands.AddNewsItem;
using MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;
using MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewsItemController : ControllerBase
{
    private readonly IMediator _mediator;

    public NewsItemController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewsItem(AddNewsItemCommand command)
    {
        var result =  await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewsItem(UpdateNewsItemCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteNewsItem(DeleteNewsItemCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}