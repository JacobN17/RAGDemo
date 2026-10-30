using Microsoft.EntityFrameworkCore;
using RAGDemo.Infrastructure;
using RAGDemo.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Register Infrastructure services (DbContext, Repositories, etc.)
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Optional for demo/local dev: automatically apply pending migrations on startup
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await dbContext.Database.MigrateAsync();
}

app.MapGet("/", () => "RAGDemo API is running");

app.Run();