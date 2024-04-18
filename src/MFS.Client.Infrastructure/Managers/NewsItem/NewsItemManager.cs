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

    public async Task<int> CreateNewsItemAsync(NewsItemCreateDto dto)
    {
        var result = await _httpClient.PostAsJsonAsync(NewsItemEndpoints.CreateNewsItem, dto);
        return await result.Content.ReadFromJsonAsync<int>();
    }

    public async Task UpdateNewsItemAsync(NewsItemUpdateDto dto)
    {
        await _httpClient.PutAsJsonAsync(NewsItemEndpoints.UpdateNewsItem, dto);
    }

    public async Task DeleteNewsItemAsync(int id)
    {
        await _httpClient.DeleteAsync(NewsItemEndpoints.DeleteNewsItem(id));
    }

    public async Task<IResult<List<NewsItemDto>>> GetNewsItemAsync()
    {
        var response =  await _httpClient.GetAsync(NewsItemEndpoints.GetNewsItems);
        return await response.ToResult<List<NewsItemDto>>();

    }
}