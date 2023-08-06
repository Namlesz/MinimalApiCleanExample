namespace CleanMinimalApiExample.Startup;

internal static class WebApplicationExtension
{
    internal static WebApplication InitSwagger(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        return app;
    }
}