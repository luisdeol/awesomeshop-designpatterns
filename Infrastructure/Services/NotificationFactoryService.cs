using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Enums;
using SendGrid;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public class NotificationFactoryService : INotificationFactoryService
    {
        private readonly ISendGridClient _sendGridClient;

        public NotificationFactoryService(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }

        public INotificationService GetService(NotificationType type)
        {
            if (type == NotificationType.Email)
                return new EmailService(_sendGridClient);
            
            return new SmsService();
        }
    }
}