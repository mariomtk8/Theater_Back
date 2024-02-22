using UrbanTheater.Business;
using UrbanTheater.Models;
using UrbanTheater.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var isRunningInDocker = Environment.GetEnvironmentVariable("DOCKER_CONTAINER") == "true";
var keyString = isRunningInDocker ? "ServerDB_Docker" : "ServerDB_Local";
var connectionString = builder.Configuration.GetConnectionString(keyString);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<UrbanTheaterAppContext>(options =>
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5, // Número máximo de reintentos antes de fallar definitivamente
            maxRetryDelay: TimeSpan.FromSeconds(30), // Tiempo de espera entre reintentos
            errorNumbersToAdd: null); // Conjunto opcional de números de error para considerar como fallos transitorios
    }));

builder.Services.AddScoped<IFuncionesService, FuncionesService>();
builder.Services.AddScoped<IFuncionesRepository, FuncionesRepository>();

builder.Services.AddScoped<ISesionesService, SesionesService>();
builder.Services.AddScoped<ISesionesRepository, SesionesRepository>();

builder.Services.AddScoped<IAsientosService, AsientosService>();
builder.Services.AddScoped<IAsientosRepository, AsientosRepository>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });



builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:9000")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("MyCorsPolicy");
//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
