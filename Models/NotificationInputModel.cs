using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Enums;

namespace AwesomeShopDesignPatterns.API.Models
{
    public class NotificationInputModel
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}