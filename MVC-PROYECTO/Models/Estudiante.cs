namespace MVC_PROYECTO.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Correo { get; set; } = "";
        public int Edad { get; set; }
    }
}
