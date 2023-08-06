using CleanMinimalApiExample.Startup;
using CleanMinimalApiExample.Startup.Modules;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .RegisterApiServices()
    .RegisterModules();

var app = builder.Build();
app.MapEndpoints()
    .InitSwagger();

app.Run();