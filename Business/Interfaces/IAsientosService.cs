using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface IAsientosService
{
    IEnumerable<AsientoReadDTO> GetAsientosBySesionId(int sesionId);
    AsientoReadDTO Get(int id);
    void Add(AsientoCreateUpdateDTO asientoDto);
    void Update(int id, AsientoCreateUpdateDTO asientoDto);
    void Delete(int id);
}
}