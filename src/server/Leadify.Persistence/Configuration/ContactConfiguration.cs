using Leadify.Domain.Entities;
using Leadify.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leadify.Persistence.Configuration;

internal sealed class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable(TableNames.Contacts);

        builder.HasKey(x => x.Id);

        var records = new List<Contact>
        {
            new Contact
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                Mobile = "+123456789",
                Phone = "+987654321",
                CreatedOnUtc = DateTime.UtcNow,
                ModifiedOnUtc = null
            },
            new Contact
            {
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                Mobile = "+987654321",
                Phone = "+123456789",
                CreatedOnUtc = DateTime.UtcNow,
                ModifiedOnUtc = null
            },
            new Contact
            {
                Name = "Alice Brown",
                Email = "alice.brown@example.com",
                Mobile = "+1029384756",
                Phone = "+5647382910",
                CreatedOnUtc = DateTime.UtcNow,
            },
            new Contact
            {
                Name = "Bob Johnson",
                Email = "bob.johnson@example.com",
                Mobile = "+567890123",
                Phone = "+210987654",
                CreatedOnUtc = DateTime.UtcNow,
            },
            new Contact
            {
                Name = "Charlie Davis",
                Email = "charlie.davis@example.com",
                Mobile = "+789012345",
                Phone = "+321654987",
                CreatedOnUtc = DateTime.UtcNow,
            }
        };

        builder.HasData(records);
    }
}