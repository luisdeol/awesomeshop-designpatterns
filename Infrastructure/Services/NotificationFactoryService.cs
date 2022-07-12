using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Enums;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public class NotificationFactoryService : INotificationFactoryService
    {
        public INotificationService GetService(NotificationType type)
        {
            if (type == NotificationType.Email)
                return new EmailService();
            
            return new SmsService();
        }
    }
}