using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IAdminRepository
    {
        Admin? Get(string admin, string password);
    }
}
