namespace PjrProject.Models
{
    public class HistorialDto
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Detalle { get; set; } = string.Empty;
    }
}