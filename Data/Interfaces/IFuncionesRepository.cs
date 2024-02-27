using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IFuncionesRepository
    {
        List<Funciones> GetAll();
        Funciones Get(int id);
        void Update(Funciones funcion);
        void Add(Funciones funcion);
        void Delete(int id);
        List<int> GetFuncionesAsientos(int ObraID, int IdSesion);
        void AddAsientoToFuncion(int obraId, int sessionId, int idAsiento, bool isFree);
    }
}
