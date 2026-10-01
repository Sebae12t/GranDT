using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoPlantilla
{
    Task<Plantilla?> ObtenerPorUsuarioIdAsync(int usuarioId);
    Task<Plantilla?> ObtenerPorIdAsync(int id);
    Task<int> CrearAsync(Plantilla plantilla);
}
