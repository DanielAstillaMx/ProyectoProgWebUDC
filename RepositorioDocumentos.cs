using Microsoft.EntityFrameworkCore;
//using Proyecto.Components.Pages;
using Proyecto.Data;
using Proyecto.Repositorio;

namespace Proyecto.Repositorio
{
    public class RepositorioDocumentos : IRepositorioDocumentos
    {
        private readonly ProyectoDBContext _context;

        public RepositorioDocumentos(ProyectoDBContext context)
        {
            _context = context;
        }

        public async Task<Documento> Add(Documento documento)
        {
            await _context.Documentos.AddAsync(documento);
            await _context.SaveChangesAsync();
            return documento;
        }

        public async Task Delete(int Id)
        {
            var documento = await _context.Documentos.FindAsync(Id);
            if (documento != null)
            {
                _context.Documentos.Remove(documento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Documento?> Get(int Id)
        {
            return await _context.Documentos.FindAsync(Id);
        }

        public async Task<List<Documento>> GetAll()
        {
            return await _context.Documentos.ToListAsync();
        }

        public async Task Update(int Id, Documento documento)
        {
            var documentoActual = await _context.Documentos.FindAsync(Id);
            if (documentoActual != null)
            {
                documentoActual.Titulo = documento.Titulo;
                documentoActual.UsuarioID = documento.UsuarioID;
                documentoActual.FechaInicio = documento.FechaInicio;
                documentoActual.PalabrasClave = documento.PalabrasClave;
                documentoActual.Resumen = documento.Resumen;
                await _context.SaveChangesAsync();
            }
        }
    }
}
