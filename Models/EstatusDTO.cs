
namespace backendveterinaria.Models;

public class EstatusDTO
{
    public int? estatusId { get; set; }
    public required string nombreEstatus { get; set; }
    public int[]? empleados { get; set; }
}