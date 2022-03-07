using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingAPI
{
    public class Market
    {
        [Key]
        public int MarketId { get; set; }
        public string MarketName { get; set; }
    }
}