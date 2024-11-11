using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.ClientAppLayout;

namespace Leadify.Application.AppMenus.CreateNgMenu;

public record CreateNgMenuCommand(NgMenu Menu) : ICommand;