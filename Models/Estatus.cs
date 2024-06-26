using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Estatus
{
    // 
    public int estatusId { get; set; }
    public required string nombre_estatus { get; set; }

    [JsonIgnore]
    public ICollection<Empleados>? empleados { get; set; } 
}