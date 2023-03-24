using Microsoft.EntityFrameworkCore;
using Northwind.Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        // Para un origen específico
        //builder.WithOrigins("https://localhost:7205/").WithMethods("GET");
    });
});

var connectionString = builder.Configuration.GetConnectionString("NW");
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddDbContext<NWContext>(options =>
        options.UseSqlServer(connectionString));
}

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
