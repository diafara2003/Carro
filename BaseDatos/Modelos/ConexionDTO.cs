using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDatos.Modelos
{
    public class ConexionDTO
    {
        public ConexionDTO()
        {
            this.parametros = new Dictionary<string, object>();
        }
        public string procedimiento { get; set; }
        public Dictionary<string, object> parametros { get; set; }
    }
}
