using BaseEntity.Domain.Events.Contracts;
using System;

namespace BaseEntity.Domain.Events
{
    public abstract class DomainEvent : Event, IDomainEvent
    {
        public bool IsPublished { get; set; }

        public Guid AggregateId { get; set; }

        protected DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
