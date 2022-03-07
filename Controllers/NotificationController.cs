using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotificationSchedulingAPI.Data;
using NotificationSchedulingAPI.DTO;

namespace NotificationSchedulingAPI.Controllers
{
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly ILogger<NotificationController> _logger;
        private readonly IMapper _mapper;

        public NotificationController(INotificationRepository notificationRepository,IMapper mapper,ILogger<NotificationController> logger)
        {
            _notificationRepository = notificationRepository;
            _logger = logger;
            _mapper= mapper;
        }
        
        [Route("api/AddNotification")]
        [HttpPost]
        public ActionResult<List<ReadNotificationDTO>> AddNotification(AddNotificationDTO addNotificationDTO)
        {
            try
            {
               var existingNotifications = _notificationRepository.GetExistingNotifications(addNotificationDTO);
               if(existingNotifications.Count > 0)
               {
                   return _mapper.Map<List<ReadNotificationDTO>>(existingNotifications);
               }
               else
               {
                _notificationRepository.ScheduleNotification(addNotificationDTO);
                _notificationRepository.SaveChanges();
               }
               return _mapper.Map<List<ReadNotificationDTO>>(_notificationRepository.GetNotificationCreated(addNotificationDTO));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return NotFound();
        }
    }
}