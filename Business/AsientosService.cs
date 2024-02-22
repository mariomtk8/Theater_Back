using UrbanTheater.Models;
using UrbanTheater.Data;
using System.Collections.Generic;

namespace UrbanTheater.Business
{
    public class AsientosService : IAsientosService
{
    private readonly IAsientosRepository _asientosRepository;

    public AsientosService(IAsientosRepository asientosRepository)
    {
        _asientosRepository = asientosRepository;
    }

    public IEnumerable<AsientoReadDTO> GetAsientosBySesionId(int sesionId)
    {
        var asientos = _asientosRepository.GetAsientosBySesionId(sesionId);
        return asientos.Select(a => new AsientoReadDTO
        {
            IdAsiento = a.IdAsiento,
            IsFree = a.IsFree,
            IdSesion = a.IdSesion
        }).ToList();
    }

    public AsientoReadDTO Get(int id)
    {
        var asiento = _asientosRepository.Get(id);
        if (asiento == null) return null;
        return new AsientoReadDTO
        {
            IdAsiento = asiento.IdAsiento,
            IsFree = asiento.IsFree,
            IdSesion = asiento.IdSesion
        };
    }

    public void Add(AsientoCreateUpdateDTO asientoDto)
    {
        var newAsiento = new Asientos
        {
            IsFree = asientoDto.IsFree,
            IdSesion = asientoDto.IdSesion
        };
        _asientosRepository.Add(newAsiento);
    }

    public void Update(int id, AsientoCreateUpdateDTO asientoDto)
    {
        var asiento = _asientosRepository.Get(id);
        if (asiento != null)
        {
            asiento.IsFree = asientoDto.IsFree;
            // asiento.IdSesion = asientoDto.IdSesion; // Consider if updating session ID is allowed
            _asientosRepository.Update(asiento);
        }
    }

    public void Delete(int id)
    {
        _asientosRepository.Delete(id);
    }
}
}