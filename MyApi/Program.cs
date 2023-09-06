using MyApi.Repositories;
using MyApi.Repositories.Interfaces;
using MyApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Mappings();

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


void Mappings()
{
    //Repository
    builder.Services.AddSingleton<ICepRepository, CepRepository>();
    builder.Services.AddSingleton<IInvertextoRepository, InvertextoRepository>();

    //Services
    builder.Services.AddSingleton<CepService, CepService>();
    builder.Services.AddSingleton<CpfCnpjService, CpfCnpjService>();
}


