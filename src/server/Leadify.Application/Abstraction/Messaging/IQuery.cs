using Leadify.Domain.Shared;
using MediatR;

namespace Leadify.Application.Abstraction.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>> { }
