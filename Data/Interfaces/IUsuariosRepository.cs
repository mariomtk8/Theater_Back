using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IUsuariosRepository
    {
        Usuario Get(string nombreUsuario, string password);
        void AddUsuario(Usuario usuario);
    }
}
