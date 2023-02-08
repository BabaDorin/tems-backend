using Application.AssetTypes.Commands;
using Application.Managers;
using Domain.Entities;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Create type endpoint
app.MapPost("/create/type", async (IMediator mediator, [FromBody] AssetType assetType) =>
{
    var response = await mediator.Send(new CreateTypeCommand(assetType));

    return response;
});

app.UseHttpsRedirection();


app.Run();
