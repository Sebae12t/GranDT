using ProyectoCore.Models;
namespace ProyectoCore.Repositories.Interfaces;
public interface IRepoUsuario
{
    Task<Usuario?> ObtenerPorEmailAsync(string email);
    Task<Usuario?> ObtenerPorIdAsync(int id);
    Task<int> CrearAsync(Usuario usuario);
}
