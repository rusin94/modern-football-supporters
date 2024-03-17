using MediatR;
using MFS.Application.DTOs.NewsItem;
using MFS.Application.Features.NewsItems.Commands.AddNewsItem;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

public class NewsItemController : Controller
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
}