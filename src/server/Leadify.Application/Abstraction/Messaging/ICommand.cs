using ErrorOr;
using MediatR;

namespace Leadify.Application.Abstraction.Messaging;

public interface ICommand<TResponse> : IRequest<ErrorOr<TResponse>>, IBaseCommand { }

public interface IBaseCommand { }
