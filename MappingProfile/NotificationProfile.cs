using AutoMapper;
using NotificationSchedulingAPI.DTO;
using NotificationSchedulingAPI.Models;

namespace NotificationSchedulingAPI.MappingProfile
{
    public class StocksProfile:Profile
    {
        public StocksProfile()
        {
            CreateMap<Notification,ReadNotificationDTO>();
            
        }
    }
    
}