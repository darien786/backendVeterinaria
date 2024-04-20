using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Roles
{
    public int? rolesId { get; set; }
    public required string? nombre_rol { get; set; }

    [JsonIgnore]
    public ICollection<Empleados>? empleados { get; set; } 
}