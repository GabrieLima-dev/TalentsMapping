using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Definir a porta HTTPS explicitamente
builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = 5003; // Substitua pela porta HTTPS que voc� deseja usar
});

// Configura��o do Kestrel para escutar em portas espec�ficas
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5002); // Porta para HTTP
    options.ListenLocalhost(5003, listenOptions => listenOptions.UseHttps()); // Porta para HTTPS
});

// Configura��o do DbContext com a string de conex�o
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilite o redirecionamento para HTTPS apenas em produ��o
if (app.Environment.IsProduction())
{
    app.UseHttpsRedirection();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();