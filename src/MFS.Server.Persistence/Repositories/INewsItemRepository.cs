using MFS.Core.Entities;

namespace MFS.Server.Persistence.Repositories;

public interface INewsItemRepository
{
    Task<NewsItem> Add(NewsItem newsItem);
    Task<NewsItem> Update(NewsItem newsItem);
    Task<NewsItem> Delete(int id);
    Task<NewsItem> GetById(int id);
}