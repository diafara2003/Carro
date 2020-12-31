using DataTransferer.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehiculos.servicios;

namespace Carro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {

        [HttpGet]
        public IList<MarcaDTO> Get()
        {
            return new MarcaBL().Get();
        }
    }
}
