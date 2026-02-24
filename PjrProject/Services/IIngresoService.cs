using PjrProject.Models;

namespace PjrProject.Services
{
    public interface IIngresoService
    {
        Task<List<IngresoDto>> ObtenerRegistrosAsync();
        Task<List<TipoIngresoDto>> ObtenerTiposAsync();
        Task<List<ParqueaderoDto>> ObtenerParqueaderosAsync();
        Task<List<TipoParqueaderoDto>> ObtenerTiposParqueaderoAsync();
    }
}