using AirlineBookingSystem.Notifications.Core.Entities;

namespace AirlineBookingSystem.Notifications.Application.Intefaces
{
    public interface INotificationService
    {
        Task SendNotificationAsync(Notification notification);
    }
}
