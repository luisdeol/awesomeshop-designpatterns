using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AwesomeShopDesignPatterns.API.Infrastructure.Services
{
    // Façade
    public class EmailService : INotificationService
    {
        private readonly ISendGridClient _sendGridClient;

        public EmailService(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }

        public async Task SendAsync(string destination, string content)
        {
            var message = new SendGridMessage {
                From = new EmailAddress("rojah92295@tebyy.com", "rojah92295@tebyy.com"),
                Subject = "You have a new message.",
                PlainTextContent = $"Here is your new message: {content}"
            };

            message.AddTo(destination, destination);
            
            await _sendGridClient.SendEmailAsync(message);
        }
    }
}