using System;

namespace BaseEntity.Domain.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTimeOffset DateOccurred { get; }
    }
}
