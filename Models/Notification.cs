using System;
using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingAPI.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public DateTime SendDate{get;set;}
        public string CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }

        public string MarketName { get; set; }

    }
}