using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IFuncionesService
    {
        List<Funciones> GetAll();
        Funciones Get(int id);
        void Update(Funciones funcion);
        void Add(Funciones obra);
        void Delete(int id);
        List<int> GetFuncionesAsientos(int FuncionID, int IdSesion);
        void AddAsientoToFuncion(int funcionId, int sessionId, int idAsiento, bool isFree);
    }
}