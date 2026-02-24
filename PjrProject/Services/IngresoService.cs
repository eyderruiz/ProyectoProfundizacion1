using PjrProject.Models;

namespace PjrProject.Services
{
    public class IngresoService : IIngresoService
    {
        public Task<List<IngresoDto>> ObtenerRegistrosAsync()
        {
            var mock = new List<IngresoDto>
            {
                new IngresoDto { Id = 1, Tipo = "Visita", Fecha = System.DateTime.Now.AddHours(-3), Origen = "Portería" },
                new IngresoDto { Id = 2, Tipo = "Proveedor", Fecha = System.DateTime.Now.AddDays(-1), Origen = "Recepción" }
            };
            return Task.FromResult(mock);
        }

        public Task<List<TipoIngresoDto>> ObtenerTiposAsync()
        {
            var mock = new List<TipoIngresoDto>
            {
                new TipoIngresoDto { Id = 1, Nombre = "Visita" },
                new TipoIngresoDto { Id = 2, Nombre = "Proveedor" }
            };
            return Task.FromResult(mock);
        }

        public Task<List<ParqueaderoDto>> ObtenerParqueaderosAsync()
        {
            var mock = new List<ParqueaderoDto>
            {
                new ParqueaderoDto { Id = 1, Nombre = "Parqueadero A", Ubicacion = "Sótano 1", Capacidad = 40 }
            };
            return Task.FromResult(mock);
        }

        public Task<List<TipoParqueaderoDto>> ObtenerTiposParqueaderoAsync()
        {
            var mock = new List<TipoParqueaderoDto>
            {
                new TipoParqueaderoDto { Id = 1, Nombre = "Privado" },
                new TipoParqueaderoDto { Id = 2, Nombre = "Visitantes" }
            };
            return Task.FromResult(mock);
        }
    }
}