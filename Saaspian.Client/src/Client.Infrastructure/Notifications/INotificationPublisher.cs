using FSH.WebApi.Shared.Notifications;

namespace Saaspian.Client.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}