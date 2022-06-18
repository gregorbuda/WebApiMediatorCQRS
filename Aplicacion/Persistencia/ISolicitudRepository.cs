using Aplicacion.Features.Solicitudes.Commands;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Persistencia
{
    public interface ISolicitudRepository : IAsyncRepository<Solicitud>
    {
        Task<List<Solicitud>> GetListSolicitud();

        Task<List<Solicitud>> GetListSolicitudSP();
    }
}
