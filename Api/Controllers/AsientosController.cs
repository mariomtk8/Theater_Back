using Microsoft.AspNetCore.Mvc;
using UrbanTheater.Models;
using UrbanTheater.Business;
using System.Collections.Generic;

namespace UrbanTheater.Controllers
{
    [ApiController]
[Route("[controller]")]
public class AsientosController : ControllerBase
{
    private readonly IAsientosService _asientosService;

    public AsientosController(IAsientosService asientosService)
    {
        _asientosService = asientosService;
    }

    [HttpGet("BySesion/{sesionId}")]
    public ActionResult<IEnumerable<AsientoReadDTO>> GetAsientosBySesionId(int sesionId)
    {
        var asientos = _asientosService.GetAsientosBySesionId(sesionId);
        if (asientos == null) return NotFound();
        return Ok(asientos);
    }

    [HttpGet("{id}")]
    public ActionResult<AsientoReadDTO> Get(int id)
    {
        var asiento = _asientosService.Get(id);
        if (asiento == null) return NotFound();
        return Ok(asiento);
    }

    // Implementa endpoints para POST, PUT, DELETE según necesidad...
}
}