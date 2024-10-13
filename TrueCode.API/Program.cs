using Commands.Application;
using Commands.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Queries.Application;
using TrueCode.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server=mssql;Database=TrueCode;User Id=sa;Password=TrueCode2024@;TrustServerCertificate=True;";

Console.WriteLine(connectionString);

builder.Services.AddCommands(connectionString);
builder.Services.AddQueries(connectionString);

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

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();
app.UseStaticFiles();

app.Run();