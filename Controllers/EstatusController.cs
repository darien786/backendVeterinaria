using backendVeterinaria.Data;
using backendVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendVeterinaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstatusController : ControllerBase
{
    private readonly DataContext _context;

    public EstatusController(DataContext context)
    {
        _context = context;
    }

    public async Task<ActionResult<List<Estatus>>> Get()
    {
        return await _context.Estatus.AsNoTracking().ToListAsync();
    }
}