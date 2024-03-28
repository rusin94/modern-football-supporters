using System.Net.Http.Json;
using MFS.Application.Features.NewsItems.Commands.AddNewsItem;
using MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;
using MFS.Client.Infrastructure.Routes;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public class NewsItemManager:INewsItemManager
{
    private readonly HttpClient _httpClient;

    public NewsItemManager(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<int> CreateNewsItemAsync(NewsItemCreateDto dto, CancellationToken cancellationToken)
    {
        var result =  await _httpClient.PostAsJsonAsync(NewsItemEndpoints.CreateNewsItem, dto, cancellationToken);
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
}