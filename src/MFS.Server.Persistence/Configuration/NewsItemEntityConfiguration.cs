using MFS.Core.Entities;
using MFS.Core.ValueObjects.NewsItem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFS.Server.Persistence.Configuration;

public class NewsItemEntityConfiguration : IEntityTypeConfiguration<NewsItem>
{
    public void Configure(EntityTypeBuilder<NewsItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title)
            .HasConversion(x=>x.Value, x=>new Title(x))
            .IsRequired();
        builder.Property(x => x.Content)
            .HasConversion(x=>x.Value, x=> new Content(x))
            .IsRequired();
        builder.Property(x => x.Author)
            .HasConversion(x=>x.Value, x=> new Author(x))
            .IsRequired();
    }
}