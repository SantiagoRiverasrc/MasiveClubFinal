using Application.Interfaces.App;
using Application.Request.Factura;
using Application.Responses;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IFacturaRepository _repository;
        private readonly IMapper _mapper;

        public FacturaService(IFacturaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteFactura(int idFactura)
        {
            _repository.DeleteFactura(idFactura);
        }

        public FacturaResponse GetFacturaById(int idFactura)
        {
            var factura = _repository.GetFacturaById(idFactura);
            var facturaResponse = _mapper.Map<FacturaResponse>(factura);
            return facturaResponse;
        }

        public IEnumerable<FacturaResponse> GetFactura()
        {
            var factura = _repository.GetFactura();
            var facturaResponse = _mapper.Map<IEnumerable<FacturaResponse>>(factura);
            return facturaResponse;
        }

        public void InsertFactura(CreateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.InsertFactura(factura);
        }

        public void UpdateFactura(UpdateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.UpdateFactura(factura);
        }
    }
}
