using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Infraestructura.Persistencia
{
    public class DataBaseDbContext : DbContext
    {
        public DataBaseDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Solicitud> solicitud { get; set; }
    }
}
