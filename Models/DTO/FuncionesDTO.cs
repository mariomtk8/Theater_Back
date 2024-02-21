using System.ComponentModel.DataAnnotations;


namespace UrbanTheater.Models;

public class ObrasDTO
{
    public ObrasDTO() { }

    [Key]
    public int IdObjeto { get; set; }
    public int IdFuncion { get; set; }
    public int IdAsiento { get; set; }
    public bool IsFree { get; set; }
}