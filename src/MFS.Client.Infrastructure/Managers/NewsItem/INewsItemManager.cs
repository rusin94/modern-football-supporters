using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public interface INewsItemManager :IManager
{
    Task<int> CreateNewsItemAsync(NewsItemCreateDto dto);
    Task UpdateNewsItemAsync(NewsItemUpdateDto dto);
    Task DeleteNewsItemAsync(int id);
    Task<IResult<List<NewsItemDto>>> GetNewsItemAsync();
    
}