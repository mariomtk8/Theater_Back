﻿using System.ComponentModel.DataAnnotations.Schema; // Importa este espacio de nombres
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
    public DateTime FechaUno { get; set; }
    public DateTime FechaDos { get; set; }
    public DateTime FechaTres { get; set; }
    public string Cartel { get; set; }

}
