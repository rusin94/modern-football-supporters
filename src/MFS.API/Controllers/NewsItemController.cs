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
        return await DispatchAsync(new CreateNewsItemCommand(dto));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewsItem(NewsItemUpdateDto dto)
    {
        return await DispatchAsync(new UpdateNewsItemCommand(dto));
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteNewsItem(int id)
    {
        return await DispatchAsync(new DeleteNewsItemCommand(id));
    }

    [HttpGet]
    public async Task<IActionResult> GetNewsItems()
    {
        return await DispatchAsync(new GetNewsItemsQuery());
    }
}