using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Newtonsoft.Json;
using Serilog;

namespace AwesomeShopDesignPatterns.API.Application.NotifyUser
{
    public class NotifyUserCommandHandlerDecorator : IRequestPreProcessor<NotifyUserCommand>
    {
        public Task Process(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            Log.Information($"Handler {request.GetType().Name} was called with command {JsonConvert.SerializeObject(request)}!");

            return Task.CompletedTask;
        }
    }
}