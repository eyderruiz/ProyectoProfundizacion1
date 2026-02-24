using PjrProject.Models;

namespace PjrProject.Services
{
    public class ResidenteService : IResidenteService
    {
        public Task<List<ResidenteDto>> ObtenerPorUnidadAsync(int unidadId)
        {
            var mock = new List<ResidenteDto>
            {
                new ResidenteDto { Id = 1, Nombre = "Ana Pérez", Unidad = "A-101", Telefono = "3001112222" },
                new ResidenteDto { Id = 2, Nombre = "Carlos Gómez", Unidad = "B-202", Telefono = "3003334444" }
            };
            return Task.FromResult(mock);
        }

        public Task<List<HistorialDto>> ObtenerHistorialAsync(int residenteId)
        {
            var mock = new List<HistorialDto>
            {
                new HistorialDto { Id = 1, Fecha = System.DateTime.Now.AddMonths(-2), Detalle = "Creado" },
                new HistorialDto { Id = 2, Fecha = System.DateTime.Now.AddDays(-10), Detalle = "Actualizado datos de contacto" }
            };
            return Task.FromResult(mock);
        }
    }
}