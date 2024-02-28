using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly UrbanTheaterAppContext _context;

        public UsuariosRepository(UrbanTheaterAppContext context)
        {
            _context = context;
        }

        public Usuarios Get(string nombreUsuario, string password)
        {
            var usuario = _context.Usuarios
                                  .Where(u => u.nombreUsuario == nombreUsuario && u.password == password)
                                  .ToList()
                                  .FirstOrDefault();

            return usuario;
        }


        public void AddUsuario(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
    }
}
