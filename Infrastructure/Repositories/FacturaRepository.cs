using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        private BdmasiveContext _context;

        public FacturaRepository(BdmasiveContext context)
        {
            _context = context;
        }


        public IEnumerable<Factura> GetFactura()
        {
            return _context.Factura;
        }

        public Factura GetFacturaById(int idFactura)
        {
            return _context.Factura.FirstOrDefault(x => x.IdFactura == idFactura);
        }

        public void InsertFactura(Factura factura)
        {
            _context.Factura.Add(factura);
            _context.SaveChanges();
        }

        public void UpdateFactura(Factura factura)
        {
            var FacturaA = _context.Factura.FirstOrDefault(x => x.IdFactura == factura.IdFactura);
            FacturaA.Nombre = factura.Nombre;
            FacturaA.Comprador = factura.Comprador;
            FacturaA.Cantidad = factura.Cantidad;
            FacturaA.PrecioTotal = factura.PrecioTotal;
            FacturaA.FechaCompra = factura.FechaCompra;
            _context.SaveChanges();
        }

        public void DeleteFactura(int idFactura)
        {
            var FacturaA = _context.Factura.FirstOrDefault(x => x.IdFactura == idFactura);
            _context.Factura.Remove(FacturaA);
            _context.SaveChanges();
        }
    }
}
