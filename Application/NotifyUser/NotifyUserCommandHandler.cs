using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Infrastructure.Services;
using MediatR;

namespace AwesomeShopDesignPatterns.API.Application.NotifyUser
{
    public class NotifyUserCommandHandler : IRequestHandler<NotifyUserCommand, Unit>
    {
        private readonly INotificationFactoryService _factoryService;
        public NotifyUserCommandHandler(INotificationFactoryService factoryService)
        {
            _factoryService = factoryService;
        }

        public async Task<Unit> Handle(NotifyUserCommand command, CancellationToken token) {
            var notificationService = _factoryService.GetService(command.Type);

            await notificationService.SendAsync(command.Destination, command.Content);

            return Unit.Value;
        }
    }
}