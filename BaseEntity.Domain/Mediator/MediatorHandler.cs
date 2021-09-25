using BaseEntity.Domain.Events;
using BaseEntity.Domain.Mediator.Contracts;
using BaseEntity.Domain.Messaging;
using MediatR;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BaseEntity.Domain.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        IMediator Mediator { get; }

        public MediatorHandler(IMediator mediator)
        {
            Mediator = mediator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async virtual Task<object> SendCommand<T>(T command) where T : Command
            => await Mediator.Send(command);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async virtual Task<TResponse> SendCommand<TRequest, TResponse>(TRequest command)
            where TRequest : IRequest<TResponse>
            where TResponse : class
            => await Mediator.Send(command);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async virtual Task PublishEvent<T>(T @event) where T : Event
            => await Mediator.Publish(@event);
    }
}
