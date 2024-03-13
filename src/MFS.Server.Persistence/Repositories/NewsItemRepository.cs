using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Server.Persistence.Repositories;

public class NewsItemRepository : INewsItemRepository
{
    public NewsItem Add(NewsItem newsItem)
    {
        throw new NotImplementedException();
    }

    public NewsItem Update(NewsItem newsItem)
    {
        throw new NotImplementedException();
    }

    public NewsItem GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<NewsItem> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}