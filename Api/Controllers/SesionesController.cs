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
    private readonly SesionesService _sesionesService;

    public SesionesController(SesionesService sesionesService)
    {
        _sesionesService = sesionesService;
    }

    [HttpGet("{funcionId}")]
    public ActionResult<List<Sesiones>> GetAllByFuncionId(int funcionId)
    {
        return _sesionesService.GetAllByFuncionId(funcionId);
    }

    [HttpGet("sesion/{id}")]
    public ActionResult<Sesiones> Get(int id)
    {
        var sesion = _sesionesService.Get(id);

        if (sesion == null)
            return NotFound();

        return sesion;
    }

    // Métodos PUT, DELETE según sea necesario
}
}