using MFS.Application.Features.NewsItems.Queries.GetNewsItems;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SportTypeController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSportTypes()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSportType()
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSportType()
    {
        return Ok();
    }
}