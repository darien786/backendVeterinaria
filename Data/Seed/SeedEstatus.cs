using backendVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendVeterinaria.Data.Seed;

public class SeedEstatus : IEntityTypeConfiguration<Estatus>
{
    public void Configure(EntityTypeBuilder<Estatus> builder)
    {
        builder.HasData(
            new Estatus{ estatusId = 1, nombreEstatus = "Activo" },
            new Estatus{ estatusId = 2, nombreEstatus = "Inactivo" }
        );
    }
}