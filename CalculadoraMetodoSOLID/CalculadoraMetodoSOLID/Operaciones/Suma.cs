﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetodoSOLID
{
    public class Suma : OperacionAbstracta
    {
        public override float EjecutaOperacion()
        {
            return x + y;
        }
    }
}
