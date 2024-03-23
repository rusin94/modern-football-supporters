using MFS.Core.Entities;
using MFS.Core.ValueObjects.Community;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MFS.Server.Persistence.Configuration;

public class CommunityEntityConfiguration:IEntityTypeConfiguration<Community>
{
    public void Configure(EntityTypeBuilder<Community> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name)
            .HasConversion(x=>x.Value, x=> new Name(x))
            .IsRequired();
        builder.Property(x => x.Description)
            .HasConversion(x=>x.Value, x=> new Description(x))
            .IsRequired();
    }
}