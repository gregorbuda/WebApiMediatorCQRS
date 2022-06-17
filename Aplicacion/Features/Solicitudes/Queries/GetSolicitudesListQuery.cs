using Dominio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.Solicitudes.Queries
{
    public class GetSolicitudesListQuery : IRequest<List<Solicitud>>
    {

    }
}
