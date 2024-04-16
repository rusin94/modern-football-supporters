using MediatR;
using MFS.Application.Features.NewsItems.Commands.CreateNewsItem;
using MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;
using MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;
using MFS.Application.Features.NewsItems.Queries.GetNewsItems;
using MFS.Shared.Dto.NewsItems;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewsItemController : ApiControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateNewsItem(NewsItemCreateDto dto)
    {
        var result =  await DispatchAsync(new CreateNewsItemCommand(dto));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewsItem(NewsItemUpdateDto dto)
    {
        var result = await DispatchAsync(new UpdateNewsItemCommand(dto));
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteNewsItem(int id)
    {
        await DispatchAsync(new DeleteNewsItemCommand(id));
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetNewsItems()
    {
        var result = await DispatchAsync(new GetNewsItemsQuery());
        return Ok(result);
    }
}