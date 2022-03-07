using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingAPI.Models
{
    public class CompanyType
    {
        [Key]
        public int CompanyTypeId { get; set; }
        public string CompanyTypeName { get; set; }
    }
}