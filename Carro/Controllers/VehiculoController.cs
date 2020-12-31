using DataTransferer.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehiculos.Modelos;
using Vehiculos.servicios;

namespace Carro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {

        [HttpGet]
        public IList<ConsultarVehiculosDTO> Get()
        {
            return new VehiculoBL().Get();
        }

        [HttpPost]
        public IActionResult Post(VehiculoDTO request)
        {
            if (request.VehFecha > DateTime.Now.Year)
                return BadRequest("La fecha ingreada no puede ser mayor al año actual");

            return Ok(new VehiculoBL().Insert(request));
        }

        [HttpGet]
        [Route("TipoVehiculo")]
        public IList<TipoVehiculoDTO> GetTipovehiculo()
        {
            return new TipoVehiculoBL().Get();
        }
    }
}
