using Leadify.Domain.ClientAppLayout;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

public class NgMenuConfiguration : IEntityTypeConfiguration<NgMenu>
{
    public void Configure(EntityTypeBuilder<NgMenu> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.ParentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);
    }
}