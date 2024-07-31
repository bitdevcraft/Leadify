using ErrorOr;
using MediatR;

namespace Leadify.Application.Abstraction.Messaging;

public interface ICommandHandler<TCommand, TResponse>
    : IRequestHandler<TCommand, ErrorOr<TResponse>>
    where TCommand : ICommand<TResponse> { }
