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

    public List<Asientos> GetAllBySesionId(int sesionId)
    {
        return _asientosRepository.GetAllBySesionId(sesionId);
    }

    public Asientos Get(int id)
    {
        return _asientosRepository.Get(id);
    }

    public void Update(Asientos asiento)
    {
        _asientosRepository.Update(asiento);
    }
}
}