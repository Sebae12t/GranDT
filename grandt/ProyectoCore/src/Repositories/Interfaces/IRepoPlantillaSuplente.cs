using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoPlantillaSuplente
{
    Task<bool> AgregarSuplenteAsync(int plantillaId, int jugadorId);
    Task<bool> RemoverSuplenteAsync(int plantillaId, int jugadorId);
}
