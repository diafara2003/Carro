using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carro.Utilidades
{
    public class OperacionNumUtility
    {

        public static decimal Dividir(decimal numero1, decimal numero2)
        {

            if (numero2 == 0)
                return 0;


            return numero1 / numero2;
        }
    }
}
