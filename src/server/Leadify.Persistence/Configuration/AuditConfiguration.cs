using Leadify.Domain.Auditable;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

internal sealed class AuditConfiguration : IEntityTypeConfiguration<Audit>
{
    public void Configure(EntityTypeBuilder<Audit> builder)
    {
        builder.ToTable(TableNames.SysAudits);

        builder.HasKey(x => x.Id);
    }
}
