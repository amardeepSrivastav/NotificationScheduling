using System;

namespace NotificationSchedulingAPI.DTO
{
    public class AddNotificationDTO
    {
        public string MarketName { get; set; }
        public string CompanyTypeName { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}