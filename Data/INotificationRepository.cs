using System.Collections.Generic;
using NotificationSchedulingAPI.DTO;
using NotificationSchedulingAPI.Models;

namespace NotificationSchedulingAPI.Data
{
    public interface INotificationRepository
    {
        bool SaveChanges();
        void ScheduleNotification(AddNotificationDTO addNotificationDTO);
        List<Notification> GetNotificationCreated(AddNotificationDTO notificationDTO);
        List<Notification> GetExistingNotifications(AddNotificationDTO notificationDTO);
    }
}