using ExoApi.Context;
using ExoApi.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options => { options.AddPolicy("CorsPolicy", policy => { policy.WithOrigins("https://localhost:7266").AllowAnyHeader().AllowAnyMethod(); }); });
builder.Services.AddScoped<SqlContext, SqlContext>();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
