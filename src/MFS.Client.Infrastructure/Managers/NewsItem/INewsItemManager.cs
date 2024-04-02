using MFS.Shared.Dto.NewsItems;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public interface INewsItemManager :IManager
{
    Task<int> CreateNewsItemAsync(NewsItemCreateDto dto, CancellationToken cancellationToken);
    Task UpdateNewsItemAsync(NewsItemUpdateDto dto, CancellationToken cancellationToken);
    Task DeleteNewsItemAsync(int id, CancellationToken cancellationToken);
    Task<IEnumerable<NewsItemDto>?> GetNewsItemAsync(CancellationToken cancellationToken);
    
}