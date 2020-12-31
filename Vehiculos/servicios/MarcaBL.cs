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
            objdto.procedimiento = "dbo.ConsultarVehiculo";
            objdto.parametros.Add("@tipo",(int) TipoConsulta.Marca);

            return MapperCustom.DataTableToList<MarcaDTO>(
                new Operaciones().ConsultarSPDT(objdto));


        }
    }
}
