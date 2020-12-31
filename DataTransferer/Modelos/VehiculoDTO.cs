using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferer.Modelos
{
    public class VehiculoDTO
    {
        public int VehId { get; set; }
        public int VehModelo { get; set; }
        public int VehFecha { get; set; }
        public decimal VehCilindraje { get; set; }
        public int VehTipoVehiculo { get; set; }
        public int VehMarca { get; set; }

    }
}
