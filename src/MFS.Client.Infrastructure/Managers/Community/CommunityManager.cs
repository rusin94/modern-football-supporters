﻿using System.Net.Http.Json;
using MFS.Client.Infrastructure.Routes;
using MFS.Shared.Dto.Communities;

namespace MFS.Client.Infrastructure.Managers.Community;

public class CommunityManager:ICommunityManager
{
    private readonly HttpClient _httpClient;

    public CommunityManager(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<int> CreateCommunityAsync(CommunityCreateDto dto, CancellationToken cancellationToken)
    {
        var result = await _httpClient.PostAsJsonAsync(CommunityEndpoints.CreateCommunity, dto, cancellationToken);
        return await result.Content.ReadFromJsonAsync<int>(cancellationToken: cancellationToken);
    }

    public async Task UpdateCommunityAsync(CommunityUpdateDto dto, CancellationToken cancellationToken)
    {
        await _httpClient.PutAsJsonAsync(CommunityEndpoints.UpdateCommunity, dto, cancellationToken);
    }

    public async Task DeleteCommunityAsync(int id, CancellationToken cancellationToken)
    {
        await _httpClient.DeleteAsync(CommunityEndpoints.DeleteCommunity(id), cancellationToken);
    }
}