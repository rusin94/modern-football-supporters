using System.Net.Http.Json;
using MFS.Client.Infrastructure.Extensions;
using MFS.Client.Infrastructure.Routes;
using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public class NewsItemManager : INewsItemManager
{
    private readonly HttpClient _httpClient;

    public NewsItemManager(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(SettingsExtension.ClientName);
    }

    public async Task<IResult<int>> CreateNewsItemAsync(NewsItemCreateDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync(NewsItemEndpoints.CreateNewsItem, dto);
        return await response.ToResult<int>();
    }

    public async Task<IResult<int>> UpdateNewsItemAsync(NewsItemUpdateDto dto)
    {
        var response = await _httpClient.PutAsJsonAsync(NewsItemEndpoints.UpdateNewsItem, dto);
        return await response.ToResult<int>();
    }

    public async Task<IResult<int>> DeleteNewsItemAsync(int id)
    {
        var result = await _httpClient.DeleteAsync(NewsItemEndpoints.DeleteNewsItem(id));
        return await result.ToResult<int>();
    }

    public async Task<IResult<List<NewsItemDto>>> GetNewsItemAsync()
    {
        var response =  await _httpClient.GetAsync(NewsItemEndpoints.GetNewsItems);
        return await response.ToResult<List<NewsItemDto>>();

    }
}