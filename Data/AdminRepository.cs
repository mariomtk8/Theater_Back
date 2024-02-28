using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;


namespace UrbanTheater.Data
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UrbanTheaterAppContext _context;

        public AdminRepository(UrbanTheaterAppContext context)
        {
            _context = context;
        }

        public Administrador Get(string nombre, string password)
        {
            return _context.Administradores.AsNoTracking().FirstOrDefault(admin => admin.nombreAdministrador == nombre && admin.password == password);
        }
    }
}
