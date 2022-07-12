using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Enums;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public interface INotificationFactoryService
    {
        INotificationService GetService(NotificationType type);
    }
}