using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;
using System.Text.Json;
namespace UrbanTheater.Data
{
    public class UrbanTheaterAppContext : DbContext
    {
        public UrbanTheaterAppContext(DbContextOptions<UrbanTheaterAppContext> options)
            : base(options)
        {
        }

        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Asientos> Asientos { get; set; }
        public DbSet<AsientosFunciones> AsientosFunciones { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funciones>().HasData(
                    new Funciones
                    {
                        ID = 1,
                        Nombre = "Esperando a Godot",
                        Descripcion = "Una obra teatral absurda que sigue a dos personajes, Vladimir y Estragon, mientras esperan en un lugar desolado a alguien llamado Godot, explorando temas de la existencia, la alienación y la esperanza.",
                        Autores = JsonSerializer.Serialize(new string[] { "Samuel Beckett" }),
                        Duracion = 2,
                        Actores = JsonSerializer.Serialize(new string[] { "Alexander Montgomery", "Isabella Ramirez", "Benjamin Worthington", "Olivia Hawthorne", "Nathaniel Harrington" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Esperando-Godot/esperando-a-godot_FN.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Esperando-Godot/esperando-a-godot_FN2.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Esperando-Godot/una-escena-de-esperando-a-godot.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-03-03 - 21:00", "2024-03-09 - 22:00", "2024-03-18 - 23:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Esperando-Godot/esperando-a-godot.jpg"
                    },
                    new Funciones
                    {
                        ID = 2,
                        Nombre = "El Fantasma de la Ópera",
                        Descripcion = "Una icónica obra de teatro musical que narra la historia de un misterioso y desfigurado hombre conocido como el Fantasma, que vive en los pasadizos de la Ópera de París y se obsesiona con una joven y talentosa soprano, Christine.",
                        Autores = JsonSerializer.Serialize(new string[] { "Andrew Lloyd Webber", "Charles Hart", "Richard Stilgoe" }),
                        Duracion = 2,
                        Actores = JsonSerializer.Serialize(new string[] { "Sophia Anderson", "Daniel Blackwood", "Elena Rodriguez", "Nicholas Smith", "Isabella Johnson" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Fantasma-opera/fantasma-opera_FN.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Fantasma-opera/Fantasma-operea_FN2.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-01-07 - 20:30", "2024-01-12 - 21:00", "2024-01-22 - 19:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Fantasma-opera/fantasma-opera.jpg"
                    },
                    new Funciones
                    {
                        ID = 3,
                        Nombre = "Esto No Es Un Show",
                        Descripcion = "Un audaz espectáculo que desafía las convenciones, combinando elementos de teatro, danza y performance art. La trama sigue a un grupo ecléctico de artistas mientras exploran temas de identidad, realidad y percepción a través de actuaciones vanguardistas.",
                        Autores = JsonSerializer.Serialize(new string[] { "Valentina Moreno", "Carlos Ruiz" }),
                        Duracion = 1,
                        Actores = JsonSerializer.Serialize(new string[] { "Miguel Ángel Jiménez", "Laura González", "José Martín", "Carmen Sánchez", "Diego Torres" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Galder/galder2.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Galder/galder3.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-05-01 - 23:00", "2024-05-15 - 22:00", "2024-05-20 - 21:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Galder/Galder.jpeg"
                    },
                    new Funciones
                    {
                        ID = 4,
                        Nombre = "Hamlet",
                        Descripcion = "Una de las tragedias más emblemáticas de William Shakespeare, centrada en la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre. La obra explora temas complejos como la locura, la traición, la venganza y la moralidad.",
                        Autores = JsonSerializer.Serialize(new string[] { "William Shakespeare" }),
                        Duracion = 3,
                        Actores = JsonSerializer.Serialize(new string[] { "Alexander Knight", "Sarah Miller", "David Johnson", "Emily White", "Richard Brown" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Hamlet/hamlet_FN2.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Hamlet/hamlet_FN.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-06-01 - 18:30", "2024-06-06 - 19:00", "2024-06-10 - 22:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Hamlet/hamlet.jpg"
                    },
                    new Funciones
                    {
                        ID = 5,
                        Nombre = "El Rey León",
                        Descripcion = "Un musical espectacular basado en la famosa película animada de Disney. La historia sigue las aventuras de Simba, un joven león que debe enfrentar numerosos desafíos para reclamar su lugar como el legítimo rey de la sabana. El musical es conocido por su impresionante uso de disfraces, marionetas y efectos visuales para recrear el ambiente de África.",
                        Autores = JsonSerializer.Serialize(new string[] { "Irene Mecchi", "Jonathan Roberts", "Linda Woolverton" }),
                        Duracion = 2,
                        Actores = JsonSerializer.Serialize(new string[] { "Michael James", "Elizabeth Green", "Thomas Hill", "Rachel Adams", "William Parker" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Rey-Leon/reyleonIMG3.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Rey-Leon/reyLeonImg1.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Rey-Leon/reyleonIMG2.avif" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-07-01 - 21:00", "2024-07-10 - 19:00", "2024-07-20 - 20:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/Rey-Leon/reyLeon.webp"
                    },
                    new Funciones
                    {
                        ID = 6,
                        Nombre = "Bodas de sangre",
                        Descripcion = "Una comedia romántica contemporánea que sigue la historia de varias parejas que se preparan para sus respectivas bodas. La obra teje una trama llena de enredos amorosos, malentendidos cómicos y momentos de reflexión sobre las relaciones y el matrimonio.",
                        Autores = JsonSerializer.Serialize(new string[] { "Ana García", "Luis Hernández" }),
                        Duracion = 2,
                        Actores = JsonSerializer.Serialize(new string[] { "Elena Sánchez", "Carlos Pérez", "María López", "José Torres", "Laura Jiménez" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/BodasDeSangre/BodasDeSangre_NF2.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/BodasDeSangre/BodasDeSangre_NF.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-08-02 - 21:00", "2024-08-12 - 20:00", "2024-08-21 - 21:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/BodasDeSangre/BodasDeSangre.jpg"
                    },
                    new Funciones
                    {
                        ID = 7,
                        Nombre = "B-Vocal",
                        Descripcion = "Un aclamado grupo vocal que destaca por su habilidad para fusionar a cappella y comedia en sus actuaciones. B-Vocal cautiva al público con su mezcla única de música, humor y la sorprendente habilidad de crear sonidos instrumentales con sus voces, explorando diversos géneros musicales desde el pop hasta el clásico.",
                        Autores = JsonSerializer.Serialize(new string[] { "Alberto Marca", "Carlos Marco" }),
                        Duracion = 1,
                        Actores = JsonSerializer.Serialize(new string[] { "Augusto González", "Fernando Ardévol", "Juan Luis García" }),
                        Imagenes = JsonSerializer.Serialize(new string[] { "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/B-vocal/b-vocal_NF.jpg", "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/B-vocal/b.jpg" }),
                        Fechas = JsonSerializer.Serialize(new string[] { "2024-09-01 - 21:00", "2024-09-03 - 22:30", "2024-09-10 - 23:00" }),
                        Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripci%C3%B3n-obras-teatro/B-vocal/b-vocal_LG.jpg"
                    }
            );
            modelBuilder.Entity<Asientos>().HasData(
                new Asientos
                {
                    IdAsiento = 1,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 2,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 3,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 4,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 5,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 6,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 7,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 8,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 9,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 10,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 11,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 12,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 13,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 14,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 15,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 16,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 17,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 18,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 19,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 21,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 22,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 23,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 24,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 25,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 26,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 27,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 28,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 29,
                    IsFree = true
                },
                new Asientos
                {
                    IdAsiento = 30,
                    IsFree = true
                }
            );
            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios
                {
                idUsuario = 1,
                nombreUsuario = "MarioCañizares",
                password = "1234"
                }
            );
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                idAdministrador = 1,
                nombreAdministrador = "Admin",
                password = "1234"
                }
            );
        }
    }
}
