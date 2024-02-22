using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IAsientosRepository
{
    IEnumerable<Asientos> GetAsientosBySesionId(int sesionId);
    Asientos Get(int id);
    void Add(Asientos asiento);
    void Update(Asientos asiento);
    void Delete(int id);
}
}