using Aplicacion.Features.Solicitudes.Commands;
using Aplicacion.Features.Solicitudes.Commands.DeleteSolicitud;
using Aplicacion.Features.Solicitudes.Queries;
using Aplicacion.Persistencia;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApiMediatorCQRS.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SolicitudController : ControllerBase
    {
        private IMediator _mediator;
        private ISolicitudRepository _solicitudRepository;

        public SolicitudController(IMediator mediator, ISolicitudRepository solicitudRepository)
        {
            _mediator = mediator;
            _solicitudRepository = solicitudRepository;
        }


        [HttpGet]
        [Route("GetSolicitud")]
        [ProducesResponseType(typeof(List<Solicitud>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<Solicitud>>> GetSolicitud()
        {
            var query = new GetSolicitudesListQuery();
            var solicitudes = await _mediator.Send(query);
            return Ok(solicitudes);
        }

        [HttpGet]
        [Route("GetSolicitudSp")]
        [ProducesResponseType(typeof(List<Solicitud>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<Solicitud>>> GetSolicitudSp()
        {
            var query = new GetSolicitudSP();
            var solicitudes = await _mediator.Send(query);
            return Ok(solicitudes);
        }

        [HttpPost(Name = "CreateSolicitud")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateStreamer([FromBody] CreateSolicitudCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut(Name = "UpdateSolicitud")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateSolicitud([FromBody] UpdateSolicitudCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }


        [HttpDelete("{id}", Name = "DeleteSolicitud")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteSolicitud(int id)
        {
            var command = new DeleteSolicitudCommand
            {
                Id = id
            };

            await _mediator.Send(command);

            return NoContent();
        }

    }
}
