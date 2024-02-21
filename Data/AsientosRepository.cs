using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;
using System.Collections.Generic;
using System.Linq;

namespace UrbanTheater.Data
{
    public class AsientosRepository : IAsientosRepository
{
    private readonly UrbanTheaterAppContext _context;

    public AsientosRepository(UrbanTheaterAppContext context)
    {
        _context = context;
    }

    public List<Asientos> GetAll()
    {
        return _context.Asientos.ToList();
    }

    public List<Asientos> GetAllBySesionId(int sesionId)
    {
        return _context.Asientos.Where(a => a.IdSesion == sesionId).ToList();
    }

    public Asientos Get(int id)
    {
        return _context.Asientos.FirstOrDefault(a => a.IdAsiento == id);
    }

    public void Add(Asientos asiento)
    {
        _context.Asientos.Add(asiento);
        _context.SaveChanges();
    }

    public void Update(Asientos asiento)
    {
        _context.Entry(asiento).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var asiento = _context.Asientos.Find(id);
        if (asiento != null)
        {
            _context.Asientos.Remove(asiento);
            _context.SaveChanges();
        }
    }
}
}