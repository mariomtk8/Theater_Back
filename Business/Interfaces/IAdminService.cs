using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IAdminService
    {
        Admin? Get(string nombre, string password);
    }
}