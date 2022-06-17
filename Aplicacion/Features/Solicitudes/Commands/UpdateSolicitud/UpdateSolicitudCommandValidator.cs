using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.Solicitudes.Commands
{
    public class UpdateSolicitudCommandValidator : AbstractValidator<CreateSolicitudCommand>
    {
        public UpdateSolicitudCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} no puede estar en blanco")
                .NotNull()
                .MaximumLength(50).WithMessage("{Nombre} no puede exceder los 50 caracteres");

            RuleFor(p => p.Apellido)
                .NotEmpty().WithMessage("{Apellido} no puede estar en blanco")
                .NotNull()
                .MaximumLength(50).WithMessage("{Apellido} no puede exceder los 50 caracteres");

        }
    }
}
