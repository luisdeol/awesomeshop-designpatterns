using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;

namespace AwesomeShopDesignPatterns.API.Application.NotifyUser
{
    public class NotifyUserCommandHandlerDecorator : ICommandHandler<NotifyUserCommand, Task>
    {
        private readonly NotifyUserCommandHandler _handler;
        public NotifyUserCommandHandlerDecorator(NotifyUserCommandHandler handler)
        {
            _handler = handler;
        }

        public async Task Handle(NotifyUserCommand command)
        {
            Log.Information($"Handler {command.GetType().Name} was called with command {JsonConvert.SerializeObject(command)}!");

            await _handler.Handle(command);
        }
    }
}