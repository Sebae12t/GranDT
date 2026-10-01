using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoPlantillaTitular
{
    Task<bool> AgregarTitularAsync(int plantillaId, int jugadorId);
    Task<bool> RemoverTitularAsync(int plantillaId, int jugadorId);
}
