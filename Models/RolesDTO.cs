namespace backendVeterinaria.Models;

public class RolesDTO
{
    public int? rolesId { get; set; }
    public required string nombre_rol { get; set; }
    public int[]? empleados { get; set; }
}