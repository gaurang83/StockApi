using Microsoft.EntityFrameworkCore;
using StockApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost:3000")  // Allow the React app's origin
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Set up DbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add controllers to the container (required for API)
builder.Services.AddControllers();

var app = builder.Build();

// Enable CORS globally or for specific routes
app.UseCors("AllowLocalhost");

// Middleware setup
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
