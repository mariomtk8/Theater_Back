using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UrbanTheater.Models;

public class Asientos
{
    [Key]
    public int IdAsiento { get; set; }
    public int IdSesion { get; set; }
    [ForeignKey("IdSesion")]
     public Sesiones Sesion { get; set; }
    public bool IsFree { get; set; }
}
