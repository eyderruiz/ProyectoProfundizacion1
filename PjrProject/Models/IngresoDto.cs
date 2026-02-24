namespace PjrProject.Models
{
    public class IngresoDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public System.DateTime Fecha { get; set; }
        public string Origen { get; set; } = string.Empty;
    }
}