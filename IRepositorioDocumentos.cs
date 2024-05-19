using Proyecto.Data;


namespace Proyecto.Repositorio
{
    public interface IRepositorioDocumentos
    {
        Task<List<Documento>> GetAll();
        Task<Documento?> Get(int Id);
        Task<List<Documento>> GetDocumentos();
        Task<Documento> Add(Documento documento);
        Task Update(int Id, Documento documento);
        Task Delete(int Id);
    }
}
