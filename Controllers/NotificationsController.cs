using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopDesignPatterns.API.Application;
using AwesomeShopDesignPatterns.API.Application.NotifyUser;
using AwesomeShopDesignPatterns.API.Infrastructure.Services;
using AwesomeShopDesignPatterns.API.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AwesomeShopDesignPatterns.API.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Notify(NotifyUserCommand command) {
            await _mediator.Send(command);

            return Accepted();
        }
    }
}