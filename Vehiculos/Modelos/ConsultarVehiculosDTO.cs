using DataTransferer.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos.Modelos
{
    public class ConsultarVehiculosDTO: VehiculoDTO
    {
        public string MarNombre { get; set; }
        public string TipVehNombre { get; set; }
        public string TipVehDescripcion { get; set; }
    }
}
