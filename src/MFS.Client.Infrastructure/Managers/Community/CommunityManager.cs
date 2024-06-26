﻿using System.Net.Http.Json;
using MFS.Client.Infrastructure.Extensions;
using MFS.Client.Infrastructure.Routes;
using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.Community;

public class CommunityManager : ICommunityManager
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public CommunityManager(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _httpClient = _httpClientFactory.CreateClient(SettingsExtension.ClientName);
    }
    public async Task<IResult<int>> CreateCommunityAsync(CommunityCreateDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync(CommunityEndpoints.CreateCommunity, dto);
        return await response.ToResult<int>();
    }

    public async Task<IResult<int>> UpdateCommunityAsync(CommunityUpdateDto dto)
    {
        var response = await _httpClient.PutAsJsonAsync(CommunityEndpoints.UpdateCommunity, dto);
        return await response.ToResult<int>();
    }

    public async Task<IResult<int>> DeleteCommunityAsync(int id)
    {
        var response = await _httpClient.DeleteAsync(CommunityEndpoints.DeleteCommunity(id));
        return await response.ToResult<int>();
    }

    public async Task<IResult<List<CommunityDto>>> GetCommunitiesAsync()
    {
        var response = await _httpClient.GetAsync(CommunityEndpoints.GetCommunities);
        return await response.ToResult<List<CommunityDto>>();
    }

}