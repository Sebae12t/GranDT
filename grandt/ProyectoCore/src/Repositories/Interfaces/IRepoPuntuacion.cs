using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoPuntuacion
{
    Task<bool> RegistrarPuntuacionAsync(Puntuacion puntuacion);
    Task<IEnumerable<Puntuacion>> ObtenerPorJugadorIdAsync(int jugadorId);
}
