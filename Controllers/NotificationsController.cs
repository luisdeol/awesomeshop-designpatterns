using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Infrastructure.Services;
using AwesomeShopDesignPatterns.API.Models;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AwesomeShopDesignPatterns.API.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationFactoryService _factory;

        public NotificationsController(INotificationFactoryService factory, ISendGridClient sendGridClient)
        {
            _factory = factory;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(NotificationInputModel model) {
            var service = _factory.GetService(model.Type);
            await service.SendAsync(model.Destination, model.Content);

            return Accepted();
        }
    }
}