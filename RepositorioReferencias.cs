using Microsoft.EntityFrameworkCore;
using Proyecto.Data;

namespace Proyecto.Repositorio
{
    public class RepositorioReferencias : IRepositorioReferencias
    {
        private readonly ProyectoDBContext _context;

        public RepositorioReferencias(ProyectoDBContext context)
        {
            _context = context;
        }

        public async Task<Referencia> Add(Referencia referencia)
        {
            await _context.Referencias.AddAsync(referencia);
            await _context.SaveChangesAsync();
            return referencia;
        }

        public async Task Delete(int Id)
        {
            var referencia = await _context.Referencias.FindAsync(Id);
            if (referencia != null)
            {
                _context.Referencias.Remove(referencia);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Referencia?> Get(int Id)
        {
            return await _context.Referencias.FindAsync(Id);
        }

        public async Task<List<Referencia>> GetAll()
        {
            return await _context.Referencias.ToListAsync();
        }

        public async Task Update(int Id, Referencia referencia)
        {
            var referenciaActual = await _context.Referencias.FindAsync(Id);
            if (referenciaActual != null)
            {
                referenciaActual.Titulo = referencia.Titulo;
                referenciaActual.Autores = referencia.Autores;
                referenciaActual.AnioPublicacion = referencia.AnioPublicacion;
                referenciaActual.PaginaReferencia = referencia.PaginaReferencia;
                referenciaActual.PalabrasClave = referencia.PalabrasClave;
                await _context.SaveChangesAsync();
            }
        }
    }
}
