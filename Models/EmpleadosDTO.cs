namespace backendVeterinaria.Models;

public class EmpleadosDTO
{
    public int? empleadosId { get; set; }
    public required string curp { get; set; }
    public required string sexo { get; set; }
    public required string correo { get; set; }
    public required string username { get; set; }
    public required string password { get; set; }
    public required string fecha_ingreso { get; set; }
    public string fecha_baja { get; set; }
    public int estatusId { get; set; }
    public int personasId { get; set; }
    public int rolesId { get; set; }

}