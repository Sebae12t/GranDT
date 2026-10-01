using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoEquipo
{
    Task<IEnumerable<Equipo>> ObtenerTodosAsync();
    Task<Equipo?> ObtenerPorIdAsync(int id);
    Task<int> CrearAsync(Equipo equipo);
}
