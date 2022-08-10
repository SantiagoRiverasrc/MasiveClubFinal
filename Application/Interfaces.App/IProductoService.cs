using Application.Request.Producto;
using Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.App
{
    public interface IProductoService
    {
        ProductoResponse GetProductoById(int idProducto);
        IEnumerable<ProductoResponse> GetProducto();

        void InsertProducto(CreateProductoRequest producto);

        void UpdateProducto(UpdateProductoRequest producto);

        void DeleteProducto(int idProducto);
    }
}
