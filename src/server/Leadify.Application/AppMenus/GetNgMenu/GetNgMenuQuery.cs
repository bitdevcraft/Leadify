using Leadify.Application.Abstraction.Messaging;
using Leadify.Domain.ClientAppLayout;
using Leadify.Domain.Entities;
using Leadify.Domain.Extensions;

namespace Leadify.Application.AppMenus.GetNgMenu;

public record GetNgMenuQuery() : IQuery<string>;