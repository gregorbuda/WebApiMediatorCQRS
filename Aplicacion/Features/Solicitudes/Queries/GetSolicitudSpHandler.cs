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
    public class GetSolicitudSpHandler : IRequestHandler<GetSolicitudSP, List<Solicitud>>
    {
        private readonly ISolicitudRepository _videoSolicitudrepository;

        public GetSolicitudSpHandler(IMediator mediator, ISolicitudRepository videoSolicitudrepository)
        {
            _videoSolicitudrepository = videoSolicitudrepository;
        }

        public async Task<List<Solicitud>> Handle(GetSolicitudSP request, CancellationToken cancellationToken)
        {
            var solicitud = await _videoSolicitudrepository.GetListSolicitudSP();

            return solicitud;
        }
    }
}
