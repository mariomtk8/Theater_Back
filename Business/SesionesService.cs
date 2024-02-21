using UrbanTheater.Models;
using UrbanTheater.Data;
using System.Collections.Generic;

namespace UrbanTheater.Business
{
    public class SesionesService : ISesionesService
{
    private readonly ISesionesRepository _sesionesRepository;

    public SesionesService(ISesionesRepository sesionesRepository)
    {
        _sesionesRepository = sesionesRepository;
    }

    public List<Sesiones> GetAllByFuncionId(int funcionId)
    {
        return _sesionesRepository.GetAllByFuncionId(funcionId);
    }

    public Sesiones Get(int id)
    {
        return _sesionesRepository.Get(id);
    }

    public void Update(Sesiones sesion)
    {
        _sesionesRepository.Update(sesion);
    }
}
}