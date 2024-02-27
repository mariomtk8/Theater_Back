using System.ComponentModel.DataAnnotations;


namespace UrbanTheater.Models;

public class FuncionesDTO
{
    public FuncionesDTO() { }

    [Key]
    public int ID { get; set; }
    public int IdFuncion { get; set; }
    public int IdSesion { get; set; }
    public int IdAsiento { get; set; }
    public bool IsFree { get; set; }
}