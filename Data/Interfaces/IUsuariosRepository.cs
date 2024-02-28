using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IUsuariosRepository
    {
        Usuarios Get(string nombreUsuario, string password);
        void AddUsuario(Usuarios usuario);
    }
}
