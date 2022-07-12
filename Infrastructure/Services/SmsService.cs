using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public class SmsService : INotificationService
    {
        public void Send(string destination, string content)
        {
            Console.WriteLine("SmsService.Send");
        }
    }
}