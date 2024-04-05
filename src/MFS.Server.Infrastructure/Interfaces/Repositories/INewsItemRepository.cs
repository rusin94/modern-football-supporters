using MFS.Core.Entities;

namespace MFS.Server.Infrastructure.Interfaces.Repositories;

public interface INewsItemRepository
{
    NewsItem Add(NewsItem newsItem);
    NewsItem Update(NewsItem newsItem);
    NewsItem GetById(int id);
    IEnumerable<NewsItem> GetAll();
    public void Delete(NewsItem newsItem);
    Task<IEnumerable<NewsItem>> GetAllAsync();
}