namespace backendVeterinaria.Models;

public class RolDTO
{
    public int? rolId { get; set; }
    public required string nombreRol { get; set; }
    public int[]? empleados { get; set; }
}