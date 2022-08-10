using Application.Request.Factura;
using Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.App
{
    public interface IFacturaService
    {
        FacturaResponse GetFacturaById(int idFactura);
        IEnumerable<FacturaResponse> GetFactura();

        void InsertFactura(CreateFacturaRequest factura);

        void UpdateFactura(UpdateFacturaRequest factura);

        void DeleteFactura(int idFactura);

    }
}
