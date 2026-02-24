using PjrProject.Models;

namespace PjrProject.Services
{
    public interface IResidenteService
    {
        Task<List<ResidenteDto>> ObtenerPorUnidadAsync(int unidadId);
        Task<List<HistorialDto>> ObtenerHistorialAsync(int residenteId);
    }
}