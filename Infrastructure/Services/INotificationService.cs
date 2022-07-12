using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    public interface INotificationService
    {
        void Send(string destination, string content);
    }
}