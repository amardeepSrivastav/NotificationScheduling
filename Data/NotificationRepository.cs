using System;
using System.Collections.Generic;
using System.Linq;
using NotificationSchedulingAPI.DTO;
using NotificationSchedulingAPI.Models;
using NotificationSchedulingAPI.Rules;

namespace NotificationSchedulingAPI.Data
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly NotificationDBContext _context;
        private readonly IRuleEngine _ruleEngine;

        public NotificationRepository(NotificationDBContext context,IRuleEngine ruleEngine)
        {
            _context = context;
            _ruleEngine = ruleEngine;
        }

        public List<Notification> GetExistingNotifications(AddNotificationDTO notificationDTO)
        {
            if(_context.Notifications.Count() > 0)
            {
               return   _context.Notifications.Where(d=>DateTime.Compare(d.CreatedDate, notificationDTO.CreationDate)==0 &&
                d.MarketName.ToLower().Equals(notificationDTO.MarketName.ToLower())).ToList();
            }
            return new List<Notification>();
        }

        public List<Notification> GetNotificationCreated(AddNotificationDTO notificationDTO)
        {
           return _context.Notifications.Where(c=>c.CompanyId == notificationDTO.CompanyId &&
            DateTime.Compare(c.CreatedDate, notificationDTO.CreationDate)==0 &&
             c.MarketName.ToLower().Equals(notificationDTO.MarketName.ToLower())).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void ScheduleNotification(AddNotificationDTO addNotificationDTO)
        {

            if(addNotificationDTO == null)
            {
                throw new ArgumentNullException(nameof(addNotificationDTO));
            }
            List<Notification> notifications = _ruleEngine.ScheduleNotificationRule(addNotificationDTO);
            foreach(var notification in notifications)
            {
                _context.Notifications.Add(notification);
            }
        }
        
    }
}