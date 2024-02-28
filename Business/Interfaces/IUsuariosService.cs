using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Business
{
    public interface IUsuariosService
    {
        Usuarios Get(string nombreUsuario, string password);
        void AddUsuario(Usuarios usuario);
    }
}