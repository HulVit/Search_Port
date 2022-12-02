System.Console.WriteLine("Version 0.0.1");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/gettest", () =>
{
    return "GET Tested!";
});

app.MapPost("/posttest", () =>
{
    return "POST Tested!";
});

app.Run();

