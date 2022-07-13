using AwesomeShopDesignPatterns.API.Application;
using AwesomeShopDesignPatterns.API.Application.NotifyUser;
using AwesomeShopDesignPatterns.API.Infrastructure.Services;
using SendGrid.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var sendGridApiKey = builder.Configuration.GetSection("SendGridApiKey").Value;

builder.Services.AddSendGrid(o => o.ApiKey = sendGridApiKey);

builder.Services.AddScoped<INotificationFactoryService, NotificationFactoryService>();

builder.Services.AddScoped<NotifyUserCommandHandler>();
builder.Services.AddScoped<ICommandHandler<NotifyUserCommand, Task>, NotifyUserCommandHandlerDecorator>();

builder.Services.AddScoped<IMediator, Mediator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.ConfigureAppConfiguration((hostingContext, config) => {
    Serilog.Log.Logger = new LoggerConfiguration()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .CreateLogger();
}).UseSerilog();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
