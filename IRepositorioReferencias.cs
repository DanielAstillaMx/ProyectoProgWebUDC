using Proyecto.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto.Repositorio
{
    public interface IRepositorioReferencias
    {
        Task<List<Referencia>> GetAll();
        Task<Referencia?> Get(int Id);
        Task<Referencia> Add(Referencia referencia);
        Task Update(int Id, Referencia referencia);
        Task Delete(int Id);
    }
}
