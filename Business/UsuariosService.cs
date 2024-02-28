using UrbanTheater.Data;
using UrbanTheater.Models;

namespace UrbanTheater.Business
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuariosService(IUsuariosRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuarios Get(string nombreUsuario, string password)
        {
            return _usuarioRepository.Get(nombreUsuario, password);
        }

        public void AddUsuario(Usuarios usuario)
        {
            _usuarioRepository.AddUsuario(usuario);
        }
    }
}
