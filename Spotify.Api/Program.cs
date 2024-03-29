using Microsoft.EntityFrameworkCore;
using Spotify.Application;
using Spotify.Infrastructure;
using Spotify.Repository;
using Spotify.Repository.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
       .RegisterApplication()
       .RegisterRepository(builder.Configuration.GetConnectionString("Spotify"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();




app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
