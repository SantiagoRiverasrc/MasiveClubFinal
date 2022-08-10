using Application.Interfaces.App;
using Application.Request.Producto;
using Application.Responses;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProducto(int idProducto)
        {
            _repository.DeleteProducto(idProducto);
        }

        public ProductoResponse GetProductoById(int idProducto)
        {
            var producto = _repository.GetProductoById(idProducto);
            var productoResponse = _mapper.Map<ProductoResponse>(producto);
            return productoResponse;
        }

        public IEnumerable<ProductoResponse> GetProducto()
        {
            var producto = _repository.GetProducto();
            var productoResponse = _mapper.Map<IEnumerable<ProductoResponse>>(producto);
            return productoResponse;
        }

        public void InsertProducto(CreateProductoRequest request)
        {
            var producto = _mapper.Map<Productos>(request);
            _repository.InsertProducto(producto);
        }

        public void UpdateProducto(UpdateProductoRequest request)
        {
            var producto = _mapper.Map<Productos>(request);
            _repository.UpdateProducto(producto);
        }
    }
}
