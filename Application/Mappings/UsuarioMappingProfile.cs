using Application.Request.Usuario;
using Application.Responses;
using AutoMapper;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<CreateUsuarioRequest, Usuario>();
            CreateMap<Usuario, CreateUsuarioRequest>();

            CreateMap<UpdateUsuarioRequest, Usuario>();
            CreateMap<Usuario, UpdateUsuarioRequest>();

            CreateMap<Usuario, UsuarioResponse>();
        }
    }
}
