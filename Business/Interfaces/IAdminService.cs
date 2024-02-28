using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IAdminService
    {
        Administrador? Get(string nombre, string password);
    }
}