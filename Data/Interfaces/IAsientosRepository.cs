using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IAsientosRepository
    {
        List<Asientos> GetAll();
        List<Asientos> GetAllBySesionId(int sesionId);
        Asientos Get(int id);
        void Add(Asientos asiento);
        void Update(Asientos asiento);
        void Delete(int id);
    }
}