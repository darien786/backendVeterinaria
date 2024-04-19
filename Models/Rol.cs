using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Rol
{
    public int? rolId { get; set; }
    public required string? nombreRol { get; set; }

    [JsonIgnore]
    public ICollection<Empleado>? empleados { get; set; } 
}