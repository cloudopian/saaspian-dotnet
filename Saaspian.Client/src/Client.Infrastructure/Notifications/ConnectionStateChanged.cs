using FSH.WebApi.Shared.Notifications;

namespace Saaspian.Client.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;