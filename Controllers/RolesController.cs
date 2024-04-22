
using backendVeterinaria.Data;
using backendVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendVeterinaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    private readonly DataContext _context;

    public RolesController(DataContext context)
    {
        _context = context;
    }

    //GET: api/roles
    [HttpGet]
    public async Task<ActionResult<List<Roles>>> Get()
    {
        return await _context.Roles.AsNoTracking().ToListAsync();
    }

}