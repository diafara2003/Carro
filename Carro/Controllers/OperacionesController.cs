using Carro.Modelos;
using Carro.Utilidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {

        [HttpPost]
        [Route("dividir")]
        public IActionResult PostDivisesion(OperarNumeroDTO request)
        {

            if (request.numero2 == 0)
                return BadRequest("No se puede dividir en 0");

            return Ok(OperacionNumUtility.Dividir(request.numero1, request.numero2));

        }
    }
}
