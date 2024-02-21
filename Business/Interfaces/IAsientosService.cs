using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IAsientosService
    {
        List<Asientos> GetAllBySesionId(int sesionId);
        Asientos Get(int id);
        void Update(Asientos asiento);
    }
}