using System.ComponentModel.DataAnnotations;


namespace UrbanTheater.Models;

public class Asientos
{
    public Asientos() { }

    [Key]
    public int IdAsiento { get; set; }
    public bool IsFree { get; set; }

}
