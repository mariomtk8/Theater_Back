using UrbanTheater.Business;
using UrbanTheater.Models;
using UrbanTheater.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var keyString = "ServerDB_Local";
var connectionString = builder.Configuration.GetConnectionString(keyString);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

   builder.Services.AddDbContext<UrbanTheaterAppContext>(options =>
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5, // Número máximo de intentos
            maxRetryDelay: TimeSpan.FromSeconds(30), // Tiempo máximo de espera entre intentos
            errorNumbersToAdd: null); // Errores específicos para reintentos, null para los predeterminados
    }));

builder.Services.AddScoped<FuncionesService>();
builder.Services.AddScoped<IFuncionesRepository,FuncionesRepository>();

builder.Services.AddScoped<AsientosService>();
builder.Services.AddScoped<IAsientosRepository, AsientosRepository>();

builder.Services.AddScoped<UsuariosService>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();

builder.Services.AddScoped<AdminService>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", policy =>
    {
        policy.AllowAnyOrigin() // Permitir acceso desde cualquier origen
              .AllowAnyMethod() // Permitir cualquier método HTTP (GET, POST, PUT, etc.)
              .AllowAnyHeader(); // Permitir cualquier encabezado en la solicitud
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
