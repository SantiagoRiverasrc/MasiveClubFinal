using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProductoRepository
    {
        Productos GetProductoById(int idProducto);

        IEnumerable<Productos> GetProducto();

        void InsertProducto(Productos producto);

        void UpdateProducto(Productos producto);

        void DeleteProducto(int idProducto);
    }
}
