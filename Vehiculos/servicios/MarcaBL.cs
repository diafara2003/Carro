using BaseDatos.Modelos;
using BaseDatos.Servicios;
using DataTransferer.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.servicios
{
  public   class MarcaBL
    {

        public IList<MarcaDTO> Get()
        {

            ConexionDTO objdto = new ConexionDTO();
            objdto.procedimiento = "ConsultarVehiculo";
            objdto.parametros.Add("@tipo", TipoConsulta.Marca);

            return MapperCustom.DataTableToList<MarcaDTO>(
                new Operaciones().ConsultarSPDT(objdto));


        }
    }
}
