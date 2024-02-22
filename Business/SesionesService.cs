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

    public List<SesionesReadDTO> GetAllByFuncionId(int funcionId)
    {
        var sesiones = _sesionesRepository.GetAllByFuncionId(funcionId);
        return sesiones.Select(s => new SesionesReadDTO
        {
            IdSesion = s.IdSesion,
            FuncionId = s.ID,
            Fecha = s.Fecha
        }).ToList();
    }

    public SesionesReadDTO Get(int id)
    {
        var sesion = _sesionesRepository.Get(id);
        if (sesion == null) return null;

        return new SesionesReadDTO
        {
            IdSesion = sesion.IdSesion,
            FuncionId = sesion.ID,
            Fecha = sesion.Fecha
        };
    }
    public List<Sesiones> GetAll() => _sesionesRepository.GetAll();

    // Implementa métodos para Add y Delete si es necesario, usando DTOs para la creación
}
}