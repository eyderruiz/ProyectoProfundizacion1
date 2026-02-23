namespace PjrProject.Models
{
    public class Apartamento
    {
        public long UnidadId { get; set; }
        public Torre TorreId { get; set; }
        public long Numero { get; set; }
        public string Tipo { get; set; }
        public Double Area { get; set; }
    }
}
