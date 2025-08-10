using ConectDatabase.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona o DbContext, usando a string de conexão.
var connectionString = "Server=localhost;User Id=root;Password=sua_senha;Database=anime_db";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Adiciona o serviço de controllers.
builder.Services.AddControllers();

// Adiciona o serviço de autorização.
builder.Services.AddAuthorization();

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Adiciona o middleware de autorização.
app.UseAuthorization();

// Mapeia os controllers para as rotas da API.
app.MapControllers();

app.Run();