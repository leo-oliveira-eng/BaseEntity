using BaseEntity.Domain.Events;
using BaseEntity.Domain.Messaging;
using System.Threading.Tasks;

namespace BaseEntity.Domain.Mediator.Contracts
{
    public interface IMediatorHandler
    {
        Task<object> SendCommand<T>(T command) where T : Command;

        Task PublishEvent<T>(T @event) where T : Event;
    }
}
