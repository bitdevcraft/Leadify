using Leadify.Application.Abstraction.Messaging;

namespace Leadify.Application.AppMenus.DeleteNgMenu;

public record DeleteNgMenuCommand(string Id) : ICommand;