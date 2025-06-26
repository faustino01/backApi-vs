using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using backApi_vs.Filtros;
using backApi_vs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var frontendUrl = builder.Configuration["frontend_url"] ?? throw new Exception("La variable 'frontend_url' no está configurada.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => { policy.WithOrigins(frontendUrl).AllowAnyMethod().AllowAnyHeader(); });
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
builder.Services.AddResponseCaching();
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(FiltroDeExcepcion));
});
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

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
