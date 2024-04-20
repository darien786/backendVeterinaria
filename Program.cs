using Microsoft.EntityFrameworkCore;
using backendVeterinaria.Data;

var builder = WebApplication.CreateBuilder(args);

var conexionBD = builder.Configuration.GetConnectionString("DataContext");
builder.Services.AddDbContext<DataContext>(options => {
    options.UseNpgsql(conexionBD);
    }
);

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy.WithOrigins("http://localhost:3001", "https://localhost:8080")
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .WithMethods("GET");
    });
});

builder.Services.AddControllers();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseCors();

app.MapControllers();
app.Run();
