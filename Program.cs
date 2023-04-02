var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};


var products = new[]
{
    "bike", "car"
};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//});

app.MapGet("/product", () =>
    {
        var product = Enumerable.Range(1, 5).Select(index =>
        new Product
        (
            products[Random.Shared.Next(products.Length)]
        ))
        .ToArray();
        return product;
    });

//app.MapGet("/product", () => "Hello World!");

app.Run();

internal record Product(string product)
{
    // public string prod => "fufu";
}

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}