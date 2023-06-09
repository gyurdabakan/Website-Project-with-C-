﻿using WebSiteProject.Persistance;
using WebSiteProject.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddpersistanceServices(builder.Configuration);
builder.Services.AddCoreServices();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

