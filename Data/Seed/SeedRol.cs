using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backendVeterinaria.Models;

namespace backendVeterinaria.Data.Seed;

public class SeedRol : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.HasData(
            new Rol { rolId = 1, nombreRol = "Comercial"},
            new Rol { rolId = 2, nombreRol = "General"}
        );
    }
}

