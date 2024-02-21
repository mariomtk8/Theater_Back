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

            var existingFuncion = _funcionService.Get(id);
            if (existingFuncion is null)
                return NotFound();

            _funcionService.Update(funcion);

            return NoContent();
        }
    }
}
