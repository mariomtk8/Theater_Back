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
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<FuncionesService>();
builder.Services.AddScoped<IFuncionesRepository,FuncionesRepository>();



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
