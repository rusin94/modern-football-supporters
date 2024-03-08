using MFS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MFS.Server.Persistence.Contexts;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
            
    }
    DbSet<NewsItem> NewsItems { get; set; }
}