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
    public class CreateSolicitudCommandHandler : IRequestHandler<CreateSolicitudCommand, int>
    {
        private readonly ISolicitudRepository _solicitudRepository;
        private readonly IMapper _mapper;
        public CreateSolicitudCommandHandler(ISolicitudRepository solicitudRepository, IMapper mapper)
        {
            _solicitudRepository = solicitudRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateSolicitudCommand request, CancellationToken cancellationToken)
        {
            var streamerEntity = _mapper.Map<Solicitud>(request);

            var newStreamer = await _solicitudRepository.AddAsync(streamerEntity);

            return newStreamer.Id;
        }
    }
}
