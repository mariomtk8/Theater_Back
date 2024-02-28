using Microsoft.AspNetCore.Mvc;
using UrbanTheater.Models;
using UrbanTheater.Business;

namespace UrbanTheater.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuariosService _usuarioService;

        public UsuarioController(UsuariosService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{nombreUsuario}/Contrasena/{password}")]
        public ActionResult<Usuarios> GetUsuario(string nombreUsuario, string password)
        {
            var usuario = _usuarioService.Get(nombreUsuario, password);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult AddUsuario([FromBody] Usuarios usuarioRequest)
        {
            if (string.IsNullOrWhiteSpace(usuarioRequest.nombreUsuario) || string.IsNullOrWhiteSpace(usuarioRequest.password))
            {
                return BadRequest("Escribe el Usuario y Contraseña");
            }

            _usuarioService.AddUsuario(usuarioRequest);
            return CreatedAtAction(nameof(GetUsuario), new { nombreUsuario = usuarioRequest.nombreUsuario, password = usuarioRequest.password }, usuarioRequest);
        }
    }
}
