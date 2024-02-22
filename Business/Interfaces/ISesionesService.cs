using System.Collections.Generic;
using UrbanTheater.Models; 

namespace UrbanTheater.Business
{
    public interface ISesionesService
    {
        List<SesionesReadDTO> GetAllByFuncionId(int funcionId); // Usa DTOs aquí
        SesionesReadDTO Get(int id);
    }
}