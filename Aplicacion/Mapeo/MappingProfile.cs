using Aplicacion.Features.Solicitudes.Commands;
using AutoMapper;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Mapeo
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateSolicitudCommand, Solicitud>()
                ;
            CreateMap<UpdateSolicitudCommand, Solicitud>();
            
        }
    }
}
