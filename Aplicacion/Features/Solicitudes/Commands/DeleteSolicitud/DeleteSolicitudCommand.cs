using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.Solicitudes.Commands.DeleteSolicitud
{
    public class DeleteSolicitudCommand : IRequest
    {
        public int Id { get; set; }
    }
}
