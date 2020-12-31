using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferer.Modelos
{
    public class VehiculoDTO
    {
        public int VehId { get; set; }
        public string VehModelo { get; set; }
        public int VehFecha { get; set; }
        public decimal VehCilindraje { get; set; }
        public string VehTipoVehiculo { get; set; }
        public string VehMarca { get; set; }

    }
}
