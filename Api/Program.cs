using CleanMinimalApiExample.Startup;
using Todos;
using User;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .RegisterApiServices()
    .RegisterUserServices()
    .RegisterTodoServices();

var app = builder.Build();
app.MapEndpoints()
    .UseSwaggerConfig();

app.Run();