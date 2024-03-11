﻿using MFS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MFS.Server.Persistence.Contexts;

public class AppDbContext :DbContext
{
    DbSet<NewsItem> NewsItems { get; set; }
    public AppDbContext(DbContextOptions options):base(options)
    {
            
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}