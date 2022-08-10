using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Request.Factura
{
    public class UpdateFacturaRequest
    {
        public int IdFactura { get; set; }
        public string Nombre { get; set; }
        public string Comprador { get; set; }
        public int Cantidad { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
