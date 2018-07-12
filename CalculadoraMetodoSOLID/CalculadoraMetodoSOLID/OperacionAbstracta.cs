using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetodoSOLID
{
    public abstract class OperacionAbstracta
    {
        //Inicializar las variables comunes de operaciones matematicas
        public float x { get; set; }
        public float y { get; set; }

        //funcion que se sobreEscribira para ejecutaroperaciones de cualquier tipo
        public abstract float EjecutaOperacion();
    }
}
