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
    }
}
