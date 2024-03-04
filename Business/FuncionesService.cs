using UrbanTheater.Models;
using UrbanTheater.Data;
using System.Collections.Generic;

namespace UrbanTheater.Business
{
    public class FuncionesService :IFuncionesService
    {
        private readonly IFuncionesRepository _funcionesRepository;

        public FuncionesService(IFuncionesRepository funcionesRepository)
        {
            _funcionesRepository = funcionesRepository;
        }

        public List<Funciones> GetAll() => _funcionesRepository.GetAll();
        public Funciones? Get(int id) => _funcionesRepository.Get(id);
        public void Update(Funciones funciones) => _funcionesRepository.Update(funciones);
        public void Add(Funciones obra) => _funcionesRepository.Add(obra);
        public void Delete(int id) => _funcionesRepository.Delete(id);

        //-------------Asientos------------------------------------------------//

        public List<int> GetFuncionesAsientos(int FuncionID, int IdSesion)
        {
            return _funcionesRepository.GetFuncionesAsientos(FuncionID, IdSesion);
        }


        public void AddAsientoToFuncion(int funcionId, int sesionId, int idAsiento)
        {
            _funcionesRepository.AddAsientoToFuncion(funcionId, sesionId, idAsiento);
        }
    }
}
