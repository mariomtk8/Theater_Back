using System.ComponentModel.DataAnnotations.Schema; 
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization; 
using System.Text.Json; 

namespace UrbanTheater.Models;

public class Funciones
{
    public Funciones() { }

    [Key]
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Autores { get; set; }
    public int Duracion { get; set; }
    public string Actores { get; set; }
    public string Imagenes { get; set; }
    public string Fechas { get; set; }
    public string Cartel { get; set; }
    public virtual ICollection<Sesiones> Sesiones { get; set; } = new List<Sesiones>();

    
    [NotMapped]
    public string[] AutoresArray
    {
        get => JsonSerializer.Deserialize<string[]>(Autores);
        set => Autores = JsonSerializer.Serialize(value);
    }

    [NotMapped]
    public string[] ActoresArray
    {
        get => JsonSerializer.Deserialize<string[]>(Actores);
        set => Actores = JsonSerializer.Serialize(value);
    }

    [NotMapped]
    public string[] ImagenesArray
    {
        get => JsonSerializer.Deserialize<string[]>(Imagenes);
        set => Imagenes = JsonSerializer.Serialize(value);
    }

    [NotMapped]
    public string[] FechasArray
    {
        get => JsonSerializer.Deserialize<string[]>(Fechas);
        set => Fechas = JsonSerializer.Serialize(value);
    }
}
