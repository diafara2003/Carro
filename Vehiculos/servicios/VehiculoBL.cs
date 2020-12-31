using BaseDatos.Modelos;
using BaseDatos.Servicios;
using DataTransferer.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Vehiculos.Modelos;

namespace Vehiculos.servicios
{

    public enum TipoConsulta
    {
        Vehiculo = 1,
        Marca = 2,
        TipoVehiculo = 3
    }

    public class VehiculoBL
    {

        public IList<ConsultarVehiculosDTO> Insert(VehiculoDTO modelo)
        {
            ConexionDTO objdto = new ConexionDTO();
            ResponseDTO objresultado = new ResponseDTO();

            objdto.procedimiento = "IngresarVehiculo";
            objdto.parametros.Add("@VehCilindraje", modelo.VehCilindraje);
            objdto.parametros.Add("@VehFecha", modelo.VehFecha);
            objdto.parametros.Add("@VehMarca", modelo.VehMarca);
            objdto.parametros.Add("@VehModelo", modelo.VehModelo);
            objdto.parametros.Add("@VehTipoVehiculo", modelo.VehTipoVehiculo);

            try
            {
                new Operaciones().ExecuteNonQuerySP(objdto);

                return Get();
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public IList<ConsultarVehiculosDTO> Get()
        {

            ConexionDTO objdto = new ConexionDTO();
            objdto.procedimiento = "ConsultarVehiculo";
            objdto.parametros.Add("@tipo", TipoConsulta.Vehiculo);

            return MapperCustom.DataTableToList<ConsultarVehiculosDTO>(
                new Operaciones().ConsultarSPDT(objdto));


        }
    }
}
