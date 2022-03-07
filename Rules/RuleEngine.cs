using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NotificationSchedulingAPI.Data;
using NotificationSchedulingAPI.DTO;
using NotificationSchedulingAPI.Models;

namespace NotificationSchedulingAPI.Rules
{
    public class RuleEngine:IRuleEngine
    {
        private readonly NotificationDBContext _context;
        public RuleEngine(NotificationDBContext context)
        {
            _context = context;
        }

        public List<Notification> ScheduleNotificationRule(AddNotificationDTO addNotificationDTO)
        {
            string createDate = addNotificationDTO.CreationDate.ToShortDateString();
            DateTime schedule = DateTime.ParseExact(createDate,"dd/MM/yyyy",null);
            int year = schedule.Year;
            int month = schedule.Month;
            int date = schedule.Day;
            List<Notification> notifications = new List<Notification>();
            
            if(addNotificationDTO.MarketName.ToLower()=="denmark" ||
            (addNotificationDTO.MarketName.ToLower()=="finland" && 
             addNotificationDTO.CompanyTypeName.ToLower() == "large company") )
            { 
                notifications.Add(new Notification{
                    CompanyId = addNotificationDTO.CompanyId,
                    SendDate = schedule.AddDays(1),
                    CreatedDate = addNotificationDTO.CreationDate,
                    MarketName = addNotificationDTO.MarketName
                });
                for(int i = 1;i<5;i++)
                {
                    schedule = schedule.AddDays(5);
                    notifications.Add(new Notification{
                        CompanyId = addNotificationDTO.CompanyId,
                        SendDate = schedule,
                        CreatedDate = addNotificationDTO.CreationDate,
                        MarketName = addNotificationDTO.MarketName
                    });
                }

            }
            if(addNotificationDTO.MarketName.ToLower()=="norway")
            { 
                notifications.Add(new Notification{
                    CompanyId = addNotificationDTO.CompanyId,
                    SendDate = schedule.AddDays(1),
                    CreatedDate = addNotificationDTO.CreationDate,
                    MarketName = addNotificationDTO.MarketName
                });
                for(int i = 1;i<4;i++)
                {
                    var nextSchedule = 5 * Math.Pow(2,i-1);
                    schedule = schedule.AddDays(nextSchedule); 
                    notifications.Add(new Notification{
                        CompanyId = addNotificationDTO.CompanyId,
                        SendDate = schedule,
                        CreatedDate = addNotificationDTO.CreationDate,
                        MarketName = addNotificationDTO.MarketName
                    });
                }

            }
             if(addNotificationDTO.MarketName.ToLower()=="sweden" && 
             (addNotificationDTO.CompanyTypeName.ToLower() == "small company" ||
              addNotificationDTO.CompanyTypeName.ToLower()=="medium company"))
            { 
                notifications.Add(new Notification{
                    CompanyId = addNotificationDTO.CompanyId,
                    SendDate = schedule.AddDays(1),
                    CreatedDate = addNotificationDTO.CreationDate,
                    MarketName = addNotificationDTO.MarketName
                });
                for(int i = 1;i<=3;i++)
                {
                    var nextSchedule = 7 * Math.Pow(2,i-1);
                    schedule = schedule.AddDays(nextSchedule);
                    notifications.Add(new Notification{
                        CompanyId = addNotificationDTO.CompanyId,
                        SendDate = schedule,
                        CreatedDate = addNotificationDTO.CreationDate,
                        MarketName = addNotificationDTO.MarketName
                    });
                }

            }
            
            return notifications;
        }
    }
}