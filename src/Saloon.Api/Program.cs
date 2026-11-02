var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddOpenApi();

var app = builder.Build();

// middleware & endpoints
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.Run();
