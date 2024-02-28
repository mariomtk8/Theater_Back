using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IAdminRepository
    {
        Administrador? Get(string admin, string password);
    }
}
