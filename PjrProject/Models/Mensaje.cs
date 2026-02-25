namespace PjrProject.Models
{
    public class Mensaje
    {
        public long Id { get; set; }
        public string Empresa { get; set; }
        public string Guia { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime FechaEntrega { get; set; }

        public Apartamento UnidadId { get; set; }
    }
}
