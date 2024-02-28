using System.ComponentModel.DataAnnotations;

namespace UrbanTheater.Models;

public class Usuarios
{
    public Usuarios() { }
    [Key]
    public int idUsuario { get; set; }
    public string nombreUsuario { get; set; }
    public string password { get; set; }
}