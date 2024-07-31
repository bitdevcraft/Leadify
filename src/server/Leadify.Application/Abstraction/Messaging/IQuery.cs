using ErrorOr;
using MediatR;

namespace Leadify.Application.Abstraction.Messaging;

public interface IQuery<TResponse> : IRequest<ErrorOr<TResponse>> { }
