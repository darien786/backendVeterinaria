namespace backendveterinaria.Models;

public class PersonasDTO 
{
    public int? personasId { get; set; }
    public required string? nombre { get; set; }
    public required string? apelllido_paterno { get; set; }
    public required string? apellido_materno { get; set;}
    public required string? telefono { get; set;}
    public required string? tipo_persona { get; set; }
    public int[]? empleados { get; set; }

}
