using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Abstraction.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}