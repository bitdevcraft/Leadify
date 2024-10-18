namespace Leadify.Persistence.Constants;

public static class Permissions
{
    public static ICollection<string> GeneratePermissionsForModule(string module) =>
    [
        $"Permissions.{module}.Create",
        $"Permissions.{module}.View",
        $"Permissions.{module}.Edit",
        $"Permissions.{module}.Delete"
    ];
}