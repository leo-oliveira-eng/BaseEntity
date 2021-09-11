using MediatR;
using System;

namespace BaseEntity.Domain.Events
{
    public abstract class Event : INotification
    {
        public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;

        protected Event()
        {
            DateOccurred = DateTimeOffset.UtcNow;
        }
    }
}
