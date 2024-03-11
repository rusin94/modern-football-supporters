using MFS.Core.Entities;
using MFS.Core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFS.Server.Persistence.Configuration;

public class NewsItemEntityConfiguration : IEntityTypeConfiguration<NewsItem>
{
    public void Configure(EntityTypeBuilder<NewsItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.TiTle)
            .HasConversion(x=>x.Value, x=>new TiTle(x))
            .IsRequired();
        builder.Property(x => x.Content)
            .HasConversion(x=>x.Value, x=> new Content(x))
            .IsRequired();
        builder.Property(x => x.Author)
            .HasConversion(x=>x.Value, x=> new Author(x))
            .IsRequired();
    }
}