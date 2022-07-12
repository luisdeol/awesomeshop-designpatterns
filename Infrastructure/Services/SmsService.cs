using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public class SmsService : INotificationService
    {
        public Task SendAsync(string destination, string content)
        {
            Console.WriteLine("SmsService.Send");

            return Task.CompletedTask;
        }
    }
}