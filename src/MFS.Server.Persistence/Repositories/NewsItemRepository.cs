using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Server.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MFS.Server.Persistence.Repositories;

public class NewsItemRepository : INewsItemRepository
{
    private readonly AppDbContext _context;

    public NewsItemRepository(AppDbContext context)
    {
        _context = context;
    }

    public NewsItem Add(NewsItem newsItem)
    {
        return _context.NewsItems.Add(newsItem).Entity;
    }

    public NewsItem Update(NewsItem newsItem)
    {
        return _context.NewsItems.Update(newsItem).Entity;
    }

    public NewsItem? GetById(int id)
    {
        return _context.NewsItems.SingleOrDefault(x => x.Id == id);
    }

    public IEnumerable<NewsItem> GetAll()
    {
        return _context.NewsItems.ToList();
    }

    public void Delete(NewsItem newsItem)
    {
        _context.NewsItems.Remove(newsItem);
    }

    public async Task<IEnumerable<NewsItem>> GetAllAsync()
    {
        return await _context.NewsItems.ToListAsync();
    }
}