using Aplicacion.Features.Solicitudes.Commands;
using Aplicacion.Persistencia;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Persistencia
{
    public class SolicitudRepository : RepositoryBase<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(DataBaseDbContext context) : base(context)
        {
        }

        public async Task<List<Solicitud>> GetListSolicitud()
        {
            return await _context.solicitud!.ToListAsync();
        }

        public async Task<List<Solicitud>> GetListSolicitudSP()
        {
            return await _context.solicitud.FromSqlRaw("Sp_Solicitud").ToListAsync();
        }
    }

}
