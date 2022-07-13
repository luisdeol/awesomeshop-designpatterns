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
        private readonly ISendGridClient _sendGridClient;
        public NotificationsController(ISendGridClient sendGridClient)
        {
           _sendGridClient = sendGridClient;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(NotificationInputModel model) {
            var message = new SendGridMessage {
                From = new EmailAddress("rojah92295@tebyy.com", "rojah92295@tebyy.com"),
                Subject = "You have a new message.",
                PlainTextContent = $"Here is your new message: {model.Content}"
            };

            message.AddTo(model.Destination, model.Destination);
            
            await _sendGridClient.SendEmailAsync(message);

            return Accepted();
        }
    }
}