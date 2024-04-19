using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Estatus
{
    // 
    public int estatusId { get; set; }
    public required string nombreEstatus { get; set; }

    [JsonIgnore]
    public ICollection<Empleado>? empleados { get; set; } 
}