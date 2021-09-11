using Messages.Core;

namespace BaseEntity.Domain.Messaging
{
    public abstract class Command
    {
        public abstract Response Validate();
    }
}
