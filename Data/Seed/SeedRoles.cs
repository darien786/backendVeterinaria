using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backendVeterinaria.Models;

namespace backendVeterinaria.Data.Seed;

public class SeedRoles : IEntityTypeConfiguration<Roles>
{
    public void Configure(EntityTypeBuilder<Roles> builder)
    {
        builder.HasData(
            new Roles { rolesId = 1, nombre_rol = "Comercial"},
            new Roles { rolesId = 2, nombre_rol = "General"}
        );
    }
}

