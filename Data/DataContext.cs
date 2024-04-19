using backendVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using backendVeterinaria.Data.Seed;

namespace backendVeterinaria.Data;

public class DataContext : DbContext{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Estatus> Estatus { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<Persona> Persona { get; set; }
    public DbSet<Empleado> Empleado { get; set; }

    protected override void  OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedEstatus());
        modelBuilder.ApplyConfiguration(new SeedRol());
    }
}