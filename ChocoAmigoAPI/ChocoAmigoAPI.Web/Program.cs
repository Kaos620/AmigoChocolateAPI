using ChochoAmigoAPI.Service.AutoMapper;
using ChochoAmigoAPI.Service.Interfaces;
using ChochoAmigoAPI.Service.Services;
using ChocoAmigo.Repository.EntityFramework;
using ChocoAmigo.Repository.EntityFramework.Configurations;
using ChocoAmigoAPI.Repository.Interface;
using ChocoAmigoAPI.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true; // Configura os URLs para serem minúsculos
});

var y = builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));


builder.Services.AddScoped<Contexto>();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoService, GrupoService>();

builder.Services.AddScoped<IParticipanteGrupoRepository, ParticipanteGrupoRepository>();
builder.Services.AddScoped<IParticipanteGrupoService, ParticipanteGrupoService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin(); // Permitir solicitações de qualquer origem
    options.AllowAnyMethod(); // Permitir solicitações de qualquer método (GET, POST, etc.)
    options.AllowAnyHeader(); // Permitir qualquer cabeçalho na solicitação
});

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
