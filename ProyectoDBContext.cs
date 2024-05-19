using Microsoft.EntityFrameworkCore;
using Proyecto.Data;

namespace Proyecto.Data
{
    public class ProyectoDBContext : DbContext
    {
        public ProyectoDBContext(DbContextOptions<ProyectoDBContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
    }
}

