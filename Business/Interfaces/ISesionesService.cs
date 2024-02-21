using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface ISesionesService
    {
        List<Sesiones> GetAllByFuncionId(int funcionId);
        Sesiones Get(int id);
        void Update(Sesiones sesion);
    }
}