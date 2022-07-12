using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Application.NotifyUser;
using AwesomeShopDesignPatterns.API.Infrastructure.Services;

namespace AwesomeShopDesignPatterns.API.Application
{
    public interface IMediator
    {
        Task Send(ICommand command);
    }

    public class Mediator : IMediator
    {
        private readonly ICommandHandler<NotifyUserCommand, Task> _notifyUserCommandHandler;

        public Mediator(ICommandHandler<NotifyUserCommand, Task> notifyUserCommandHandler)
        {
            _notifyUserCommandHandler = notifyUserCommandHandler;
        }

        public async Task Send(ICommand command)
        {
            if (command is NotifyUserCommand)
                await _notifyUserCommandHandler.Handle((NotifyUserCommand)command);
        }
    }
}