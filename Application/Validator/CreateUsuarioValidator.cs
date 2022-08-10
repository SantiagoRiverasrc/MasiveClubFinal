using Application.Request.Usuario;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validator
{
    public class CreateUsuarioValidator : AbstractValidator<CreateUsuarioRequest>
    {
        public CreateUsuarioValidator()
        {
            //Validaciones para Email
            RuleFor(x => x.Email)
              .NotEmpty()
              .WithMessage("Debe ingresar un correo, por favor vuelva a intentarlo");

            //Validaciones para Contraseña 
            RuleFor(x => x.Contraseña)
                .NotEmpty()
                .WithMessage("La contraseña es requeridad, por favor vuelva a intentarlo");

        }
    }
}
