using Domains.Data;
using E_commerce.AutoMapper;
using E_commerce.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.


builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

System.Reflection.Assembly[] objMapperProfiles = {
        typeof(MappingProfile).Assembly
    };
builder.Services.AddAutoMapper(objMapperProfiles);
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

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
