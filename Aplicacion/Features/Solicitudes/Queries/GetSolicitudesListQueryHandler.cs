using Aplicacion.Persistencia;
using Dominio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.Solicitudes.Queries
{
    public class GetSolicitudesListQueryHandler : IRequestHandler<GetSolicitudesListQuery, List<Solicitud>>
    {
        private readonly ISolicitudRepository _videoSolicitudrepository;

        public GetSolicitudesListQueryHandler(IMediator mediator, ISolicitudRepository Solicitudrepository)
        {
            _videoSolicitudrepository = Solicitudrepository;
        }

        public async  Task<List<Solicitud>> Handle(GetSolicitudesListQuery request, CancellationToken cancellationToken)
        {
           var solicitud = await _videoSolicitudrepository.GetListSolicitud();

            return solicitud;
        }
    }
}
