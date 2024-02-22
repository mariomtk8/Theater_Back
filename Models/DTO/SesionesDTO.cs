namespace UrbanTheater.Models
{
    public class SesionesReadDTO
    {
        public int IdSesion { get; set; }
        public int FuncionId { get; set; }
        public DateTime Fecha { get; set; }
        // Omitimos Asientos para evitar el ciclo
    }

    public class SesionesCreateDTO
    {
        public int FuncionId { get; set; }
        public DateTime Fecha { get; set; }
        // Aquí podrías incluir propiedades para crear Asientos si es necesario
    }
}
