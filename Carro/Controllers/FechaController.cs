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
    public class FechaController : ControllerBase
    {

        [HttpGet]
        public string Get() {
            return FechaUtility.GetToday();
        }
    }
}
