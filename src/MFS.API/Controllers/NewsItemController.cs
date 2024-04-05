using MediatR;
using MFS.Application.Features.NewsItems.Commands.CreateNewsItem;
using MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;
using MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;
using MFS.Application.Features.NewsItems.Queries.GetNewsItems;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewsItemController : ApiControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateNewsItem(CreateNewsItemCommand command)
    {
        var result =  await DispatchAsync(command);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewsItem(UpdateNewsItemCommand command)
    {
        var result = await DispatchAsync(command);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteNewsItem(DeleteNewsItemCommand command)
    {
        await DispatchAsync(command);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetNewsItems()
    {
        var result = await DispatchAsync(new GetNewsItemsQuery());
        return Ok(result);
    }
}