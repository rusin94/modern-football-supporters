using MFS.Application.Features.NewsItems.Commands.AddNewsItem;
using MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public interface INewsItemManager :IManager
{
    Task<int> CreateNewsItemAsync(NewsItemCreateDto dto, CancellationToken cancellationToken);
    Task UpdateNewsItemAsync(NewsItemUpdateDto dto, CancellationToken cancellationToken);
    Task DeleteNewsItemAsync(int id, CancellationToken cancellationToken);
    
}