using System.Net.Http.Json;
using MFS.Client.Infrastructure.Extensions;
using MFS.Client.Infrastructure.Routes;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public class NewsItemManager : INewsItemManager
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public NewsItemManager(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _httpClient = _httpClientFactory.CreateClient(SettingsExtension.ClientName);
    }

    public async Task<int> CreateNewsItemAsync(NewsItemCreateDto dto, CancellationToken cancellationToken)
    {
        var result = await _httpClient.PostAsJsonAsync(NewsItemEndpoints.CreateNewsItem, dto, cancellationToken);
        return await result.Content.ReadFromJsonAsync<int>(cancellationToken: cancellationToken);
    }

    public async Task UpdateNewsItemAsync(NewsItemUpdateDto dto, CancellationToken cancellationToken)
    {
        await _httpClient.PutAsJsonAsync(NewsItemEndpoints.UpdateNewsItem, dto, cancellationToken);
    }

    public async Task DeleteNewsItemAsync(int id, CancellationToken cancellationToken)
    {
        await _httpClient.DeleteAsync(NewsItemEndpoints.DeleteNewsItem(id), cancellationToken);
    }

    public async Task<IEnumerable<NewsItemDto>?> GetNewsItemAsync(CancellationToken cancellationToken)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<NewsItemDto>?>(NewsItemEndpoints.GetNewsItems, cancellationToken: cancellationToken);
    }
}