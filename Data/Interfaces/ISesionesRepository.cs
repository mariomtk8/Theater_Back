using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface ISesionesRepository
    {
        List<Sesiones> GetAll();
        List<Sesiones> GetAllByFuncionId(int funcionId);
        Sesiones Get(int id);
        void Add(Sesiones sesion);
        void Update(Sesiones sesion);
        void Delete(int id);
    }
}