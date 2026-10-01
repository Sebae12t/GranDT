using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoJugador
{
    Task<IEnumerable<Jugador>> ObtenerTodosAsync();
    Task<Jugador?> ObtenerPorIdAsync(int id);
    Task<int> CrearAsync(Jugador jugador);
}
