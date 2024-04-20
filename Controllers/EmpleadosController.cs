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
    public async Task<ActionResult<List<Empleados>>> Get()
    {
        return await _context.Empleados.AsNoTracking().ToListAsync();
    }


}