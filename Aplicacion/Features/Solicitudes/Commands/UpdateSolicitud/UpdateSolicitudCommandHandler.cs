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

namespace Aplicacion.Features.Solicitudes.Commands
{
    public class UpdateSolicitudCommandHandler : IRequestHandler<UpdateSolicitudCommand>
    {
        private readonly ISolicitudRepository _solicitudRepository;
        private readonly IMapper _mapper;
        public UpdateSolicitudCommandHandler(ISolicitudRepository solicitudRepository, IMapper mapper)
        {
            _solicitudRepository = solicitudRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSolicitudCommand request, CancellationToken cancellationToken)
        {
            var streamerToUpdate = await _solicitudRepository.GetByIdAsync(request.Identificacion);

            if (streamerToUpdate == null)
            {
                throw new NotFoundException(nameof(Solicitud), request.Identificacion);
            }

            _mapper.Map(request, streamerToUpdate, typeof(UpdateSolicitudCommand), typeof(Solicitud));

            await _solicitudRepository.UpdateAsync(streamerToUpdate);

            return Unit.Value;
        }
    }
}
