
namespace backendVeterinaria.Models;

public class Empleado{
    
    public int empleadoId { get; set; }
    public required string curp { get; set; }
    public required string sexo { get; set; }
    public required string correo { get; set; }
    public required string fechaIngreso { get; set; }
    public string fechaBaja { get; set; } 
    
}