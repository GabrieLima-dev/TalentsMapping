using Microsoft.EntityFrameworkCore;
using MinhaApi.Data; // Altere para o namespace correto do seu ApplicationDbContext

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext com a string de conexão
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona os serviços de controlador para a API
builder.Services.AddControllers();

// Configuração do Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Habilitar mapeamento dos controllers para endpoints da API
app.MapControllers();

app.Run();