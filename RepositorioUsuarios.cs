using Microsoft.EntityFrameworkCore;
//using Proyecto.Components.Pages;
using Proyecto.Data;
using Proyecto.Repositorio;

namespace Proyecto.Repositorio
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ProyectoDBContext _context;

        public RepositorioUsuarios(ProyectoDBContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Add(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
        public async Task Delete(int ID)
        {
            var usuario = await _context.Usuarios.FindAsync(ID);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Usuario?> Get(int ID)
        {
            return await _context.Usuarios.FindAsync(ID);
        }
        public async Task<List<Usuario>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }
        //Mostrar lista de documentos
        public async Task<List<Documento>> GetDocumentos()
        {
            return await _context.Documentos.ToListAsync();
        }

        public async Task Update(int ID, Usuario usuario)
        {
            var usuarioactual = await _context.Usuarios.FindAsync(ID);
            if (usuarioactual != null)
            {
                usuarioactual.Nombre = usuario.Nombre;
                usuarioactual.Correo = usuario.Correo;
                usuarioactual.Telefono = usuario.Telefono;
                await _context.SaveChangesAsync();
            }
        }
    }
}    