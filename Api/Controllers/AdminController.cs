using Microsoft.AspNetCore.Mvc;
using UrbanTheater.Models;
using UrbanTheater.Business;
using System;

namespace UrbanTheater.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly AdminService _administradorService;

        public AdminController(AdminService administradorService)
        {
            _administradorService = administradorService;
        }


        [HttpGet("{nombreUsuario}/Contrasena/{password}")]
        public ActionResult<Administrador> GetUsuario(string nombreUsuario, string password)
        {
            var administrador = _administradorService.Get(nombreUsuario, password);
            if (administrador == null)
            {
                return NotFound();
            }
            return Ok(administrador);
        }
    

    }
}