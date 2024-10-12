using Commands.Application;
using Commands.Application.Commands.SaveProduct;
using Commands.Infrastructure.Contexts;
using Commands.Infrastructure.Interfaces;
using Commands.Infrastructure.Providers;
using Commands.Infrastructure.Services;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrueCode.API.Behaviors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCommands();

builder.Services.AddDbContext<SQLContext>(option => 
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.CustomSchemaIds(type => type.FullName);
});

builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

builder.Services.AddScoped<IRepositoryProvider, RepositoryProvider>();
builder.Services.AddScoped<IFileStorageService, FileStorageService>(service =>
    new FileStorageService(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads")));

var app = builder.Build();

app.UseCors("AllowAll");

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<SQLContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseStaticFiles();

app.Run();