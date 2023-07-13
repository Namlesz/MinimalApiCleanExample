using CleanMinimalApiExample.Startup;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.RegisterApiServices();

var app = builder.Build();
app.MapEndpoints();

// var sampleTodos = TodoGenerator.GenerateTodos().ToArray();
//
// var todosApi = app.MapGroup("/todos");
// todosApi.MapGet("/", () => sampleTodos);
// todosApi.MapGet("/{id}", (int id) =>
//     sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
//         ? Results.Ok(todo)
//         : Results.NotFound());

app.Run();