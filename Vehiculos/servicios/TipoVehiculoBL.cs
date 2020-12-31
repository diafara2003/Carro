using BaseDatos.Modelos;
using BaseDatos.Servicios;
using DataTransferer.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos.servicios
{
    public class TipoVehiculoBL
    {
        public IList<TipoVehiculoDTO> Get()
        {

            ConexionDTO objdto = new ConexionDTO();
            objdto.procedimiento = "dbo.ConsultarVehiculo";
            objdto.parametros.Add("@tipo",(int) TipoConsulta.TipoVehiculo);

            return MapperCustom.DataTableToList<TipoVehiculoDTO>(
                new Operaciones().ConsultarSPDT(objdto));


        }
    }
}
