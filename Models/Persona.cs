using System.Text.Json.Serialization;

namespace backendVeterinaria.Models;

public class Persona{
    public int personaId { get; set; }
    public required string nombre { get; set; }
    public required string apellidoPaterno { get; set; }
    public required string apellidoMaterno { get; set; }
    public required string telefono { get; set; }
    public required string tipoPersona { get; set; } 

    [JsonIgnore]
    public ICollection<Empleado>? empleados { get; set; }
}