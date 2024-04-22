using Saaspian.Service.Shared.Events;

namespace Saaspian.Service.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}