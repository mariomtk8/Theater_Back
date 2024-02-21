using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UrbanTheater.Models;
public class Sesiones
{
    [Key]
    public int IdSesion { get; set; }
    public int ID { get; set; }
    [ForeignKey("ID")]
    public virtual Funciones Funcion { get; set; }
    public DateTime Fecha { get; set; }
    public virtual ICollection<Asientos> Asientos { get; set; } = new List<Asientos>();
}