using CleanMinimalApiExample.Startup;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterApiServices();

var app = builder.Build();
app.MapEndpoints()
    .UseSwaggerConfig();

app.Run();