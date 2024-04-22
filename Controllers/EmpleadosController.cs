using System.Data.Common;
using backendVeterinaria.Data;
using backendVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendVeterinaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpleadosController : ControllerBase
{
    private readonly DataContext _context;

    public EmpleadosController(DataContext context)
    {
        _context = context;
    }

    //GET: api/empleados
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmpleadosDTO>>> Get()
    {
        return await _context.Empleados
            .Select(x => obtenerEmpleado(x))
            .ToListAsync();
    }

    //GET: api/empleados/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Empleados>> Get(int id)
    {
        var empleados = await _context.Empleados.FindAsync(id);

        if (empleados == null)
        {
            return NotFound();
        }

        return empleados;
    }

    private static EmpleadosDTO obtenerEmpleado(Empleados empleados) => 
    new EmpleadosDTO 
    {
        empleadosId = empleados.empleadosId,
        sexo = empleados.sexo,
        curp = empleados.curp,
        correo = empleados.correo,
        username = empleados.username,
        password = empleados.password,
        fecha_ingreso = empleados.fecha_ingreso,
        fecha_baja = empleados.fecha_baja,
        estatusId = empleados.estatusId,
        personasId = empleados.personasId,
        rolesId = empleados.rolesId
    };
}