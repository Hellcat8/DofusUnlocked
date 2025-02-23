using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Implementations;
using DofusUnlocked.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddScoped<ICharacterClassRepository, ICharacterClassRepository>();
builder.Services.AddScoped<ICharacterClassService, CharacterClassService>();

// Database
var connectionString = builder.Configuration.GetConnectionString("prod_dofusunlocked");
builder.Services.AddDbContext<DofusContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddScoped<DofusContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
