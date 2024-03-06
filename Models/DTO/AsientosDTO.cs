using System.ComponentModel.DataAnnotations;

namespace UrbanTheater.Models;

public class AsientosDTO
{
    public AsientosDTO() { }
    public List<int> asientos { get; set; }
    public int price { get; set; }
}



