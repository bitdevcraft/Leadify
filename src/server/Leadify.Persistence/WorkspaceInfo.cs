using System.ComponentModel.DataAnnotations;
using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Abstractions;

namespace Leadify.Persistence;

public class WorkspaceInfo : ITenantInfo
{
    private string? _id;

    public WorkspaceInfo()
    {
    }

    [MaxLength(64)]
    public string? Id
    {
        get => _id;
        set => _id = value;
    }

    [MaxLength(64)] public string? Identifier { get; set; }
    [MaxLength(64)] public string? Name { get; set; }
    [MaxLength(64)] public string? SchemaName { get; set; }
}