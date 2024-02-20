using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IFuncionesService
    {
        List<Funciones> GetAll();
        Funciones Get(int id);
        void Update(Funciones funcion);
    }
}