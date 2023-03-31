using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Northwind.Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("NW");
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddDbContext<NWContext>(options =>
        options.UseSqlServer(connectionString));
}

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(policy =>
    policy.WithOrigins("https://localhost:7172")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
