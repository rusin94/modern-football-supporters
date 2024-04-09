using MFS.Shared.Dto.NewsItems;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public interface INewsItemManager :IManager
{
    Task<int> CreateNewsItemAsync(NewsItemCreateDto dto);
    Task UpdateNewsItemAsync(NewsItemUpdateDto dto);
    Task DeleteNewsItemAsync(int id);
    Task<List<NewsItemDto>> GetNewsItemAsync();
    
}