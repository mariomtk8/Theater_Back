using Microsoft.AspNetCore.Mvc;
using UrbanTheater.Models;
using UrbanTheater.Business;
using System.Collections.Generic;

namespace UrbanTheater.Controllers
{
    [ApiController]
[Route("[controller]")]
public class SesionesController : ControllerBase
{
    private readonly ISesionesService _sesionesService;

    public SesionesController(ISesionesService sesionesService)
    {
        _sesionesService = sesionesService;
    }

    [HttpGet("{funcionId}")]
    public ActionResult<List<SesionesReadDTO>> GetAllByFuncionId(int funcionId)
    {
        var sesiones = _sesionesService.GetAllByFuncionId(funcionId);
        if (sesiones == null) return NotFound();
        return Ok(sesiones);
    }

    [HttpGet("sesion/{id}")]
    public ActionResult<SesionesReadDTO> Get(int id)
    {
        var sesion = _sesionesService.Get(id);
        if (sesion == null) return NotFound();
        return Ok(sesion);
    }

    // Agrega endpoints para POST y DELETE si es necesario, usando DTOs
}
}