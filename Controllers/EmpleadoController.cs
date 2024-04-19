using System.Data.Common;
using backendVeterinaria.Data;
using backendVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendVeterinaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpleadoController : ControllerBase
{
    private readonly DataContext _context;

}