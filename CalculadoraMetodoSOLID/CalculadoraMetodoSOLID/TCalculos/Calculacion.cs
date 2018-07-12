using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetodoSOLID
{
    public class Calculacion
    {
        //Esta funcion recibe el tipo de operacion a realizar y ejecuta la misma
        public float Calcula(OperacionAbstracta calc)
        {
            return calc.EjecutaOperacion();
        }

    }
}
