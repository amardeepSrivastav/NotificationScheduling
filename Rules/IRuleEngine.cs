using System.Collections.Generic;
using NotificationSchedulingAPI.DTO;
using NotificationSchedulingAPI.Models;

namespace NotificationSchedulingAPI.Rules
{
    public interface IRuleEngine
    {
        List<Notification> ScheduleNotificationRule(AddNotificationDTO addNotificationDTO);
    }
}