using BaseEntity.Domain.Events;
using BaseEntity.Domain.Messaging;
using MediatR;
using System.Threading.Tasks;

namespace BaseEntity.Domain.Mediator.Contracts
{
    public interface IMediatorHandler
    {
        Task<object> SendCommand<T>(T command) where T : Command;

        Task<TResponse> SendCommand<TRequest, TResponse>(TRequest command)
            where TRequest : IRequest<TResponse>
            where TResponse : class;

        Task PublishEvent<T>(T @event) where T : Event;
    }
}
