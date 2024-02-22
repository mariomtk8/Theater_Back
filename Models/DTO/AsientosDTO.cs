namespace UrbanTheater.Models
{
    public class AsientoReadDTO
    {
        public int IdAsiento { get; set; }
        public bool IsFree { get; set; }
        public int IdSesion { get; set; }
    }

    public class AsientoCreateUpdateDTO
    {
        public bool IsFree { get; set; }
        public int IdSesion { get; set; }
    }
}