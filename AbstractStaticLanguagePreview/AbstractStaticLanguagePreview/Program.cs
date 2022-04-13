using AbstractStaticLanguagePreview.Extensions;
using AbstractStaticLanguagePreview.Models.Options;

var builder = WebApplication.CreateBuilder(args);

var environmentName = builder.Environment.EnvironmentName;

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("nexi.json", optional: false)
    .AddJsonFile("paypal.json", optional: false)
    .AddJsonFile("serilog.json", optional: false)
    .AddJsonFile("AS400.json", optional: false)
    .AddJsonFile("redis.json", optional: false)
    .AddJsonFile($"nexi.{environmentName}.json", optional: true)
    .AddJsonFile($"paypal.{environmentName}.json", optional: true)
    .AddJsonFile($"serilog.{environmentName}.json", optional: true)
    .AddJsonFile($"AS400.{environmentName}.json", optional: true)
    .AddJsonFile($"redis.{environmentName}.json", optional: true)
    .AddEnvironmentVariables();

builder.Services
    .ConfigureOptions<NexiOptions>(builder)
    .ConfigureOptions<PayPalOptions>(builder)
    .ConfigureDbContext(builder.GetOptions<AS400Options>())
    .ConfigureRedis(builder.GetOptions<RedisOptions>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
