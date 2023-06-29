using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var conn = builder.Configuration.GetConnectionString("ConexaoMySQL"); //pegando a string de conexão do banco de dados
var serverVersion = new MySqlServerVersion("8.0"); //pegando a versão do banco de dados

// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseMySql(conn, serverVersion)
);

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
