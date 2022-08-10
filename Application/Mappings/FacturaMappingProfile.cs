using Application.Request.Factura;
using Application.Responses;
using AutoMapper;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class FacturaMappingProfile : Profile
    {
        public FacturaMappingProfile()
        {
            CreateMap<CreateFacturaRequest, Factura>();
            CreateMap<Factura, CreateFacturaRequest>();

            CreateMap<UpdateFacturaRequest, Factura>();
            CreateMap<Factura, UpdateFacturaRequest>();

            CreateMap<Factura, FacturaResponse>();
        }
    }
}
