using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.NewsItem;

public interface INewsItemManager :IManager
{
    Task<IResult<int>> CreateNewsItemAsync(NewsItemCreateDto dto);
    Task<IResult<int>> UpdateNewsItemAsync(NewsItemUpdateDto dto);
    Task <IResult<int>> DeleteNewsItemAsync(int id);
    Task<IResult<List<NewsItemDto>>> GetNewsItemAsync();
    
}