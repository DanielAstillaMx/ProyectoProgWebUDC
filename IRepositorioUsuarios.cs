using Proyecto.Data;

namespace Proyecto.Repositorio
{
    public interface IRepositorioUsuarios
    {
        Task<List<Usuario>> GetAll();
        Task<Usuario?> Get(int ID);
        Task<Usuario> Add(Usuario Usuario);
        Task Update(int ID, Usuario Usuario);
        Task Delete(int ID);

    }
}
