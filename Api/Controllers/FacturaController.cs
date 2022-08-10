using Application.Interfaces.App;
using Application.Request.Factura;
using Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _service;

        public FacturaController(IFacturaService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_service.GetFactura());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<FacturaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

        public IActionResult Post(CreateFacturaRequest request)
        {
            _service.InsertFactura(request);
            return Ok();
        }

        [HttpGet("{IdFactura}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(FacturaResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetFacturaRequest request)
        {
            return Ok(_service.GetFacturaById(request.IdFactura));
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult Put(UpdateFacturaRequest request)
        {
            _service.UpdateFactura(request);
            return Ok();
        }

        [HttpDelete("{IdFactura}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Delete([FromRoute] DeleteFacturaRequest request)
        {

            _service.DeleteFactura(request.IdFactura);
            return Ok();
        }
    }
}
