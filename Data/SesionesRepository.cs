using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;
using System.Collections.Generic;
using System.Linq;

namespace UrbanTheater.Data
{
    public class SesionesRepository : ISesionesRepository
{
    private readonly UrbanTheaterAppContext _context;

    public SesionesRepository(UrbanTheaterAppContext context)
    {
        _context = context;
    }

    public List<Sesiones> GetAll()
    {
        return _context.Sesiones.Include(s => s.Asientos).ToList();
    }

    public List<Sesiones> GetAllByFuncionId(int funcionId)
    {
        return _context.Sesiones.Where(s => s.ID == funcionId).Include(s => s.Asientos).ToList();
    }

    public Sesiones Get(int id)
    {
        return _context.Sesiones.Include(s => s.Asientos).FirstOrDefault(s => s.IdSesion == id);
    }

    public void Add(Sesiones sesion)
    {
        _context.Sesiones.Add(sesion);
        _context.SaveChanges();
    }

    public void Update(Sesiones sesion)
    {
        _context.Entry(sesion).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var sesion = _context.Sesiones.Find(id);
        if (sesion != null)
        {
            _context.Sesiones.Remove(sesion);
            _context.SaveChanges();
        }
    }
}
}