using ProyectoCore.Models;
using ProyectoCore.Repositories.Interfaces;

namespace ProyectoCore.Services;

public class ServicePosicion
{
    private readonly IRepoPosicion _repo;
    public ServicePosicion(IRepoPosicion repo) { _repo = repo; }

    public Task<IEnumerable<Posicion>> ObtenerTodasAsync() => _repo.ObtenerTodasAsync();
    public Task<Posicion?> ObtenerPorIdAsync(int id) => _repo.ObtenerPorIdAsync(id);
}
