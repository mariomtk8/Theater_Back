using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace UrbanTheater.Models;

public class AsientosFunciones
{
    public AsientosFunciones() { }

    [Key]
    public int ID { get; set; }
    public int IdFuncion { get; set; }
    public int IdSesion { get; set; }
    public int IdAsiento { get; set; }
    public bool IsFree { get; set; }
}
