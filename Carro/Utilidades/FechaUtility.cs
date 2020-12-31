using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carro.Utilidades
{
    public static class FechaUtility
    {

        public static string GetToday() {
            return DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy");
        }
    }
}
