using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingAPI.Models
{
    public class Company
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int CompanyNumber { get; set; }
        public int CompanyTypeId { get; set; }
        public int MarketId { get; set; }
    }
}