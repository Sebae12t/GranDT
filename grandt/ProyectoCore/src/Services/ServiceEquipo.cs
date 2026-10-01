using ProyectoCore.Models;
using ProyectoCore.Repositories.Interfaces;

namespace ProyectoCore.Services;

public class ServiceEquipo
{
    private readonly IRepoEquipo _repo;
    public ServiceEquipo(IRepoEquipo repo) { _repo = repo; }

    public Task<IEnumerable<Equipo>> ObtenerTodosAsync() => _repo.ObtenerTodosAsync();
    public Task<Equipo?> ObtenerPorIdAsync(int id) => _repo.ObtenerPorIdAsync(id);

    public async Task<int> CrearAsync(Equipo equipo)
    {
        if (string.IsNullOrWhiteSpace(equipo.Nombre))
            throw new ArgumentException("El nombre del equipo no puede estar vacío.");

        var todos = await _repo.ObtenerTodosAsync();
        if (todos.Count() >= 32)
            throw new InvalidOperationException("No se pueden registrar más de 32 equipos.");

        if (todos.Any(e => e.Nombre.Equals(equipo.Nombre, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Ya existe un equipo con ese nombre.");

        return await _repo.CrearAsync(equipo);
    }
}
