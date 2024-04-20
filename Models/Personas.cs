using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Personas{
    public int personasId { get; set; }
    public required string nombre { get; set; }
    public required string apellido_paterno { get; set; }
    public required string apellido_materno { get; set; }
    public required string telefono { get; set; }
    public required string tipo_persona { get; set; } 

    [JsonIgnore]
    public ICollection<Empleados>? empleados { get; set; }
}