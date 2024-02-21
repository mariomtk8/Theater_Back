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
    private readonly AsientosService _asientosService;

    public AsientosController(AsientosService asientosService)
    {
        _asientosService = asientosService;
    }

    [HttpGet("{sesionId}")]
    public ActionResult<List<Asientos>> GetAllBySesionId(int sesionId)
    {
        return _asientosService.GetAllBySesionId(sesionId);
    }

    [HttpGet("asiento/{id}")]
    public ActionResult<Asientos> Get(int id)
    {
        var asiento = _asientosService.Get(id);

        if (asiento == null)
            return NotFound();

        return asiento;
    }

    // Métodos PUT, DELETE según sea necesario
}
}