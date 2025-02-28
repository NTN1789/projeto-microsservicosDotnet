using DevFreela.Application.Services.Implementations;
using DevFreela.Application.Services.interfaces;
using DevFreela.infrastructure.Persistence;
using project_estudo.src.Models;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<OpeningTimeOption>

//builder.Services.AddDbContext<DevFreelaDbContext>();
builder.Services.AddSingleton<DevFreelaDbContext>();
builder.Services.AddScoped<IProjectService,ProjectService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
