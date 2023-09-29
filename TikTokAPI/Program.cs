using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;
using TikTokAPI.Application.Extensions;
using TikTokAPI.Core.Extensions;
using TikTokAPI.Extensions;
using TikTokAPI.Infraestructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .Configure<GzipCompressionProviderOptions>(compressionOptions => compressionOptions.Level = CompressionLevel.Optimal)
    .Configure<MvcNewtonsoftJsonOptions>(jsonOptions => jsonOptions.SerializerSettings.Configure());

builder.Services
    .AddInfraestructure()
    .AddCQRS()
    .ConfigureAppSettings();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

ValidatorOptions.Global.DisplayNameResolver = (_, member, _) => member?.Name;

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
