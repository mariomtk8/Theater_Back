using Microsoft.AspNetCore.Mvc;
using UrbanTheater.Models;
using UrbanTheater.Business;
using System.Collections.Generic;

namespace UrbanTheater.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FuncionesController : ControllerBase
    {
        private readonly FuncionesService _funcionService;

        public FuncionesController(FuncionesService funcionService)
        {
            _funcionService = funcionService;
        }


        [HttpGet]
        public ActionResult<List<Funciones>> GetAll() => _funcionService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Funciones> Get(int id)
        {
            var funciones = _funcionService.Get(id);

            if (funciones == null)
                return NotFound();

            return funciones;
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Funciones funcion)
        {
            if (id != funcion.ID)
                return BadRequest();

            var existingObra = _funcionService.Get(id);
            if (existingObra is null)
                return NotFound();

            _funcionService.Update(funcion);

            return NoContent();
        }

        [HttpPost]

        public ActionResult<Funciones> Create(Funciones funcion)
        {
            _funcionService.Add(funcion);

            return CreatedAtAction(nameof(Create), new { id = funcion.ID }, funcion);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingFuncion = _funcionService.Get(id);
            if (existingFuncion == null)
            {
                return NotFound();
            }

            _funcionService.Delete(id);

            return NoContent();
        }


        [HttpGet("{id}/Sesion/{Idsesion}")]
        public ActionResult<List<AsientosDTO>> GetSeat(int id, int Idsesion)
        {
            var asientosId = _funcionService.GetFuncionesAsientos(id, Idsesion);

            if (asientosId == null || asientosId.Count == 0)
            {
                return NotFound("No seats found for the given obra and session.");
            }

            return Ok(asientosId);
        }


        [HttpPost("{id}/Sesion/{Idsesion}/ReservarAsiento")]
        public IActionResult AddAsientosToSession(int id, int Idsesion, [FromBody] List<Asientos> ListadoAsientos)
        {
            if (ListadoAsientos == null || ListadoAsientos.Count == 0)
            {
                return BadRequest("Agrega los Asientos.");
            }

            foreach (var CatchAsiento in ListadoAsientos)
            {
                _funcionService.AddAsientoToFuncion(id, Idsesion, CatchAsiento.IdAsiento, CatchAsiento.IsFree);
            }
            return Ok("Asiento Añadido.");
        }
    }
}
