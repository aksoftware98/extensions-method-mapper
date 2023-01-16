var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/customers/{id}", (int id) => "Hello World!");

app.MapGet("/api/customers", () => "All customers retrieved");
app.Run();
