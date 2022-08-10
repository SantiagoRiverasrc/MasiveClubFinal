using Application.Request.Producto;
using Application.Responses;
using AutoMapper;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class ProductoMappingProfile : Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<CreateProductoRequest, Productos>();
            CreateMap<Productos, CreateProductoRequest>();

            CreateMap<UpdateProductoRequest, Productos>();
            CreateMap<Productos, UpdateProductoRequest>();

            CreateMap<Productos, ProductoResponse>();
        }
    }
}
