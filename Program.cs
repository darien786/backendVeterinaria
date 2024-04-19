using Microsoft.EntityFrameworkCore;
using backendVeterinaria.Data;

var builder = WebApplication.CreateBuilder(args);

var conexionBD = builder.Configuration.GetConnectionString("DataContext");
builder.Services.AddDbContext<DataContext>(options => {
    options.UseNpgsql(conexionBD);
}
);


var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.Run();
