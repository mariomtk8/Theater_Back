using System.ComponentModel.DataAnnotations;

namespace UrbanTheater.Models;

public class Admin
{
    public Admin() { }
    [Key]
    public int idAdministrador { get; set; }
    public string nombreAdministrador { get; set; }
    public string password { get; set; }
}
