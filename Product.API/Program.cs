using Microsoft.OpenApi.Models;
using Product.Bussiness.Services;
using Product.DAL.Data;
using Product.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Product.DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Product",
                    Description = "Product Management System API",
                });
            });
builder.Services.AddTransient<ProductDbContext>();
builder.Services.AddTransient<IProductRepo, ProductRepo>();
builder.Services.AddTransient<IColourRepo, ColourRepo>();
builder.Services.AddTransient<IArticleRepo, ArticleRepo>();
builder.Services.AddTransient<ISizeRepo, SizeRepo>();
builder.Services.AddTransient<ProductServices, ProductServices>();
builder.Services.AddTransient<ColourServices, ColourServices>();
builder.Services.AddTransient<ArticleServices, ArticleServices>();
builder.Services.AddTransient<SizeScaleServices, SizeScaleServices>();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API"));


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}