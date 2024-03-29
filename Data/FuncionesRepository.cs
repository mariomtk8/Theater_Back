﻿using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;
using System.Collections.Generic;
using System.Linq;

namespace UrbanTheater.Data
{
    public class FuncionesRepository : IFuncionesRepository
    {
        private readonly UrbanTheaterAppContext _context;

        public FuncionesRepository(UrbanTheaterAppContext context)
        {
            _context = context;
        }

        public List<Funciones> GetAll()
        {
          
            return _context.Funciones.ToList();
        }

        public Funciones Get(int id)
        {
            return _context.Funciones.AsNoTracking().FirstOrDefault(funciones => funciones.ID == id);
        }

        public void Add(Funciones funciones)
        {
            _context.Funciones.Add(funciones);
            _context.SaveChanges();
        }

        public void Update(Funciones funcion)
        {
            _context.Entry(funcion).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var funcion = _context.Funciones.FirstOrDefault(funciones => funciones.ID == id);
            _context.Funciones.Remove(funcion);
            _context.SaveChanges();
        }

        public List<int> GetFuncionesAsientos(int FuncionID, int IdSesion)
        {
            var asientosId = _context.AsientosFunciones
                .Where(id => id.IdFuncion == FuncionID && id.IdSesion == IdSesion)
                .Select(p => p.IdAsiento) 
                .ToList(); 

            return asientosId; 
        }


        public void AddAsientoToFuncion(int funcionId, int sesionId, int idAsiento)
        {
            var nuevoAsiento = new AsientosFunciones
            {
                IdFuncion = funcionId,
                IdSesion = sesionId,
                IdAsiento = idAsiento,
                
            };

            _context.AsientosFunciones.Add(nuevoAsiento);
            _context.SaveChanges();
        }
    }

}
