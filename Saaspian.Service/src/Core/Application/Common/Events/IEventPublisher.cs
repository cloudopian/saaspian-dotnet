using Saaspian.Service.Shared.Events;

namespace Saaspian.Service.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}