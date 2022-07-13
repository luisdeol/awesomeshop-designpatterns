namespace AwesomeShopDesignPatterns.API.Application.NotifyUser
{
    // public class NotifyUserCommandHandler : ICommandHandler<NotifyUserCommand, Task>
    // {
    //     private readonly INotificationFactoryService _factoryService;
    //     public NotifyUserCommandHandler(INotificationFactoryService factoryService)
    //     {
    //         _factoryService = factoryService;
    //     }

    //     public async Task Handle(NotifyUserCommand command) {
    //         var notificationService = _factoryService.GetService(command.Type);

    //         await notificationService.SendAsync(command.Destination, command.Content);
    //     }
    // }
}