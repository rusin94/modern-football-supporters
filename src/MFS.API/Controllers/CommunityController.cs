﻿using MFS.Application.Features.Communities.CreateCommunity;
using MFS.Application.Features.Communities.DeleteCommunity;
using MFS.Application.Features.Communities.UpdateCommunity;
using Microsoft.AspNetCore.Mvc;

namespace MFS.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommunityController : ApiControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateCommunity(CreateCommunityCommand command)
    {
        return await DispatchAsync(command);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCommunity(UpdateCommunityCommand command)
    {
        return await DispatchAsync(command);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCommunity(DeleteCommunityCommand command)
    {
        return await DispatchAsync(command);
    }

}