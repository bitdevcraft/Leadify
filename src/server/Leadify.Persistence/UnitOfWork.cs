using Leadify.Domain.Auditable;
using Leadify.Domain.Primitives;
using Leadify.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Leadify.Persistence;

internal sealed class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    async Task<int> IUnitOfWork.SaveChangesAsync(CancellationToken cancellationToken)
    {
        UpdateAuditableEntities();

        var entityAuditInformation = BeforeSaveChanges();
        //var userId = await Users.Select(x => x.Id).FirstOrDefaultAsync(cancellationToken);
        int returnValue = await _dbContext.SaveChangesAsync(cancellationToken);

        var success = returnValue > 0;

        if (success is not true)
            return returnValue;

        //if all changes are saved then only create audit
        foreach (EntityAuditInformation item in entityAuditInformation)
        {
            dynamic entity = item.Entity;
            List<AuditEntry> changes = item.Changes;

            if (changes == null)
                continue;

            if (changes.Count == 0)
                continue;

            Audit audit =
                new()
                {
                    TableName = item.TableName,
                    RecordId = entity.Id,
                    ChangeDate = DateTime.UtcNow,
                    Operation = item.OperationType,
                    Changes = changes,
                    //ChangedById = userId // LoggedIn user Id
                };

            _ = await _dbContext.AddAsync(audit, cancellationToken);
        }

        //Save audit data
        await _dbContext.SaveChangesAsync(cancellationToken);

        return returnValue;
    }

    private void UpdateAuditableEntities()
    {
        IEnumerable<EntityEntry<IAuditableEntity>> entries =
            _dbContext.ChangeTracker.Entries<IAuditableEntity>();

        foreach (EntityEntry<IAuditableEntity> entityEntry in entries)
        {
            if (entityEntry.State == EntityState.Added)
            {
                entityEntry.Property(a => a.CreatedOnUtc).CurrentValue = DateTime.UtcNow;
            }

            if (entityEntry.State == EntityState.Modified)
            {
                entityEntry.Property(a => a.ModifiedOnUtc).CurrentValue = DateTime.UtcNow;
            }
        }
    }

    private List<EntityAuditInformation> BeforeSaveChanges()
    {
        List<EntityAuditInformation> entityAuditInformation = new();

        var entityEntries = _dbContext
            .ChangeTracker.Entries()
            .Where(x => x.State != EntityState.Unchanged);

        foreach (EntityEntry entityEntry in entityEntries)
        {
            dynamic entity = entityEntry.Entity;
            bool isAdd = entityEntry.State == EntityState.Added;
            List<AuditEntry> changes = new();

            foreach (PropertyEntry property in entityEntry.Properties)
            {
                if (isAdd && property.CurrentValue == null)
                    continue;

                if (
                    property.IsModified
                    && Object.Equals(property.CurrentValue, property.OriginalValue)
                )
                    continue;

                if (property.Metadata.Name == "Id")
                    continue;

                changes.Add(
                    new AuditEntry()
                    {
                        Id = Ulid.NewUlid(),
                        FieldName = property.Metadata.Name,
                        NewValue = property.CurrentValue?.ToString(),
                        OldValue = isAdd ? null : property.OriginalValue?.ToString()
                    }
                );
            }

            //PropertyEntry? IsDeletedPropertyEntry = entityEntry.Properties.FirstOrDefault(x =>
            //    x.Metadata.Name == nameof(entity.IsDeleted)
            //);

            entityAuditInformation.Add(
                new EntityAuditInformation()
                {
                    Entity = entity,
                    TableName = entityEntry.Metadata?.GetTableName() ?? entity.GetType().Name,
                    State = entityEntry.State,
                    IsDeleteChanged = false,
                    Changes = changes
                }
            );
        }
        return entityAuditInformation;
    }
}
