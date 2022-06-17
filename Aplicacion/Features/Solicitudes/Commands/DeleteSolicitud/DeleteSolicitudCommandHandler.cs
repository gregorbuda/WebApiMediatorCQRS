using Aplicacion.Exceptions;
using Aplicacion.Persistencia;
using AutoMapper;
using Dominio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.Solicitudes.Commands.DeleteSolicitud
{
    public class DeleteSolicitudCommandHandler : IRequestHandler<DeleteSolicitudCommand>
    {
        private readonly ISolicitudRepository _solicitudRepository;
        private readonly IMapper _mapper;

        public DeleteSolicitudCommandHandler(ISolicitudRepository solicitudRepository, IMapper mapper)
        {
            _solicitudRepository = solicitudRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteSolicitudCommand request, CancellationToken cancellationToken)
        {
            var streamerToDelete = await _solicitudRepository.GetByIdAsync(request.Id);
            if (streamerToDelete == null)
            {
                throw new NotFoundException(nameof(Solicitud), request.Id);
            }

            await _solicitudRepository.DeleteAsync(streamerToDelete);

            return Unit.Value;
        }
    }
}
