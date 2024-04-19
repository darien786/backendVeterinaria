namespace backendveterinaria.Models;

public class PersonaDTO 
{
    public int? personaId { get; set; }
    public required string? nombre { get; set; }
    public required string? apelllidoPaterno { get; set; }
    public required string? apellidoMaterno { get; set;}
    public required string? telefono { get; set;}
    public required string? tipoPersona { get; set; }
    public int[]? empleados { get; set; }

}
