using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoPosicion
{
    Task<IEnumerable<Posicion>> ObtenerTodasAsync();
    Task<Posicion?> ObtenerPorIdAsync(int id);
}
