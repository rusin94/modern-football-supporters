using MFS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFS.Server.Persistence.Configuration;

public class NewsItemEntityConfiguration : IEntityTypeConfiguration<NewsItem>
{
    public void Configure(EntityTypeBuilder<NewsItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Header).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Content).IsRequired().HasMaxLength(1500);
        builder.Property(x => x.Author).IsRequired().HasMaxLength(100);
    }
}