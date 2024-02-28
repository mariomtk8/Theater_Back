using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Business
{
    public interface IUsuariosService
    {
        Usuario Get(string nombreUsuario, string password);
        void AddUsuario(Usuario usuario);
    }
}