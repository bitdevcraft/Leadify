using Leadify.Domain.ClientAppLayout;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

public class NgFormLayoutConfiguration : IEntityTypeConfiguration<NgFormLayout>
{
    public void Configure(EntityTypeBuilder<NgFormLayout> builder)
    {
        builder.ToTable(TableNames.NgFormLayouts);
        builder.HasKey(x => x.Id);
    }
}