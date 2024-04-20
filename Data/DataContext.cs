using backendVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using backendVeterinaria.Data.Seed;

namespace backendVeterinaria.Data;

public class DataContext : DbContext{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Estatus> Estatus { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Personas> Personas { get; set; }
    public DbSet<Empleados> Empleados { get; set; }

    protected override void  OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedEstatus());
        modelBuilder.ApplyConfiguration(new SeedRoles());
    }
}