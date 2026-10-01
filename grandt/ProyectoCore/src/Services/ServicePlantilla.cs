using ProyectoCore.Models;
using ProyectoCore.Repositories.Interfaces;

namespace ProyectoCore.Services;

public class ServicePlantilla
{
    private readonly IRepoPlantilla _repo;
    public ServicePlantilla(IRepoPlantilla repo) { _repo = repo; }

    public Task<Plantilla?> ObtenerPorUsuarioIdAsync(int usuarioId) => _repo.ObtenerPorUsuarioIdAsync(usuarioId);
    public Task<Plantilla?> ObtenerPorIdAsync(int id) => _repo.ObtenerPorIdAsync(id);

    public async Task<int> CrearAsync(Plantilla plantilla)
    {
        if (string.IsNullOrWhiteSpace(plantilla.Nombre))
            throw new ArgumentException("El nombre de la plantilla es obligatorio.");

        return await _repo.CrearAsync(plantilla);
    }
}
