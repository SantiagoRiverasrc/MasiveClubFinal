using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private BdmasiveContext _context;

        public ProductoRepository(BdmasiveContext context)
        {
            _context = context;
        }


        public IEnumerable<Productos> GetProducto()
        {
            return _context.Productos;
        }

        public Productos GetProductoById(int idProducto)
        {
            return _context.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
        }

        public void InsertProducto(Productos producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Productos producto)
        {
            var ProductoA = _context.Productos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
            ProductoA.Nombre = producto.Nombre;
            ProductoA.Descripcion = producto.Descripcion;
            ProductoA.Precio = producto.Precio;
            ProductoA.Img = producto.Img;
            ProductoA.Audio = producto.Audio;
            _context.SaveChanges();

        }

        public void DeleteProducto(int idProducto)
        {
            var ProductoA = _context.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
            _context.Productos.Remove(ProductoA);
            _context.SaveChanges();
        }
    }
}
