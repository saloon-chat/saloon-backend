var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();

// middleware & endpoints
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapHealthChecks("/health");

app.Run();
