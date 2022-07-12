using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public interface INotificationService
    {
        Task SendAsync(string destination, string content);
    }
}