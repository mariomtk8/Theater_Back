using UrbanTheater.Models;
using UrbanTheater.Data;

namespace UrbanTheater.Business
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _administradorRepository;

        public AdminService(IAdminRepository administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        public Administrador? Get(string nombre, string password) =>
            _administradorRepository.Get(nombre, password);
    }
}
