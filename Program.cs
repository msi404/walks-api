using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Test.Data;
using Test.Mappings;
using Test.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<TestDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TestConncetionString")));
builder.Services.AddScoped<IRegionRepository, SQLRegionRepository>();
builder.Services.AddScoped<IWalkRepository, SQLWalkRepository>();
builder.Services.AddAutoMapper(cgf =>
{
    cgf.AddProfile<AutoMapperProfiles>();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
};

app.MapScalarApiReference();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
