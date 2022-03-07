using System;

namespace NotificationSchedulingAPI.DTO
{
    public class ReadNotificationDTO
    {
        public int NotificationId { get; set; }
        public DateTime SendDate{get;set;}
    }
}